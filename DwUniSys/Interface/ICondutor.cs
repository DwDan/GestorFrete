using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Table("SI4")]
    public class ICondutor
    {
        [Key]
        public int I4_ID { get; set; }

        [Required(ErrorMessage = "Campo [Nome] obrigatório.")]
        public string I4_NOME { get; set; }

        [Required(ErrorMessage = "Campo [CPF] obrigatório.")]
        public string I4_CPF { get; set; }
        public string I4_RG { get; set; }
        public string I4_HABILITACAO { get; set; }
        public string I4_CATEGORIA { get; set; } = "B";
        public string I4_CEP { get; set; }

        [Required(ErrorMessage = "Campo [Logradouro] obrigatório.")]
        public string I4_LOGRADOURO { get; set; }
        public string I4_NUMERO { get; set; }
        public string I4_COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo [Bairro] obrigatório.")]
        public string I4_BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo [Município] obrigatório.")]
        public string I4_MUN { get; set; } = "BELO HORIZONTE";

        [Required(ErrorMessage = "Campo [UF] obrigatório.")]
        public string I4_UF { get; set; } = "MG";
    }
}
