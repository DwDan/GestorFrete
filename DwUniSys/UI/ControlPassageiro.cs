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
    public partial class ControlPassageiro : UserControl
    {
        public DatabaseContext DatabaseContext;
        public TabControl TabControl;

        public ControlPassageiro(TabControl TabControl, DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.TabControl = TabControl;
            InitializeComponent();
            olvPassageiro.SetObjects(DatabaseContext.Passageiros);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(TabControl.SelectedTab);
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Passageiro_cad cad = new Passageiro_cad(DatabaseContext, new IPassageiro());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                DatabaseContext.Passageiros.Add(cad.IPassageiro);
                DatabaseContext.SaveChanges();
                olvPassageiro.AddObject(cad.IPassageiro);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (olvPassageiro.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Passageiro_cad cad = new Passageiro_cad(DatabaseContext, (IPassageiro)olvPassageiro.SelectedObject);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvPassageiro.RefreshObject(cad.IPassageiro);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (olvPassageiro.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DatabaseContext.Passageiros.Remove((IPassageiro)olvPassageiro.SelectedObject);
                olvPassageiro.RemoveObject(olvPassageiro.SelectedObject);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (olvPassageiro.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja visualizar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Passageiro_cad cad = new Passageiro_cad(DatabaseContext, (IPassageiro)olvPassageiro.SelectedObject, true);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvPassageiro.RefreshObject(cad.IPassageiro);
                DatabaseContext.SaveChanges();
            }
        }

        private void txtBuscaTexto_TextChanged(object sender, EventArgs e)
        {
            new OverrideOlv().TimedFilter(olvPassageiro, txtBuscaTexto.Text, 0);
        }
    }
}
