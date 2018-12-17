using Acess;
using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canducci.Zip;
namespace UI
{
    public partial class Veiculo_cad : Form
    {
        public DatabaseContext DatabaseContext;
        public IVeiculo IVeiculo;
        public bool Confirmou = false;
        public bool ReadOnly = false;

        public Veiculo_cad(DatabaseContext DatabaseContext, IVeiculo IVeiculo, bool ReadOnly = false)
        {
            this.DatabaseContext = DatabaseContext;
            this.IVeiculo = IVeiculo;
            this.ReadOnly = ReadOnly;
            InitializeComponent();
            I3_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            PreencherCampos();
            gbDados.Enabled = !ReadOnly;
        }

        private void I2_UF_SelectedValueChanged(object sender, EventArgs e)
        {
            I3_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I3_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
        }

        public void PreencherCampos()
        {
            I3_PLACA.Text = IVeiculo.I3_PLACA;
            I3_CHASSI.Text = IVeiculo.I3_CHASSI;
            I3_RENAVAM.Text = IVeiculo.I3_RENAVAM;
            I3_MARCA.Text = IVeiculo.I3_MARCA;
            I3_MODELO.Text = IVeiculo.I3_MODELO;
            I3_COR.Text = IVeiculo.I3_COR;
            I3_TIPO.Text = IVeiculo.I3_TIPO;
            I3_UF.Text = IVeiculo.I3_UF;
            I3_MUN.Text = IVeiculo.I3_MUN;
            I3_CATEGORIA.Text = IVeiculo.I3_CATEGORIA;
            I3_UF.Text = IVeiculo.I3_UF;
            I3_MUN.Text = IVeiculo.I3_MUN;
        }

        public IVeiculo SetarInterface(IVeiculo IVeiculo)
        {
            IVeiculo.I3_PLACA = I3_PLACA.Text;
            IVeiculo.I3_CHASSI = I3_CHASSI.Text;
            IVeiculo.I3_RENAVAM = I3_RENAVAM.Text;
            IVeiculo.I3_MARCA = I3_MARCA.Text;
            IVeiculo.I3_MODELO = I3_MODELO.Text;
            IVeiculo.I3_COR = I3_COR.Text;
            IVeiculo.I3_TIPO = I3_TIPO.Text;
            IVeiculo.I3_UF = I3_UF.Text;
            IVeiculo.I3_MUN = I3_MUN.Text;
            IVeiculo.I3_CATEGORIA = I3_CATEGORIA.Text;
            IVeiculo.I3_UF = I3_UF.Text;
            IVeiculo.I3_MUN = I3_MUN.Text;
            return IVeiculo;
        }

        public bool Validar()
        {
            return Validacao.GetValidation(SetarInterface(new IVeiculo()));
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (ReadOnly) Close();
            else if (!Validar() || MessageBox.Show("Está certo que deseja confirmar operação?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Confirmou = true;
            SetarInterface(IVeiculo);
            Close();
        }
    }
}
