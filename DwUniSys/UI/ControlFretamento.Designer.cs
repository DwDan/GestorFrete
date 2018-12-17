namespace UI
{
    partial class ControlFretamento
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbButtom = new System.Windows.Forms.GroupBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.olvFretamento = new BrightIdeasSoftware.ObjectListView();
            this.olvI5_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_NOMECLIENTE = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_PLACA = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_NOMECONDUTOR = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_VALOR = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_DATAINICIO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI5_DATAFINAL = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaTexto = new System.Windows.Forms.TextBox();
            this.gbButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFretamento)).BeginInit();
            this.SuspendLayout();
            // 
            // gbButtom
            // 
            this.gbButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtom.Controls.Add(this.btn_Incluir);
            this.gbButtom.Controls.Add(this.btn_Excluir);
            this.gbButtom.Controls.Add(this.btn_Alterar);
            this.gbButtom.Controls.Add(this.btn_Visualizar);
            this.gbButtom.Controls.Add(this.btn_Fechar);
            this.gbButtom.Location = new System.Drawing.Point(3, 330);
            this.gbButtom.Name = "gbButtom";
            this.gbButtom.Size = new System.Drawing.Size(730, 44);
            this.gbButtom.TabIndex = 3;
            this.gbButtom.TabStop = false;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.Location = new System.Drawing.Point(200, 10);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(100, 30);
            this.btn_Incluir.TabIndex = 0;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Location = new System.Drawing.Point(412, 10);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 30);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alterar.Location = new System.Drawing.Point(306, 10);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(100, 30);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Visualizar.Location = new System.Drawing.Point(518, 10);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_Visualizar.TabIndex = 3;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Location = new System.Drawing.Point(624, 10);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // olvFretamento
            // 
            this.olvFretamento.AllColumns.Add(this.olvI5_ID);
            this.olvFretamento.AllColumns.Add(this.olvI5_NOMECLIENTE);
            this.olvFretamento.AllColumns.Add(this.olvI5_PLACA);
            this.olvFretamento.AllColumns.Add(this.olvI5_NOMECONDUTOR);
            this.olvFretamento.AllColumns.Add(this.olvI5_VALOR);
            this.olvFretamento.AllColumns.Add(this.olvI5_DATAINICIO);
            this.olvFretamento.AllColumns.Add(this.olvI5_DATAFINAL);
            this.olvFretamento.AllowColumnReorder = true;
            this.olvFretamento.AllowDrop = true;
            this.olvFretamento.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvFretamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFretamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvFretamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvI5_ID,
            this.olvI5_NOMECLIENTE,
            this.olvI5_PLACA,
            this.olvI5_NOMECONDUTOR,
            this.olvI5_VALOR,
            this.olvI5_DATAINICIO,
            this.olvI5_DATAFINAL});
            this.olvFretamento.EmptyListMsg = "Sem Registros";
            this.olvFretamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvFretamento.FullRowSelect = true;
            this.olvFretamento.GridLines = true;
            this.olvFretamento.HeaderUsesThemes = false;
            this.olvFretamento.HideSelection = false;
            this.olvFretamento.Location = new System.Drawing.Point(3, 29);
            this.olvFretamento.Name = "olvFretamento";
            this.olvFretamento.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvFretamento.ShowCommandMenuOnRightClick = true;
            this.olvFretamento.ShowGroups = false;
            this.olvFretamento.ShowImagesOnSubItems = true;
            this.olvFretamento.ShowItemToolTips = true;
            this.olvFretamento.Size = new System.Drawing.Size(730, 301);
            this.olvFretamento.TabIndex = 2;
            this.olvFretamento.TintSortColumn = true;
            this.olvFretamento.UseAlternatingBackColors = true;
            this.olvFretamento.UseCompatibleStateImageBehavior = false;
            this.olvFretamento.UseFilterIndicator = true;
            this.olvFretamento.UseFiltering = true;
            this.olvFretamento.View = System.Windows.Forms.View.Details;
            // 
            // olvI5_ID
            // 
            this.olvI5_ID.AspectName = "I5_ID";
            this.olvI5_ID.CellPadding = null;
            this.olvI5_ID.Text = "ID";
            this.olvI5_ID.Width = 100;
            // 
            // olvI5_NOMECLIENTE
            // 
            this.olvI5_NOMECLIENTE.AspectName = "I5_NOMECLIENTE";
            this.olvI5_NOMECLIENTE.CellPadding = null;
            this.olvI5_NOMECLIENTE.Text = "Cliente";
            this.olvI5_NOMECLIENTE.Width = 250;
            // 
            // olvI5_PLACA
            // 
            this.olvI5_PLACA.AspectName = "I5_PLACA";
            this.olvI5_PLACA.CellPadding = null;
            this.olvI5_PLACA.Text = "Placa";
            this.olvI5_PLACA.Width = 100;
            // 
            // olvI5_NOMECONDUTOR
            // 
            this.olvI5_NOMECONDUTOR.AspectName = "I5_NOMECONDUTOR";
            this.olvI5_NOMECONDUTOR.CellPadding = null;
            this.olvI5_NOMECONDUTOR.Text = "Condutor";
            this.olvI5_NOMECONDUTOR.Width = 100;
            // 
            // olvI5_VALOR
            // 
            this.olvI5_VALOR.AspectName = "I5_VALOR";
            this.olvI5_VALOR.AspectToStringFormat = "{0:C2}";
            this.olvI5_VALOR.CellPadding = null;
            this.olvI5_VALOR.Text = "Valor";
            this.olvI5_VALOR.Width = 100;
            // 
            // olvI5_DATAINICIO
            // 
            this.olvI5_DATAINICIO.AspectName = "I5_DATAINICIO";
            this.olvI5_DATAINICIO.AspectToStringFormat = "{0:dd/MM/yyyy}";
            this.olvI5_DATAINICIO.CellPadding = null;
            this.olvI5_DATAINICIO.Text = "Início";
            this.olvI5_DATAINICIO.Width = 100;
            // 
            // olvI5_DATAFINAL
            // 
            this.olvI5_DATAFINAL.AspectName = "I5_DATAFINAL";
            this.olvI5_DATAFINAL.AspectToStringFormat = "{0:dd/MM/yyyy}";
            this.olvI5_DATAFINAL.CellPadding = null;
            this.olvI5_DATAFINAL.Text = "Final";
            this.olvI5_DATAFINAL.Width = 100;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscaTexto
            // 
            this.txtBuscaTexto.Location = new System.Drawing.Point(52, 3);
            this.txtBuscaTexto.MaxLength = 100;
            this.txtBuscaTexto.Name = "txtBuscaTexto";
            this.txtBuscaTexto.Size = new System.Drawing.Size(383, 20);
            this.txtBuscaTexto.TabIndex = 1;
            this.txtBuscaTexto.TextChanged += new System.EventHandler(this.txtBuscaTexto_TextChanged);
            // 
            // ControlFretamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaTexto);
            this.Controls.Add(this.olvFretamento);
            this.Controls.Add(this.gbButtom);
            this.Name = "ControlFretamento";
            this.Size = new System.Drawing.Size(736, 377);
            this.gbButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvFretamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButtom;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private BrightIdeasSoftware.ObjectListView olvFretamento;
        private BrightIdeasSoftware.OLVColumn olvI5_ID;
        private BrightIdeasSoftware.OLVColumn olvI5_NOMECLIENTE;
        private BrightIdeasSoftware.OLVColumn olvI5_VALOR;
        private BrightIdeasSoftware.OLVColumn olvI5_DATAINICIO;
        private BrightIdeasSoftware.OLVColumn olvI5_PLACA;
        private BrightIdeasSoftware.OLVColumn olvI5_NOMECONDUTOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaTexto;
        private BrightIdeasSoftware.OLVColumn olvI5_DATAFINAL;
    }
}
