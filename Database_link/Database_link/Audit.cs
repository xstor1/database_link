using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbaudit")]
   public  class Audit
    {
        [Key]
        public int id { get; set; }
        public int idtask { get; set; }
        public DateTime record_date { get; set; }
        [ForeignKey("idtask")]
       public virtual Task Obj_Task { get; set; }
        public virtual List<Error> List_Obj_Erorrs { get; set; }
    }
}
