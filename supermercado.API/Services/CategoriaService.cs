using System.Collections.Generic;
using System.Threading.Tasks;
using supermercado.API.Domain.Models;
using supermercado.API.Domain.Repositories;
using supermercado.API.Domain.Services;

namespace supermercado.API.Services
{
    public class CategoriaService : ICategoriasService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public Task<IEnumerable<Categoria>> ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}