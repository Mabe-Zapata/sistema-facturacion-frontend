using System.Net.Http;
using System.Net.Http.Json;
using sistemaFacturacion.Models;

namespace sistemaFacturacion.Services
{
    public class CategoriasApiClient : ICategoriasApiClient
    {
        private readonly HttpClient _http;

        public CategoriasApiClient(HttpClient http)
        {
            _http = http;
        } 
        public async Task<List<CategoriaProductoDto>> ListarAsync()
        {
            var response = await _http.GetAsync("api/categorias");
            response.EnsureSuccessStatusCode();

            var categorias = await response.Content.ReadFromJsonAsync<List<CategoriaProductoDto>>();

            return categorias ?? new List<CategoriaProductoDto>();
        }
    }
}
