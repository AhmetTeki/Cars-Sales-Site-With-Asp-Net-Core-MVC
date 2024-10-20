using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtoServisSatis.Entity
{
    public class Servis: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Servise Geliş Tarihi")]
        public DateTime ServiseGelisTarihi { get; set; }
        [Display(Name = "Aracın Sorunu")]
        public string AracSorunu { get; set; }
        [Display(Name = "Servis Ücreti")]
        public decimal ServisUcreti { get; set; }
        [Display(Name = "Servisten Çıkış Tarihi")]
        public DateTime ServistenCikisTarihi { get; set; }
        [Display(Name = "Yapılan İşlemler")]
        public string YapilanIslemler { get; set; }
        [Display(Name = "Garanti Kapsamında mı?")]
        public bool GarantiKapsamindaMi { get; set; }
        [Display(Name = "Plak")]
        public string AracPlaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        [Display(Name = "Kasa Tipi")]
        public string KasaTipi { get; set; }
        [Display(Name = "Şase No")]
        public string SaseNo { get; set; }
        public string Notlar { get; set; }
    }
}
