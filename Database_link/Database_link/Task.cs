using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbtask")]
   public class Task
    {
        [Key]
        public int id { get; set; }

        public int idservice { get; set; }

        [ForeignKey("idservice")]
        public virtual ServiceTypes obj_ServiceType { get; set; }

        public virtual List<Value> List_Obj_Values { get; set; }


        public override string ToString()
        {
            string output = $"TaskID: {id}  IdService: {idservice}  Service: {obj_ServiceType.service_type}";
            foreach (Value item in List_Obj_Values)
            {
                output = output + " " + item.Obj_param.name + ": " + item.Data_Value;
            }
            return output;
        }
    }
}
