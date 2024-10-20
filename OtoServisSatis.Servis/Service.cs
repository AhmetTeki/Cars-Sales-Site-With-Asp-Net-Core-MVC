using OtoServisSatis.Data;
using OtoServisSatis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Servis
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DataBaseContext context) : base(context)
        {
        }

        public Task FindAsync(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }
    }
}
