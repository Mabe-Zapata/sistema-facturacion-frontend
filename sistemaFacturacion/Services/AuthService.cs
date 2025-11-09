using Microsoft.AspNetCore.Components.Authorization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

public class AuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly SessionService _sessionService;

    public sealed record RecoverPasswordResult(bool Success, bool NotFound, string? Message);
    public AuthService(HttpClient httpClient,
                       AuthenticationStateProvider authenticationStateProvider,
                       SessionService sessionService)
    {
        _httpClient = httpClient;
        _authenticationStateProvider = authenticationStateProvider;
        _sessionService = sessionService;
    }

    public async Task<bool> LoginAsync(LoginRequest loginRequest)
    {
        try
        {
            var json = System.Text.Json.JsonSerializer.Serialize(loginRequest);

            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);

            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) return false;

            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
            if (loginResponse == null || string.IsNullOrEmpty(loginResponse.Token)) return false;

            await _sessionService.SaveTokenAsync(loginResponse.Token);
            ((CustomAuthStateProvider)_authenticationStateProvider).NotifyUserAuthentication(loginResponse.Token);

            return true;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<RecoverPasswordResult> RecoverPasswordAsync(string email, CancellationToken ct = default)
    {
        using var resp = await _httpClient.PostAsJsonAsync("api/auth/recover-password", new { email }, ct);

        if (resp.IsSuccessStatusCode)
            return new RecoverPasswordResult(true, false, null);

        if (resp.StatusCode == HttpStatusCode.NotFound)
        {
            var txt = await resp.Content.ReadAsStringAsync(ct);
            var msg = string.IsNullOrWhiteSpace(txt) ? "Usuario no encontrado." : txt;
            return new RecoverPasswordResult(false, true, msg);
        }

        var body = await resp.Content.ReadAsStringAsync(ct);
        var fallback = string.IsNullOrWhiteSpace(body) ? "No se pudo procesar la solicitud." : body;
        return new RecoverPasswordResult(false, false, fallback);
    }

    public async Task<bool> SendPasswordResetEmailAsync(string email, CancellationToken ct = default)
    {
        var r = await RecoverPasswordAsync(email, ct);
        return r.Success; 
    }

    public async Task LogoutAsync()
    {
        await _sessionService.ClearAllSession();
        ((CustomAuthStateProvider)_authenticationStateProvider).NotifyUserLogout();
    }
}