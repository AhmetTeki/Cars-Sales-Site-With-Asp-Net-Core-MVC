using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entity
{
    public class Arac : IEntity
    {
        public int Id { get ; set ; }
        [Display(Name ="Marka")]
        public int MarkaId { get; set; }
        public string Renk { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Fiyati { get; set; }
        [Display(Name = "Model")]
        public string Modeli { get; set; }
        [Display(Name = "Kasa Tipi")]
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }
        [Display(Name = "Stok Durumu")]
        public bool SatistaMi { get; set; }
        public string Notlar { get; set; }
        public string? Resim1 { get; set; }
        public string? Resim2 { get; set; }
        public string? Resim3 { get; set; }
        public virtual Marka Marka { get; set; }
    }
}
