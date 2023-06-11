using DepremTirProjesi.Models;

namespace DepremTirProjesi.Repositories
{
    public class MalzemeRepository : GenericRepository<Malzeme>
    {
        public MalzemeRepository(Context _context) : base(_context)
        {
        }
    }
}
