using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
   public class ValueRepository : GenericRepository<Value>

    {
        public override void Add(Value entity)
        {
            base.Add(entity);
        }
        public override IList<Value> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(Value entity)
        {
            base.Delete(entity);
        }
        public override void Edit(Value entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
