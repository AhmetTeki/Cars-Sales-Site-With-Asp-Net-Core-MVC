using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entity
{
    public class Kullanici : IEntity
    {
        public int Id { get ; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [ScaffoldColumn(false)]
        public DateTime EklenmeTarihi { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
