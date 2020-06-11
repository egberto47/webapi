using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using supermercado.API.Domain.Models;
using supermercado.API.Domain.Repositories;
using supermercado.API.Persistence.Contexts;
namespace supermercado.API.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        { }
        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
        }
        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }       
        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }
        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }     
    }
}