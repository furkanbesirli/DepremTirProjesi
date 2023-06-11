using Microsoft.EntityFrameworkCore;

namespace DepremTirProjesi.Models
{
    public class Context:DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options) 
        { 
        }

        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<Gorevli> Gorevlis{ get; set; }
        public DbSet<Ilce> Ilces{ get; set; }
        public DbSet<Kategori> Kategoris{ get; set; }
        public DbSet<Malzeme> Malzemes{ get; set; }
        public DbSet<TirİcerikBilgisi> TirİcerikBilgisis { get; set; }


    }
}
