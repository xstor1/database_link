using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
   public class ErrorRepository : GenericRepository< Error>
    {
        public override void Add(Error entity)
        {
            base.Add(entity);
        }
        public override IList<Error> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(Error entity)
        {
            base.Delete(entity);
        }
        public override void Edit(Error entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
