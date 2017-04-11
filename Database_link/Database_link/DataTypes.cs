using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    [Table("tbdatatypes")]
   public class DataTypes
    {
        [Key]
        public int id { get; set; }
        public string data_type { get; set; }


    }
}
