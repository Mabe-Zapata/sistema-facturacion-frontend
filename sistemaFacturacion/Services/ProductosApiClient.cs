using System.Net.Http.Json;
using sistemaFacturacion.Models;

namespace sistemaFacturacion.Services
{
    public class ProductosApiClient : IProductosApiClient
    {
        private readonly HttpClient _http;
        public ProductosApiClient(HttpClient http) => _http = http;

        public async Task<List<ProductoDto>?> GetAllAsync()
        {
            // Ajusta la ruta a tu backend real
            return await _http.GetFromJsonAsync<List<ProductoDto>>("api/productos");
        }
    }
}
