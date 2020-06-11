using supermercado.API.Persistence.Contexts;

namespace supermercado.API.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;

        }
    }
}