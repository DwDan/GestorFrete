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
    public partial class ControlCliente : UserControl
    {
        public DatabaseContext DatabaseContext;
        public TabControl TabControl;

        public ControlCliente(TabControl TabControl, DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.TabControl = TabControl;
            InitializeComponent();
            olvCliente.SetObjects(DatabaseContext.Clientes);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(TabControl.SelectedTab);
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Cliente_cad cad = new Cliente_cad(DatabaseContext, new ICliente());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                DatabaseContext.Clientes.Add(cad.ICliente);
                DatabaseContext.SaveChanges();
                olvCliente.AddObject(cad.ICliente);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (olvCliente.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Cliente_cad cad = new Cliente_cad(DatabaseContext, (ICliente)olvCliente.SelectedObject);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvCliente.RefreshObject(cad.ICliente);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (olvCliente.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (DatabaseContext.Fretamentos.Where(x => x.I5_CLIENTE.I2_ID == ((ICliente)olvCliente.SelectedObject).I2_ID).Count() > 0)
                {
                    MessageBox.Show("Não é possível remover cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DatabaseContext.Clientes.Remove((ICliente)olvCliente.SelectedObject);
                olvCliente.RemoveObject(olvCliente.SelectedObject);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (olvCliente.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja visualizar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Cliente_cad cad = new Cliente_cad(DatabaseContext, (ICliente)olvCliente.SelectedObject, true);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvCliente.RefreshObject(cad.ICliente);
                DatabaseContext.SaveChanges();
            }
        }

        private void txtBuscaTexto_TextChanged(object sender, EventArgs e)
        {
            new OverrideOlv().TimedFilter(olvCliente, txtBuscaTexto.Text, 0);
        }
    }
}
