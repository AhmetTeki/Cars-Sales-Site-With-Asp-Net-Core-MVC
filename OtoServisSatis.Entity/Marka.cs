using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entity
{
    public class Marka:IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}
