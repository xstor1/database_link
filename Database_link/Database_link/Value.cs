using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbValues")]
    public class Value
    {
        [Key]
        public int id { get; set; }
        public int idparam { get; set; }
        [Column("value")]
        public string Data_Value { get; set; }

        [ForeignKey("idparam")]
        public virtual ServiceParameters Obj_param { get; set; }
        public virtual List<Task> List_Obj_Tasks { get; set; }

    }
}
