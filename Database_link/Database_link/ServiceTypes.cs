using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbServiceTypes")]
   public class ServiceTypes
    {
        [Key]
        public int id { get; set; }
        public string service_type { get; set; }
        public virtual List<ServiceParameters> List_Obj_ServiceParameters { get; set; }
    }
}
