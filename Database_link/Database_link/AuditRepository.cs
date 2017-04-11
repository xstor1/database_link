using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
   public class AuditRepository : GenericRepository< Audit>
    {
        public override void Add(Audit entity)
        {
            base.Add(entity);
        }
        public override IList<Audit> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(Audit entity)
        {
            base.Delete(entity);
        }
        public override void Edit(Audit entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
