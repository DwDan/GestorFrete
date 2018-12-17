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
    public partial class Passageiro_cad : Form
    {
        public DatabaseContext DatabaseContext;
        public IPassageiro IPassageiro;
        public bool Confirmou = false;
        public bool ReadOnly = false;

        public Passageiro_cad(DatabaseContext DatabaseContext, IPassageiro IPassageiro, bool ReadOnly = false)
        {
            this.DatabaseContext = DatabaseContext;
            this.IPassageiro = IPassageiro;
            this.ReadOnly = ReadOnly;
            InitializeComponent();
            I0_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            PreencherCampos();
            gbDados.Enabled = !ReadOnly;
        }

        private void I0_UF_SelectedValueChanged(object sender, EventArgs e)
        {
            I0_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I0_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
        }

        public void PreencherCampos()
        {
            I0_NOME.Text = IPassageiro.I0_NOME;
            I0_CPF.Text = IPassageiro.I0_CPF;
            I0_RG.Text = IPassageiro.I0_RG;
            I0_CEP.Text = IPassageiro.I0_CEP;
            I0_LOGRADOURO.Text = IPassageiro.I0_LOGRADOURO;
            I0_NUMERO.Text = IPassageiro.I0_NUMERO;
            I0_COMPLEMENTO.Text = IPassageiro.I0_COMPLEMENTO;
            I0_BAIRRO.Text = IPassageiro.I0_BAIRRO;
            I0_UF.Text = IPassageiro.I0_UF;
            I0_MUN.Text = IPassageiro.I0_MUN;
        }

        public IPassageiro SetarInterface(IPassageiro IPassageiro)
        {
            IPassageiro.I0_NOME = I0_NOME.Text;
            IPassageiro.I0_CPF = I0_CPF.Text;
            IPassageiro.I0_RG = I0_RG.Text;
            IPassageiro.I0_CEP = I0_CEP.Text;
            IPassageiro.I0_LOGRADOURO = I0_LOGRADOURO.Text;
            IPassageiro.I0_NUMERO = I0_NUMERO.Text;
            IPassageiro.I0_COMPLEMENTO = I0_COMPLEMENTO.Text;
            IPassageiro.I0_BAIRRO = I0_BAIRRO.Text;
            IPassageiro.I0_UF = I0_UF.Text;
            IPassageiro.I0_MUN = I0_MUN.Text;
            return IPassageiro;
        }

        public bool Validar()
        {
            return Validacao.GetValidation(SetarInterface(new IPassageiro()));
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
            SetarInterface(IPassageiro);

            GetPointLatLng GetPointLatLng = new GetPointLatLng();
            IPassageiro.I0_COORDENADAS = GetPointLatLng.Coordenadas(new IEndereco()
            {
                LOGRADOURO = IPassageiro.I0_LOGRADOURO,
                NUMERO = IPassageiro.I0_NUMERO,
                BAIRRO = IPassageiro.I0_BAIRRO,
                MUNICIPIO = IPassageiro.I0_MUN,
                UF = IPassageiro.I0_UF
            });

            Close();
        }

        private void I0_CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                ZipCodeInfo zipCodeInfo = ZipLoad.Find(I0_CEP.Text);
                if (zipCodeInfo.Erro == false)
                {
                    I0_LOGRADOURO.Text = zipCodeInfo.Address.ToUpper();
                    I0_BAIRRO.Text = zipCodeInfo.District.ToUpper();
                    I0_UF.Text = zipCodeInfo.Uf.ToUpper();
                    I0_MUN.Text = zipCodeInfo.City.ToUpper();
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
