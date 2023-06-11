namespace DepremTirProjesi.Models
{
    public class Malzeme
    {
        public int MalzemeId { get; set; }
        public string MalzemeAd { get; set; }
        public int MalzemeStok { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
