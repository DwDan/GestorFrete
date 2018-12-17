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
    public partial class Cliente_cad : Form
    {
        public DatabaseContext DatabaseContext;
        public ICliente ICliente;
        public bool Confirmou = false;
        public bool ReadOnly = false;

        public Cliente_cad(DatabaseContext DatabaseContext, ICliente ICliente, bool ReadOnly = false)
        {
            this.DatabaseContext = DatabaseContext;
            this.ICliente = ICliente;
            this.ReadOnly = ReadOnly;
            InitializeComponent();
            I2_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            PreencherCampos();
            gbDados.Enabled = gbFisica.Enabled = gbJuridica.Enabled = gbPessoa.Enabled = !ReadOnly;
        }

        private void I2_UF_SelectedValueChanged(object sender, EventArgs e)
        {
            I2_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I2_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
        }

        public void PreencherCampos()
        {
            rbFisica.Checked = ICliente.I2_PESSOA == "F";
            rbJuridica.Checked = ICliente.I2_PESSOA == "J";
            I2_INSCMUNICIPAL.Text = ICliente.I2_INSCMUNICIPAL;
            I2_INSCESTADUAL.Text = ICliente.I2_INSCESTADUAL;
            if (ICliente.I2_PESSOA == "J") I2_CNPJ.Text = ICliente.I2_CPF_CNPJ;
            I2_NOME.Text = ICliente.I2_PESSOA == "F" ? ICliente.I2_NOME : string.Empty;
            I2_RAZAOSOCIAL.Text = ICliente.I2_PESSOA == "J" ? ICliente.I2_NOME : string.Empty;
            if (ICliente.I2_PESSOA == "F") I2_CPF.Text = ICliente.I2_CPF_CNPJ;
            I2_RG.Text = ICliente.I2_RG;
            I2_CEP.Text = ICliente.I2_CEP;
            I2_LOGRADOURO.Text = ICliente.I2_LOGRADOURO;
            I2_NUMERO.Text = ICliente.I2_NUMERO;
            I2_COMPLEMENTO.Text = ICliente.I2_COMPLEMENTO;
            I2_BAIRRO.Text = ICliente.I2_BAIRRO;
            I2_UF.Text = ICliente.I2_UF;
            I2_MUN.Text = ICliente.I2_MUN;
        }

        public ICliente SetarInterface(ICliente ICliente)
        {
            ICliente.I2_PESSOA = rbFisica.Checked ? "F" : "J";
            ICliente.I2_INSCMUNICIPAL = I2_INSCMUNICIPAL.Text;
            ICliente.I2_INSCESTADUAL = I2_INSCESTADUAL.Text;
            ICliente.I2_CPF_CNPJ = rbJuridica.Checked ? I2_CNPJ.Text : I2_CPF.Text;
            ICliente.I2_NOME = I2_RAZAOSOCIAL.Text + I2_NOME.Text;
            ICliente.I2_RG = I2_RG.Text;
            ICliente.I2_CEP = I2_CEP.Text;
            ICliente.I2_LOGRADOURO = I2_LOGRADOURO.Text;
            ICliente.I2_NUMERO = I2_NUMERO.Text;
            ICliente.I2_COMPLEMENTO = I2_COMPLEMENTO.Text;
            ICliente.I2_BAIRRO = I2_BAIRRO.Text;
            ICliente.I2_UF = I2_UF.Text;
            ICliente.I2_MUN = I2_MUN.Text;
            return ICliente;
        }

        public bool Validar()
        {
            return Validacao.GetValidation(SetarInterface(new ICliente()));
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
            SetarInterface(ICliente);
            Close();
        }

        private void I2_CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                ZipCodeInfo zipCodeInfo = ZipLoad.Find(I2_CEP.Text);
                if (zipCodeInfo.Erro == false)
                {
                    I2_LOGRADOURO.Text = zipCodeInfo.Address.ToUpper();
                    I2_BAIRRO.Text = zipCodeInfo.District.ToUpper();
                    I2_UF.Text = zipCodeInfo.Uf.ToUpper();
                    I2_MUN.Text = zipCodeInfo.City.ToUpper();
                    return;
                }
                else
                {
                    MessageBox.Show("CEP Não Localizado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Falha na busca do Cep!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioButton = (RadioButton)sender;
            if (!RadioButton.Checked) return;

            gbJuridica.Visible = RadioButton.Name == "rbJuridica";
            gbFisica.Visible = RadioButton.Name == "rbFisica";

            if (RadioButton.Name == "rbFisica")
            {
                I2_RAZAOSOCIAL.Text = string.Empty;
                I2_INSCMUNICIPAL.Text = string.Empty;
                I2_INSCESTADUAL.Text = string.Empty;
                I2_CNPJ.Text = string.Empty;
            }
            else
            {
                I2_NOME.Text = string.Empty;
                I2_CPF.Text = string.Empty;
                I2_RG.Text = string.Empty;
            }
        }
    }
}
