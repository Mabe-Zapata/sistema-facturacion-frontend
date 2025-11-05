using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private readonly SessionService _sessionService;
    private readonly HttpClient _httpClient;
    private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

    public CustomAuthStateProvider(SessionService sessionService, HttpClient httpClient)
    {
        _sessionService = sessionService;
        _httpClient = httpClient;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var token = await _sessionService.GetTokenAsync();

            if (string.IsNullOrEmpty(token))
            {
                return new AuthenticationState(_anonymous);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return new AuthenticationState(new ClaimsPrincipal(
                new ClaimsIdentity(ParseClaimsFromJwt(token), "jwtAuthType")));
        }
        catch
        {
            return new AuthenticationState(_anonymous);
        }
    }

    public void NotifyUserAuthentication(string token)
    {
        var authenticatedUser = new ClaimsPrincipal(
            new ClaimsIdentity(ParseClaimsFromJwt(token), "jwtAuthType"));

        var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
        NotifyAuthenticationStateChanged(authState);
    }

    public void NotifyUserLogout()
    {
        var authState = Task.FromResult(new AuthenticationState(_anonymous));
        _httpClient.DefaultRequestHeaders.Authorization = null;
        NotifyAuthenticationStateChanged(authState);
    }

    private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
    {
        var claims = new List<Claim>();
        var payload = jwt.Split('.')[1];

        var jsonBytes = ParseBase64WithoutPadding(payload);
        var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        if (keyValuePairs != null)
        {
        
            if (keyValuePairs.TryGetValue(ClaimTypes.NameIdentifier, out object? id) && id != null)
            {
                var idValue = id.ToString();
                if (idValue != null) 
                {
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, idValue));
                }
            }

            // Corrección para Name
            if (keyValuePairs.TryGetValue(ClaimTypes.Name, out object? name) && name != null)
            {
                var nameValue = name.ToString();
                if (nameValue != null) // <-- Comprobación de nulidad
                {
                    claims.Add(new Claim(ClaimTypes.Name, nameValue));
                }
            }

            // Corrección para Email
            if (keyValuePairs.TryGetValue(ClaimTypes.Email, out object? email) && email != null)
            {
                var emailValue = email.ToString();
                if (emailValue != null) // <-- Comprobación de nulidad
                {
                    claims.Add(new Claim(ClaimTypes.Email, emailValue));
                }
            }

            // Corrección para Roles
            if (keyValuePairs.TryGetValue(ClaimTypes.Role, out object? roles) && roles != null)
            {
                if (roles is JsonElement rolesElement && rolesElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (var role in rolesElement.EnumerateArray())
                    {
                        var roleValue = role.ToString();
                        if (roleValue != null) // <-- Comprobación de nulidad
                        {
                            claims.Add(new Claim(ClaimTypes.Role, roleValue));
                        }
                    }
                }
                else
                {
                    var roleValue = roles.ToString();
                    if (roleValue != null) // <-- Comprobación de nulidad
                    {
                        claims.Add(new Claim(ClaimTypes.Role, roleValue));
                    }
                }
            }
        }

        return claims;
    }

    private byte[] ParseBase64WithoutPadding(string base64)
    {
        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }
        return Convert.FromBase64String(base64);
    }
}