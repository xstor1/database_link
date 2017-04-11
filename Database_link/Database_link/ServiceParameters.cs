using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbServiceParameters")]
   public class ServiceParameters
    {
        
        [Key]
        public int id { get; set; }
        public int iddata_type { get; set; }
        public string name { get; set; }
        [ForeignKey("iddata_type")]
        public virtual DataTypes Obj_Data_Type { get; set; }
        public virtual List<ServiceTypes>  List_Obj_ServiceType { get; set; }

    }
}
