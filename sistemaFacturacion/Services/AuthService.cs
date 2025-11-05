using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

public class AuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly SessionService _sessionService;

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
            // DEBUG: Ver qué se envía
            var json = System.Text.Json.JsonSerializer.Serialize(loginRequest);
            Console.WriteLine($"JSON enviado: {json}");

            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);

            // DEBUG: Ver respuesta
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Respuesta API: {responseBody}");
            Console.WriteLine($"Status Code: {response.StatusCode}");

            if (!response.IsSuccessStatusCode) return false;

            var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
            if (loginResponse == null || string.IsNullOrEmpty(loginResponse.Token)) return false;

            await _sessionService.SaveTokenAsync(loginResponse.Token);
            ((CustomAuthStateProvider)_authenticationStateProvider).NotifyUserAuthentication(loginResponse.Token);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error completo: {ex}");
            throw;
        }
    }

    public async Task LogoutAsync()
    {
        await _sessionService.ClearAllSession();
        ((CustomAuthStateProvider)_authenticationStateProvider).NotifyUserLogout();
    }
}