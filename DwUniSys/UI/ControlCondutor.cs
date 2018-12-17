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
    public partial class ControlCondutor : UserControl
    {
        public DatabaseContext DatabaseContext;
        public TabControl TabControl;

        public ControlCondutor(TabControl TabControl, DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.TabControl = TabControl;
            InitializeComponent();
            olvCondutor.SetObjects(DatabaseContext.Condutores);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(TabControl.SelectedTab);
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Condutor_cad cad = new Condutor_cad(DatabaseContext, new ICondutor());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                DatabaseContext.Condutores.Add(cad.ICondutor);
                DatabaseContext.SaveChanges();
                olvCondutor.AddObject(cad.ICondutor);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (olvCondutor.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Condutor_cad cad = new Condutor_cad(DatabaseContext, (ICondutor)olvCondutor.SelectedObject);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvCondutor.RefreshObject(cad.ICondutor);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (olvCondutor.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (DatabaseContext.Fretamentos.Where(x => x.I5_CONDUTOR.I4_ID == ((ICondutor)olvCondutor.SelectedObject).I4_ID).Count() > 0)
                {
                    MessageBox.Show("Não é possível remover condutor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DatabaseContext.Condutores.Remove((ICondutor)olvCondutor.SelectedObject);
                olvCondutor.RemoveObject(olvCondutor.SelectedObject);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (olvCondutor.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja visualizar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Condutor_cad cad = new Condutor_cad(DatabaseContext, (ICondutor)olvCondutor.SelectedObject, true);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvCondutor.RefreshObject(cad.ICondutor);
                DatabaseContext.SaveChanges();
            }
        }
    }
}
