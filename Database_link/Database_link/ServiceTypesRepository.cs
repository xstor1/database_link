using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
  public  class ServiceTypesRepository : GenericRepository<ServiceTypes>
    {
        public override void Add(ServiceTypes entity)
        {
            base.Add(entity);
        }
        public override IList<ServiceTypes> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(ServiceTypes entity)
        {
            base.Delete(entity);
        }
        public override void Edit(ServiceTypes entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
