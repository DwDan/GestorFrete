using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    [Table("SI3")]
    public class IVeiculo
    {
        [Key]
        public int I3_ID { get; set; }

        [Required(ErrorMessage = "Campo [Placa] obrigatório.")]
        public string I3_PLACA { get; set; }
        public string I3_CHASSI { get; set; }
        public string I3_RENAVAM { get; set; }

        [Required(ErrorMessage = "Campo [Marca] obrigatório.")]
        public string I3_MARCA { get; set; }

        [Required(ErrorMessage = "Campo [Modelo] obrigatório.")]
        public string I3_MODELO { get; set; }
        public string I3_COR { get; set; }
        public string I3_TIPO { get; set; }

        [Required(ErrorMessage = "Campo [UF] obrigatório.")]
        public string I3_UF { get; set; } = "MG";

        [Required(ErrorMessage = "Campo [Município] obrigatório.")]
        public string I3_MUN { get; set; } = "BELO HORIZONTE";
        public string I3_CATEGORIA { get; set; } = "Particular";
    }
}
