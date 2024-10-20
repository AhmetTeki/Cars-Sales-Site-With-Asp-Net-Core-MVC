using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entity
{
    public class Musteri:IEntity
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Notlar { get; set; }
        public virtual Arac Arac { get; set; }
    }
}
