using DepremTirProjesi.Models;

namespace DepremTirProjesi.Repositories
{
    public class KategoriRepository : GenericRepository<Kategori>
    {
        public KategoriRepository(Context _context) : base(_context)
        {
        }
    }
}
