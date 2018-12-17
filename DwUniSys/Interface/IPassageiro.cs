using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Table("SI0")]
    public class IPassageiro
    {
        [Key]
        public int I0_ID { get; set; }

        [Required(ErrorMessage = "Campo [Nome] obrigatório.")]
        public string I0_NOME { get; set; }

        [Required(ErrorMessage = "Campo [CPF] obrigatório.")]
        public string I0_CPF { get; set; }
        public string I0_RG { get; set; }
        public string I0_CEP { get; set; }

        [Required(ErrorMessage = "Campo [Logradouro] obrigatório.")]
        public string I0_LOGRADOURO { get; set; }
        public string I0_NUMERO { get; set; }
        public string I0_COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo [Bairro] obrigatório.")]
        public string I0_BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo [Município] obrigatório.")]
        public string I0_MUN { get; set; } = "BELO HORIZONTE";

        [Required(ErrorMessage = "Campo [UF] obrigatório.")]
        public string I0_UF { get; set; } = "BH";
        public double I0_LATITUDE { get; set; }
        public double I0_LONGITUDE { get; set; }

        public PointLatLng I0_COORDENADAS
        {
            get { return new PointLatLng() { Lat = I0_LATITUDE, Lng = I0_LONGITUDE }; }
            set { I0_LATITUDE = value.Lat; I0_LONGITUDE = value.Lng; }
        }

        public IPassageiro Clone()
        {
            return (IPassageiro)this.MemberwiseClone();
        }
    }
}
