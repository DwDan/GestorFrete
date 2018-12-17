using Acess;
using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Localizar : Form
    {
        public List<DadoColuna> ListaDados = new List<DadoColuna>();
        public TipoBusca TIPOBUSCA = TipoBusca.Vazio;
        public DatabaseContext DatabaseContext;
        public bool Confirmou = false;
        public Object Object = null;

        public Localizar(DatabaseContext DatabaseContext, TipoBusca TIPOBUSCA)
        {
            this.TIPOBUSCA = TIPOBUSCA;
            this.DatabaseContext = DatabaseContext;
            InitializeComponent();
        }

        private void Localizar_Load(object sender, EventArgs e)
        {
            CarregarOlv();
            foreach (DadoColuna DadoColuna in ListaDados)
            {
                olvDados.Columns.AddRange(new ColumnHeader[] { new OLVColumn
                {
                    AspectName = DadoColuna.AspectName,
                    Text = DadoColuna.Text,
                    Width = DadoColuna.Width,
                    Name = DadoColuna.Name,
                    AspectToStringFormat = DadoColuna.AspectToString
                }});
            }
            if(TIPOBUSCA == TipoBusca.Cliente) olvDados.SetObjects(DatabaseContext.Clientes);
            else if (TIPOBUSCA == TipoBusca.Condutor) olvDados.SetObjects(DatabaseContext.Condutores);
            else if (TIPOBUSCA == TipoBusca.Passageiro) olvDados.SetObjects(DatabaseContext.Passageiros);
            else if (TIPOBUSCA == TipoBusca.Veiculo) olvDados.SetObjects(DatabaseContext.Veiculos);


            txtBuscaTexto.Select();
        }

        public void CarregarOlv()
        {
            if (TIPOBUSCA == TipoBusca.Cliente)
            {
                ListaDados = new List<DadoColuna> {
                        new DadoColuna {AspectName = "I2_NOME", Text = "Nome", Width = 250 },
                        new DadoColuna {AspectName = "I2_CPF_CNPJ", Text = "CPF / CNPJ", Width = 100 }};
            }
            else if (TIPOBUSCA == TipoBusca.Condutor)
            {
                ListaDados = new List<DadoColuna> {
                        new DadoColuna {AspectName = "I4_NOME", Text = "Nome", Width = 250 },
                        new DadoColuna {AspectName = "I4_CPF", Text = "CPF", Width = 100 }};
            }
            else if (TIPOBUSCA == TipoBusca.Passageiro)
            {
                ListaDados = new List<DadoColuna> {
                        new DadoColuna {AspectName = "I0_NOME", Text = "Nome", Width = 250 },
                        new DadoColuna {AspectName = "I0_CPF", Text = "CPF", Width = 100 }};
            }
            else if (TIPOBUSCA == TipoBusca.Veiculo)
            {
                ListaDados = new List<DadoColuna> {
                        new DadoColuna {AspectName = "I3_PLACA", Text = "Placa", Width = 100 },
                        new DadoColuna {AspectName = "I3_MARCA", Text = "Marca", Width = 200 },
                        new DadoColuna {AspectName = "I3_MODELO", Text = "Modelo", Width = 200 }};
            }
        }

        public class DadoColuna
        {
            public string AspectName { get; set; } = string.Empty;
            public string AspectToString { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
            public int Width { get; set; } = 0;
            public string Name { get; set; } = string.Empty;
        }

        public enum TipoBusca
        {
            Vazio = 0,
            Cliente = 1,
            Veiculo = 2,
            Condutor = 3,
            Passageiro = 4,
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Object = olvDados.SelectedObject;
            if (Object != null)
            {
                Confirmou = true;
                Close();
            }
        }

        private void olvDados_DoubleClick(object sender, EventArgs e)
        {
            Object = olvDados.SelectedObject;
            if (Object != null)
            {
                Confirmou = true;
                Close();
            }
        }

        private void olvDados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Object = olvDados.SelectedObject;
                if (Object != null)
                {
                    Confirmou = true;
                    Close();
                }
            }
        }

        private void txtBuscaTexto_TextChanged(object sender, EventArgs e)
        {
            new OverrideOlv().TimedFilter(olvDados, txtBuscaTexto.Text, 0);
        }
    }
}
