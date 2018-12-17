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
    public partial class ControlFretamento : UserControl
    {
        public DatabaseContext DatabaseContext;
        public TabControl TabControl;

        public ControlFretamento(TabControl TabControl, DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
            this.TabControl = TabControl;
            InitializeComponent();
            olvFretamento.SetObjects(DatabaseContext.Fretamentos);
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(TabControl.SelectedTab);
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Fretamento_cad cad = new Fretamento_cad(DatabaseContext, new IFretamento());
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                DatabaseContext.Fretamentos.Add(cad.IFretamento);
                DatabaseContext.SaveChanges();
                olvFretamento.AddObject(cad.IFretamento);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (olvFretamento.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Fretamento_cad cad = new Fretamento_cad(DatabaseContext, (IFretamento)olvFretamento.SelectedObject);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvFretamento.RefreshObject(cad.IFretamento);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (olvFretamento.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja excluir.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else if (MessageBox.Show("Está certo que deseja excluir registro?", "Atenção.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DatabaseContext.Fretamentos.Remove((IFretamento)olvFretamento.SelectedObject);
                olvFretamento.RemoveObject(olvFretamento.SelectedObject);
                DatabaseContext.SaveChanges();
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (olvFretamento.SelectedObject == null) { MessageBox.Show("Selecione o registro que deseja visualizar.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Fretamento_cad cad = new Fretamento_cad(DatabaseContext, (IFretamento)olvFretamento.SelectedObject, true);
            cad.ShowDialog();
            if (cad.Confirmou)
            {
                olvFretamento.RefreshObject(cad.IFretamento);
                DatabaseContext.SaveChanges();
            }
        }

        private void txtBuscaTexto_TextChanged(object sender, EventArgs e)
        {
            new OverrideOlv().TimedFilter(olvFretamento, txtBuscaTexto.Text, 0);
        }
    }
}
