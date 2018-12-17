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
    public partial class Condutor_cad : Form
    {
        public DatabaseContext DatabaseContext;
        public ICondutor ICondutor;
        public bool Confirmou = false;
        public bool ReadOnly = false;

        public Condutor_cad(DatabaseContext DatabaseContext, ICondutor ICondutor, bool ReadOnly = false)
        {
            this.DatabaseContext = DatabaseContext;
            this.ICondutor = ICondutor;
            this.ReadOnly = ReadOnly;
            InitializeComponent();
            I4_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            PreencherCampos();
            gbDados.Enabled = !ReadOnly;
        }

        private void I4_UF_SelectedValueChanged(object sender, EventArgs e)
        {
            I4_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I4_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
        }

        public void PreencherCampos()
        {
            I4_HABILITACAO.Text = ICondutor.I4_HABILITACAO;
            I4_CATEGORIA.Text = ICondutor.I4_CATEGORIA;
            I4_NOME.Text = ICondutor.I4_NOME;
            I4_CPF.Text = ICondutor.I4_CPF;
            I4_RG.Text = ICondutor.I4_RG;
            I4_CEP.Text = ICondutor.I4_CEP;
            I4_LOGRADOURO.Text = ICondutor.I4_LOGRADOURO;
            I4_NUMERO.Text = ICondutor.I4_NUMERO;
            I4_COMPLEMENTO.Text = ICondutor.I4_COMPLEMENTO;
            I4_BAIRRO.Text = ICondutor.I4_BAIRRO;
            I4_UF.Text = ICondutor.I4_UF;
            I4_MUN.Text = ICondutor.I4_MUN;
        }

        public ICondutor SetarInterface(ICondutor ICondutor)
        {
            ICondutor.I4_HABILITACAO = I4_HABILITACAO.Text;
            ICondutor.I4_CATEGORIA = I4_CATEGORIA.Text;
            ICondutor.I4_NOME = I4_NOME.Text;
            ICondutor.I4_CPF = I4_CPF.Text;
            ICondutor.I4_RG = I4_RG.Text;
            ICondutor.I4_CEP = I4_CEP.Text;
            ICondutor.I4_LOGRADOURO = I4_LOGRADOURO.Text;
            ICondutor.I4_NUMERO = I4_NUMERO.Text;
            ICondutor.I4_COMPLEMENTO = I4_COMPLEMENTO.Text;
            ICondutor.I4_BAIRRO = I4_BAIRRO.Text;
            ICondutor.I4_UF = I4_UF.Text;
            ICondutor.I4_MUN = I4_MUN.Text;
            return ICondutor;
        }

        public bool Validar()
        {
            return Validacao.GetValidation(SetarInterface(new ICondutor()));
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
            SetarInterface(ICondutor);
            Close();
        }

        private void I4_CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                ZipCodeInfo zipCodeInfo = ZipLoad.Find(I4_CEP.Text);
                if (zipCodeInfo.Erro == false)
                {
                    I4_LOGRADOURO.Text = zipCodeInfo.Address.ToUpper();
                    I4_BAIRRO.Text = zipCodeInfo.District.ToUpper();
                    I4_UF.Text = zipCodeInfo.Uf.ToUpper();
                    I4_MUN.Text = zipCodeInfo.City.ToUpper();
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
    }
}
