using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class IEndereco
    {
        public string LOGRADOURO { get; set; } = string.Empty;
        public string NUMERO { get; set; } = string.Empty;
        public string COMPLEMENTO { get; set; } = string.Empty;
        public string BAIRRO { get; set; } = string.Empty;
        public string MUNICIPIO { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
    }
}
