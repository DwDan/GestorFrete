using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Table("SI1")]
    public class IMunicipio
    {
        [Key]
        public int I1_ID { get; set; }
        public string I1_UF { get; set; }
        public string I1_MUN { get; set; }
    }    
}
