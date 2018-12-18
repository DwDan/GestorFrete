using BrightIdeasSoftware;
using GMap.NET;
using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace UI
{
    public class GetPointLatLng
    {
        public PointLatLng Coordenadas(IEndereco IEndereco)
        {
            string Logradouro = !string.IsNullOrEmpty(IEndereco.LOGRADOURO) ?
                string.Format("{0}", IEndereco.LOGRADOURO.TrimStart().TrimEnd().Replace(" ", "+")) : string.Empty;

            string Numero = !string.IsNullOrEmpty(IEndereco.NUMERO) ?
                string.Format(",+{0}+", IEndereco.NUMERO.Trim()) : string.Empty;

            string Bairro = !string.IsNullOrEmpty(IEndereco.BAIRRO) ?
                string.Format("-+{0}", IEndereco.BAIRRO.TrimStart().TrimEnd().Replace(" ", "+")) : string.Empty;

            string Municipio = !string.IsNullOrEmpty(IEndereco.MUNICIPIO) ?
                string.Format(",+{0}+", IEndereco.MUNICIPIO.Replace(" ", "+")) : string.Empty;

            string UF = !string.IsNullOrEmpty(IEndereco.UF) ?
                UF = string.Format("-+{0}", IEndereco.UF) : string.Empty;

            string ADDRESS = Logradouro + Numero + Bairro + Municipio + UF;

            string url = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?address={0}&key={1}", ADDRESS, "AIzaSyDSDWEGxqXsPOcVbeR8sSts1FJL0j7Fk8w");

            GeocodeResponse Response = (GeocodeResponse)CarregaXML_STR(XElement.Load(url).ToString(), typeof(GeocodeResponse));
            if (Response.Status == "OK")
            {
                return new PointLatLng()
                {
                    Lat = Response.Result.Geometry.Location.Lat,
                    Lng = Response.Result.Geometry.Location.Lng,
                };
            }
            else
            {
                return new PointLatLng();
            }
        }

        public static object CarregaXML_STR(string XML, Type Type)
        {
            XmlSerializer xs = new XmlSerializer(Type);
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(XML));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            return xs.Deserialize(memoryStream);
        }

        public static Byte[] StringToUTF8ByteArray(string pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }
    }

    public class OverrideOlv
    {
        public void TimedFilter(ObjectListView olv, string txt, int matchKind)
        {
            TextMatchFilter filter = null;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (matchKind)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }

            // Text highlighting requires at least a default renderer
            if (olv.DefaultRenderer == null)
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            olv.AdditionalFilter = filter;
            stopWatch.Stop();
        }
    }

    public static class DateTimeExtension
    {
        public static string ToVisual(this DateTime DateTime)
        {
            return DateTime.ToString("dd/MM/yyyy");
        }

        public static DateTime GetData(this string Data)
        {
            try
            {
                return Convert.ToDateTime(Data);
            }
            catch
            {
                return new DateTime();
            }
        }
    }

    public class TextBoxExtension
    {
        TextBox TextBox = new TextBox();
        string Valor;

        public TextBoxExtension(TextBox TextBox)
        {
            this.TextBox = TextBox;
            TextBox.Leave += new System.EventHandler(this.I5_VALOR_Leave);
            TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.I5_VALOR_KeyPress);
            TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.I5_VALOR_KeyUp);
        }

        private void I5_VALOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (TextBox.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void I5_VALOR_Leave(object sender, EventArgs e)
        {
            Valor = TextBox.Text.Replace("R$", "");
            TextBox.Text = string.Format("{0:C}", Convert.ToDouble(Valor));
        }


        private void I5_VALOR_KeyUp(object sender, KeyEventArgs e)
        {
            Valor = TextBox.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (Valor.Length == 0)
            {
                TextBox.Text = "0,00" + Valor;
            }
            if (Valor.Length == 1)
            {
                TextBox.Text = "0,0" + Valor;
            }
            if (Valor.Length == 2)
            {
                TextBox.Text = "0," + Valor;
            }
            else if (Valor.Length >= 3)
            {
                if (TextBox.Text.StartsWith("0,"))
                {
                    TextBox.Text = Valor.Insert(Valor.Length - 2, ",").Replace("0,", "");
                }
                else if (TextBox.Text.Contains("00,"))
                {
                    TextBox.Text = Valor.Insert(Valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    TextBox.Text = Valor.Insert(Valor.Length - 2, ",");
                }
            }

            Valor = TextBox.Text;
            TextBox.Text = string.Format("{0:C}", Convert.ToDouble(Valor));
            TextBox.Select(TextBox.Text.Length, 0);
        }
    }

    public static class Validacao
    {
        public static bool GetValidation(object Interface)
        {
            List<ValidationResult> Resultado = new List<ValidationResult>();
            ValidationContext ValidationContext = new ValidationContext(Interface, null, null);
            Validator.TryValidateObject(Interface, ValidationContext, Resultado, true);

            if (Resultado.Count > 0)
            {
                string MensagemErro = string.Empty;
                foreach (ValidationResult Erro in Resultado)
                    MensagemErro += string.Format("{0} * {1}", Environment.NewLine, Erro);

                MessageBox.Show(MensagemErro, "Informações inválidas.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
