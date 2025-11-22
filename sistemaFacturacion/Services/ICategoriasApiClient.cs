using System.Collections.Generic;
using System.Threading.Tasks;
using sistemaFacturacion.Models;

namespace sistemaFacturacion.Services
{
    public interface ICategoriasApiClient
    {
             Task<List<CategoriaProductoDto>> ListarAsync();
    }
}
