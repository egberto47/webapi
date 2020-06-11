using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using supermercado.API.Domain.Models;
using supermercado.API.Domain.Services;

namespace supermercado.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriasController : Controller
    {
        private readonly ICategoriasService _categoriaService;
        public CategoriasController(ICategoriasService categoriasService)
        {
            _categoriaService = categoriasService;
        }
        [HttpGet]
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var categoria = await _categoriaService.ListAsync();
            return categoria;
        }
    }
}