using System.Collections.Generic;
using System.Threading.Tasks;
using supermercado.API.Domain.Models;

namespace supermercado.API.Domain.Services
{
    public interface ICategoriasService 
    {
        Task<IEnumerable<Categoria>> ListAsync();
    }
}