using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tberror")]
    public class Error
    {
        [Key]
        public int id { get; set; }
        public int idaudit { get; set; }
        public string error { get; set; }

        [ForeignKey("idaudit")]
        public virtual Audit Obj_Audit { get; set; }
    }
}
