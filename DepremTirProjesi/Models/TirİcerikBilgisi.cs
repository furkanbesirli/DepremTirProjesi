using System.ComponentModel.DataAnnotations;

namespace DepremTirProjesi.Models
{
    public class TirİcerikBilgisi
    {
        [Key]
        public int TirId { get; set; }
        public string TirPlaka { get; set; }
        public int SehirId { get; set; }
        public virtual Sehir Sehir { get; set; }
        public int IlceId { get; set; }
        public virtual Ilce Ilce { get; set; }
        public int MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }

    }
}
