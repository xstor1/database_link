using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    
   public class DataTypesRepository : GenericRepository< DataTypes>
    {
        
        public override void Add(DataTypes entity)
        {
            base.Add(entity);
        }
        public override IList<DataTypes> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(DataTypes entity)
        {
            base.Delete(entity);
        }
        public override void Edit(DataTypes entity)
        {
            base.Edit(entity);

        }

        public override void Save()
        {
            base.Save();
        }
    }
}
