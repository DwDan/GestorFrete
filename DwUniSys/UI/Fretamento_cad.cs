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
    public partial class Fretamento_cad : Form
    {
        public DatabaseContext DatabaseContext;
        public IFretamento IFretamento;
        public bool Confirmou = false;
        public bool ReadOnly = false;
        public ICliente ICliente = new ICliente();
        public IVeiculo IVeiculo = new IVeiculo();
        public ICondutor ICondutor = new ICondutor();

        public Fretamento_cad(DatabaseContext DatabaseContext, IFretamento IFretamento, bool ReadOnly = false)
        {
            this.DatabaseContext = DatabaseContext;
            this.IFretamento = IFretamento;
            this.ReadOnly = ReadOnly;
            InitializeComponent();
            I5_ORG_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            I5_DEST_UF.DataSource = DatabaseContext.Municipios.GroupBy(x => x.I1_UF).Select(x => x.FirstOrDefault().I1_UF).OrderBy(x => x).ToList();
            PreencherCampos();
            gbPassageiro.Enabled = gbCliente.Enabled = gbCondutor.Enabled = gbData.Enabled = gbDestino.Enabled = gbFinanceiro.Enabled = gbOrigem.Enabled = gbVeiculo.Enabled = !ReadOnly;
        }

        private void I5_UF_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox ComboBox = (ComboBox)sender;
            if (ComboBox == I5_ORG_UF) I5_ORG_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I5_ORG_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
            else I5_DEST_MUN.DataSource = DatabaseContext.Municipios.Where(x => x.I1_UF == I5_DEST_UF.Text).Select(x => x.I1_MUN).OrderBy(x => x).ToList();
        }

        public void PreencherCampos()
        {
            ICliente = IFretamento.I5_CLIENTE;
            IVeiculo = IFretamento.I5_VEICULO;
            ICondutor = IFretamento.I5_CONDUTOR;
            if (!string.IsNullOrEmpty(IFretamento.I5_PASSAGEIROS))
            {
                List<IPassageiro> ListaPassageiros = DatabaseContext.Passageiros.ToList();
                ListaPassageiros = ListaPassageiros.Where(x => IFretamento.I5_PASSAGEIROS.Contains(x.I0_ID.ToString().PadLeft(6, '0'))).ToList();
                olvPassageiro.SetObjects(ListaPassageiros);
            }

            I5_NOMECLIENTE.Text = IFretamento.I5_NOMECLIENTE;
            I5_PLACA.Text = IFretamento.I5_PLACA;
            I5_NOMECONDUTOR.Text = IFretamento.I5_NOMECONDUTOR;
            I5_ORG_CEP.Text = IFretamento.I5_ORG_CEP;
            I5_ORG_LOGRADOURO.Text = IFretamento.I5_ORG_LOGRADOURO;
            I5_ORG_NUMERO.Text = IFretamento.I5_ORG_NUMERO;
            I5_ORG_COMPLEMENTO.Text = IFretamento.I5_ORG_COMPLEMENTO;
            I5_ORG_BAIRRO.Text = IFretamento.I5_ORG_BAIRRO;
            I5_ORG_UF.Text = IFretamento.I5_ORG_UF;
            I5_ORG_MUN.Text = IFretamento.I5_ORG_MUN;
            I5_DEST_CEP.Text = IFretamento.I5_DEST_CEP;
            I5_DEST_LOGRADOURO.Text = IFretamento.I5_DEST_LOGRADOURO;
            I5_DEST_NUMERO.Text = IFretamento.I5_DEST_NUMERO;
            I5_DEST_COMPLEMENTO.Text = IFretamento.I5_DEST_COMPLEMENTO;
            I5_DEST_BAIRRO.Text = IFretamento.I5_DEST_BAIRRO;
            I5_DEST_UF.Text = IFretamento.I5_DEST_UF;
            I5_DEST_MUN.Text = IFretamento.I5_DEST_MUN;
            I5_DATALANCAMENTO.Text = IFretamento.I5_DATALANCAMENTO.ToVisual();
            I5_HORALANCAMENTO.Text = IFretamento.I5_HORALANCAMENTO;
            I5_DATAINICIO.Text = IFretamento.I5_DATAINICIO.ToVisual();
            I5_HORAINICIO.Text = IFretamento.I5_HORAINICIO;
            I5_DATAFINAL.Text = IFretamento.I5_DATAFINAL.ToVisual();
            I5_HORAFINAL.Text = IFretamento.I5_HORAFINAL;
            I5_VALOR.Text = IFretamento.I5_VALOR.ToString();
        }

        public IFretamento SetarInterface(IFretamento IFretamento)
        {
            IFretamento.I5_CLIENTE = ICliente;
            IFretamento.I5_VEICULO = IVeiculo;
            IFretamento.I5_CONDUTOR = ICondutor;
            IFretamento.I5_PASSAGEIROS = olvPassageiro.Items.Count > 0 ? olvPassageiro.Objects.Cast<IPassageiro>().Aggregate(string.Empty, (a, b) => string.Format("{0}{1},", a, b.I0_ID.ToString().PadLeft(6, '0'))) : string.Empty;
            IFretamento.I5_NOMECLIENTE = I5_NOMECLIENTE.Text;
            IFretamento.I5_PLACA = I5_PLACA.Text;
            IFretamento.I5_NOMECONDUTOR = I5_NOMECONDUTOR.Text;

            IFretamento.I5_ORG_CEP = I5_ORG_CEP.Text;
            IFretamento.I5_ORG_LOGRADOURO = I5_ORG_LOGRADOURO.Text;
            IFretamento.I5_ORG_NUMERO = I5_ORG_NUMERO.Text;
            IFretamento.I5_ORG_COMPLEMENTO = I5_ORG_COMPLEMENTO.Text;
            IFretamento.I5_ORG_BAIRRO = I5_ORG_BAIRRO.Text;
            IFretamento.I5_ORG_MUN = I5_ORG_MUN.Text;
            IFretamento.I5_DEST_CEP = I5_DEST_CEP.Text;
            IFretamento.I5_DEST_LOGRADOURO = I5_DEST_LOGRADOURO.Text;
            IFretamento.I5_DEST_NUMERO = I5_DEST_NUMERO.Text;
            IFretamento.I5_DEST_COMPLEMENTO = I5_DEST_COMPLEMENTO.Text;
            IFretamento.I5_DEST_BAIRRO = I5_DEST_BAIRRO.Text;
            IFretamento.I5_DEST_MUN = I5_DEST_MUN.Text;
            IFretamento.I5_DEST_UF = I5_DEST_UF.Text;
            IFretamento.I5_DATALANCAMENTO = I5_DATALANCAMENTO.Value;
            IFretamento.I5_HORALANCAMENTO = I5_HORALANCAMENTO.Text;
            IFretamento.I5_DATAINICIO = I5_DATAINICIO.Value;
            IFretamento.I5_HORAINICIO = I5_HORAINICIO.Text;
            IFretamento.I5_DATAFINAL = I5_DATAFINAL.Value;
            IFretamento.I5_HORAFINAL = I5_HORAFINAL.Text;
            IFretamento.I5_VALOR = Convert.ToDecimal(I5_VALOR.Text.Replace("R$", ""));
            return IFretamento;
        }

        public bool Validar()
        {
            return Validacao.GetValidation(SetarInterface(new IFretamento()));
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
            SetarInterface(IFretamento);

            GetPointLatLng GetPointLatLng = new GetPointLatLng();
            IFretamento.I5_ORG_COORDENADAS = GetPointLatLng.Coordenadas(new IEndereco()
            {
                LOGRADOURO = IFretamento.I5_ORG_LOGRADOURO,
                NUMERO = IFretamento.I5_ORG_NUMERO,
                BAIRRO = IFretamento.I5_ORG_BAIRRO,
                MUNICIPIO = IFretamento.I5_ORG_MUN,
                UF = IFretamento.I5_ORG_UF
            });

            IFretamento.I5_DEST_COORDENADAS = GetPointLatLng.Coordenadas(new IEndereco()
            {
                LOGRADOURO = IFretamento.I5_DEST_LOGRADOURO,
                NUMERO = IFretamento.I5_DEST_NUMERO,
                BAIRRO = IFretamento.I5_DEST_BAIRRO,
                MUNICIPIO = IFretamento.I5_DEST_MUN,
                UF = IFretamento.I5_DEST_UF
            });
            Close();
        }

        private void I5_CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                MaskedTextBox MaskedTextBox = (MaskedTextBox)sender;
                ZipCodeInfo zipCodeInfo = ZipLoad.Find(MaskedTextBox.Text);
                if (zipCodeInfo.Erro == false)
                {
                    if (MaskedTextBox == I5_ORG_CEP)
                    {
                        I5_ORG_LOGRADOURO.Text = zipCodeInfo.Address.ToUpper();
                        I5_ORG_BAIRRO.Text = zipCodeInfo.District.ToUpper();
                        I5_ORG_UF.Text = zipCodeInfo.Uf.ToUpper();
                        I5_ORG_MUN.Text = zipCodeInfo.City.ToUpper();
                    }
                    else
                    {
                        I5_DEST_LOGRADOURO.Text = zipCodeInfo.Address.ToUpper();
                        I5_DEST_BAIRRO.Text = zipCodeInfo.District.ToUpper();
                        I5_DEST_UF.Text = zipCodeInfo.Uf.ToUpper();
                        I5_DEST_MUN.Text = zipCodeInfo.City.ToUpper();
                    }
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

        private void btn_AddCliente_Click(object sender, EventArgs e)
        {
            Cliente_cad cad = new Cliente_cad(new DatabaseContext(), new ICliente());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                cad.DatabaseContext.Clientes.Add(cad.ICliente);
                cad.DatabaseContext.SaveChanges();
                I5_NOMECLIENTE.Text = cad.ICliente.I2_NOME;
                ICliente = cad.ICliente;
            }
        }

        private void btn_AddPlaca_Click(object sender, EventArgs e)
        {
            Veiculo_cad cad = new Veiculo_cad(new DatabaseContext(), new IVeiculo());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                cad.DatabaseContext.Veiculos.Add(cad.IVeiculo);
                cad.DatabaseContext.SaveChanges();
                I5_PLACA.Text = cad.IVeiculo.I3_PLACA;
                IVeiculo = cad.IVeiculo;
            }
        }

        private void btn_AddCondutor_Click(object sender, EventArgs e)
        {
            Condutor_cad cad = new Condutor_cad(new DatabaseContext(), new ICondutor());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                cad.DatabaseContext.Condutores.Add(cad.ICondutor);
                cad.DatabaseContext.SaveChanges();
                I5_NOMECONDUTOR.Text = cad.ICondutor.I4_NOME;
                ICondutor = cad.ICondutor;
            }
        }

        private void btn_AddPassageiro_Click(object sender, EventArgs e)
        {
            Passageiro_cad cad = new Passageiro_cad(new DatabaseContext(), new IPassageiro());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                cad.DatabaseContext.Passageiros.Add(cad.IPassageiro);
                cad.DatabaseContext.SaveChanges();
                olvPassageiro.AddObject(cad.IPassageiro);
            }
        }

        private void btn_RemovePassageiro_Click(object sender, EventArgs e)
        {
            if (olvPassageiro.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                olvPassageiro.RemoveObject(olvPassageiro.SelectedObject);
            }
        }

        private void btn_SearchCliente_Click(object sender, EventArgs e)
        {
            Localizar Localizar = new Localizar(DatabaseContext, Localizar.TipoBusca.Cliente);
            Localizar.ShowDialog();
            if (Localizar.Confirmou)
            {
                ICliente = (ICliente)Localizar.Object;
                I5_NOMECLIENTE.Text = ICliente.I2_NOME;
            }
        }

        private void btn_SearchPassageiro_Click(object sender, EventArgs e)
        {
            Localizar Localizar = new Localizar(DatabaseContext, Localizar.TipoBusca.Passageiro);
            Localizar.ShowDialog();
            if (Localizar.Confirmou)
            {
                IPassageiro IPassageiro = (IPassageiro)Localizar.Object;
                if (olvPassageiro.Items.Count > 0 && olvPassageiro.Objects.Cast<IPassageiro>().Where(x => x.I0_ID == IPassageiro.I0_ID).Count() > 0)
                    MessageBox.Show("Passageiro já existente na lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else olvPassageiro.AddObject(IPassageiro);
            }
        }

        private void btn_SearchPlaca_Click(object sender, EventArgs e)
        {
            Localizar Localizar = new Localizar(DatabaseContext, Localizar.TipoBusca.Veiculo);
            Localizar.ShowDialog();
            if (Localizar.Confirmou)
            {
                IVeiculo = (IVeiculo)Localizar.Object;
                I5_PLACA.Text = IVeiculo.I3_PLACA;
            }
        }

        private void btn_SearchCondutor_Click(object sender, EventArgs e)
        {
            Localizar Localizar = new Localizar(DatabaseContext, Localizar.TipoBusca.Condutor);
            Localizar.ShowDialog();
            if (Localizar.Confirmou)
            {
                ICondutor = (ICondutor)Localizar.Object;
                I5_NOMECONDUTOR.Text = ICondutor.I4_NOME;
            }
        }

        private void Fretamento_cad_Load(object sender, EventArgs e)
        {
            new TextBoxExtension(I5_VALOR);
        }
    }
}
