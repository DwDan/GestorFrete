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
    [Table("SI5")]
    public class IFretamento
    {
        [Key]
        public int I5_ID { get; set; }

        [Required(ErrorMessage = "Campo [Cliente] obrigatório.")]
        public string I5_NOMECLIENTE { get; set; }
        public virtual ICliente I5_CLIENTE { get; set; }
        public string I5_ORG_CEP { get; set; }

        [Required(ErrorMessage = "Campo [Origem Logradouro] obrigatório.")]
        public string I5_ORG_LOGRADOURO { get; set; }
        public string I5_ORG_NUMERO { get; set; }
        public string I5_ORG_COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo [Origem Bairro] obrigatório.")]
        public string I5_ORG_BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo [Origem Município] obrigatório.")]
        public string I5_ORG_MUN { get; set; } = "BELO HORIZONTE";

        [Required(ErrorMessage = "Campo [Origem UF] obrigatório.")]
        public string I5_ORG_UF { get; set; } = "MG";
        public double I5_ORG_LATITUDE { get; set; }
        public double I5_ORG_LONGITUDE { get; set; }
        public PointLatLng I5_ORG_COORDENADAS
        {
            get { return new PointLatLng() { Lat = I5_ORG_LATITUDE, Lng = I5_ORG_LONGITUDE }; }
            set { I5_ORG_LATITUDE = value.Lat; I5_ORG_LONGITUDE = value.Lng; }
        }
        public string I5_DEST_CEP { get; set; }

        [Required(ErrorMessage = "Campo [Destino Logradouro] obrigatório.")]
        public string I5_DEST_LOGRADOURO { get; set; }
        public string I5_DEST_NUMERO { get; set; }
        public string I5_DEST_COMPLEMENTO { get; set; }

        [Required(ErrorMessage = "Campo [Destino Bairro] obrigatório.")]
        public string I5_DEST_BAIRRO { get; set; }

        [Required(ErrorMessage = "Campo [Destino Município] obrigatório.")]
        public string I5_DEST_MUN { get; set; } = "BELO HORIZONTE";

        [Required(ErrorMessage = "Campo [Destino UF] obrigatório.")]
        public string I5_DEST_UF { get; set; } = "MG";
        public double I5_DEST_LATITUDE { get; set; }
        public double I5_DEST_LONGITUDE { get; set; }
        public PointLatLng I5_DEST_COORDENADAS
        {
            get { return new PointLatLng() { Lat = I5_DEST_LATITUDE, Lng = I5_DEST_LONGITUDE }; }
            set { I5_DEST_LATITUDE = value.Lat; I5_DEST_LONGITUDE = value.Lng; }
        }

        [Required(ErrorMessage = "Campo [Data Lançamento] obrigatório.")]
        public DateTime I5_DATALANCAMENTO { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Campo [Hora Lançamento] obrigatório.")]
        public string I5_HORALANCAMENTO { get; set; } = "00:00";

        [Required(ErrorMessage = "Campo [Data Início] obrigatório.")]
        public DateTime I5_DATAINICIO { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Campo [Hora Início] obrigatório.")]
        public string I5_HORAINICIO { get; set; } = "00:00";

        [Required(ErrorMessage = "Campo [Data Final] obrigatório.")]
        public DateTime I5_DATAFINAL { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Campo [Hora Final] obrigatório.")]
        public string I5_HORAFINAL { get; set; } = "00:00";

        [Required(ErrorMessage = "Campo [Placa] obrigatório.")]
        public string I5_PLACA { get; set; }

        public virtual IVeiculo I5_VEICULO { get; set; }

        [Required(ErrorMessage = "Campo [Condutor] obrigatório.")]
        public string I5_NOMECONDUTOR { get; set; }

        public virtual ICondutor I5_CONDUTOR { get; set; }
        public string I5_PASSAGEIROS { get; set; }

        [Required(ErrorMessage = "Campo [Valor] obrigatório.")]
        public decimal I5_VALOR { get; set; }
        public TipoStatus I5_STATUS { get; set; } = TipoStatus.Aberto;

        public IFretamento Clone()
        {
            return (IFretamento)this.MemberwiseClone();
        }
    }

    public enum TipoStatus
    {
        Aberto = 0,
        Fechado = 1,
    }
}

