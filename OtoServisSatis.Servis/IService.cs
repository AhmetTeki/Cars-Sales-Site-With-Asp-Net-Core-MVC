using OtoServisSatis.Data;
using OtoServisSatis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Servis
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
