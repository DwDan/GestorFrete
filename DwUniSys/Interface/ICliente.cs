using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Table("SI2")]
    public class ICliente
    {
        [Key]
        public int I2_ID { get; set; }

        [Required(ErrorMessage = "Campo [Nome / Razão Social] obrigatório.")]
        public string I2_NOME { get; set; }
        public string I2_PESSOA { get; set; } = "F";

        [Required(ErrorMessage = "Campo [CPF / CNPJ] obrigatório.")]
        public string I2_CPF_CNPJ { get; set; }
        public string I2_RG { get; set; }
        public string I2_INSCESTADUAL { get; set; }
        public string I2_INSCMUNICIPAL { get; set; }
        public string I2_CEP { get; set; }

        [Required(ErrorMessage = "Campo [Logradouro] obrigatório.")]
        public string I2_LOGRADOURO { get; set; }
        public string I2_NUMERO { get; set; }
        public string I2_COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo [Bairro] obrigatório.")]
        public string I2_BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo [Município] obrigatório.")]
        public string I2_MUN { get; set; } = "BELO HORIZONTE";

        [Required(ErrorMessage = "Campo [UF] obrigatório.")]
        public string I2_UF { get; set; } = "MG";
    }
}
