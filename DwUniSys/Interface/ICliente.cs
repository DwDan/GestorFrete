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

        public string I2_ENDERECO
        {
            get
            {
                string Value = string.Empty;
                if (!string.IsNullOrEmpty(I2_LOGRADOURO))
                    Value += string.Format("{0}", I2_LOGRADOURO);
                if (!string.IsNullOrEmpty(I2_LOGRADOURO) && !string.IsNullOrEmpty(I2_NUMERO))
                    Value += string.Format(" {0}", I2_NUMERO);
                if (!string.IsNullOrEmpty(Value) && !string.IsNullOrEmpty(I2_BAIRRO))
                    Value += string.Format(", {0}", I2_BAIRRO);
                else if (string.IsNullOrEmpty(Value) && !string.IsNullOrEmpty(I2_BAIRRO))
                    Value += string.Format("{0}", I2_BAIRRO);
                if (!string.IsNullOrEmpty(Value) && !string.IsNullOrEmpty(I2_MUN))
                    Value += string.Format(" - {0}", I2_MUN);
                else if (!string.IsNullOrEmpty(I2_MUN))
                    Value += string.Format("{0}", I2_MUN);
                if (!string.IsNullOrEmpty(Value) && !string.IsNullOrEmpty(I2_UF))
                    Value += string.Format(" / {0}", I2_UF);
                else if (!string.IsNullOrEmpty(I2_UF))
                    Value += string.Format("{0}", I2_UF);
                return Value;
            }
        }
    }
}
