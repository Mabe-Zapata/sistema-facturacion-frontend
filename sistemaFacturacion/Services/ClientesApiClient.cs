using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace sistemaFacturacion;
public class ClientesApiClient : IClientesApiClient
{
    private readonly HttpClient _http;
    private const string Endpoint = "api/Clientes";
    private static readonly JsonSerializerOptions _json = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    public ClientesApiClient(HttpClient http) => _http = http;

    public async Task<List<ClienteDto>> GetAllAsync(CancellationToken ct = default)
        => await _http.GetFromJsonAsync<List<ClienteDto>>(Endpoint, _json, ct) ?? new();

    public async Task<ClienteDto?> GetByIdAsync(int id, CancellationToken ct = default)
        => await _http.GetFromJsonAsync<ClienteDto>($"{Endpoint}/{id}", _json, ct);

    public async Task<ClienteDto> CreateAsync(ClienteCreateRequest request, CancellationToken ct = default)
    {
        var resp = await _http.PostAsJsonAsync(Endpoint, request, _json, ct);
        await Ensure(resp);
        var body = await resp.Content.ReadFromJsonAsync<ClienteDto>(_json, ct);
        return body!;
    }

    public async Task UpdateContactoAsync(int id, ClienteContactoUpdate request, CancellationToken ct = default)
    {
        var resp = await _http.PutAsJsonAsync($"{Endpoint}/{id}", request, _json, ct);
        if (resp.StatusCode == HttpStatusCode.NoContent) return;
        await Ensure(resp);
    }

    private static async Task Ensure(HttpResponseMessage r)
    {
        if (r.IsSuccessStatusCode) return;
        var text = r.Content is null ? null : await r.Content.ReadAsStringAsync();
        throw new HttpRequestException($"Error {(int)r.StatusCode} {r.ReasonPhrase}. {text}");
    }
}
