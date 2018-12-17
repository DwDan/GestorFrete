using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;
using Acess;

namespace UI
{
    public partial class ControlVeiculo : UserControl
    {
        public DatabaseContext DatabaseContext;
        public TabControl TabControl;

        public ControlVeiculo(TabControl TabControl, DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.TabControl = TabControl;
            InitializeComponent();
            olvVeiculo.SetObjects(DatabaseContext.Veiculos);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(TabControl.SelectedTab);
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Veiculo_cad cad = new Veiculo_cad(DatabaseContext, new IVeiculo());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                DatabaseContext.Veiculos.Add(cad.IVeiculo);
                DatabaseContext.SaveChanges();
                olvVeiculo.AddObject(cad.IVeiculo);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (olvVeiculo.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Veiculo_cad cad = new Veiculo_cad(DatabaseContext, (IVeiculo)olvVeiculo.SelectedObject);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvVeiculo.RefreshObject(cad.IVeiculo);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (olvVeiculo.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (DatabaseContext.Fretamentos.Where(x => x.I5_VEICULO.I3_ID == ((IVeiculo)olvVeiculo.SelectedObject).I3_ID).Count() > 0)
                {
                    MessageBox.Show("Não é possível remover veículo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DatabaseContext.Veiculos.Remove((IVeiculo)olvVeiculo.SelectedObject);
                olvVeiculo.RemoveObject(olvVeiculo.SelectedObject);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (olvVeiculo.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja visualizar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Veiculo_cad cad = new Veiculo_cad(DatabaseContext, (IVeiculo)olvVeiculo.SelectedObject, true);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvVeiculo.RefreshObject(cad.IVeiculo);
                DatabaseContext.SaveChanges();
            }
        }

        private void txtBuscaTexto_TextChanged(object sender, EventArgs e)
        {
            new OverrideOlv().TimedFilter(olvVeiculo, txtBuscaTexto.Text, 0);
        }
    }
}
