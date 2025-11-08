using sistemaFacturacion.Models;

namespace sistemaFacturacion.Services
{
    public interface IProductosApiClient
    {
        Task<List<ProductoDto>?> GetAllAsync();
    }
}
