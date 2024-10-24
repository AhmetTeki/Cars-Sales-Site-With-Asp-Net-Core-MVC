using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entity
{
    public class Slider : IEntity
    {
        public int Id { get ; set ; }
        public string? Baslık { get; set; }
        public string? Acıklama { get; set; }
        public string? Resim { get; set; }
        public string? Link { get; set; }
    }
}
