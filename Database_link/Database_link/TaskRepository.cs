using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{


    public class TaskRepository : GenericRepository< Task>

    {
        public override void Add(Task entity)
        {
            base.Add(entity);
        }
        public override IList<Task> GetAll()
        {
            return base.GetAll();
        }
        public override void Delete(Task entity)
        {
            base.Delete(entity);
        }
        public override void Edit(Task entity)
        {
            base.Edit(entity);
        
        }
    
        public override void Save()
        {
            base.Save();
        }
    }
}