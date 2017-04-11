using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    public class ServiceParametersRepository : GenericRepository< ServiceParameters>
    {
        public override void Add(ServiceParameters entity)
        {
            base.Add(entity);
        }
        public override IList<ServiceParameters> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(ServiceParameters entity)
        {
            base.Delete(entity);
        }
        public override void Edit(ServiceParameters entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
