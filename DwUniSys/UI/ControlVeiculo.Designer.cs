namespace UI
{
    partial class ControlVeiculo
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
            this.olvVeiculo = new BrightIdeasSoftware.ObjectListView();
            this.olvI3_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI3_PLACA = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI3_MARCA = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI3_MODELO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI3_RENAVAM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI3_CHASSI = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaTexto = new System.Windows.Forms.TextBox();
            this.gbButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvVeiculo)).BeginInit();
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
            // olvVeiculo
            // 
            this.olvVeiculo.AllColumns.Add(this.olvI3_ID);
            this.olvVeiculo.AllColumns.Add(this.olvI3_PLACA);
            this.olvVeiculo.AllColumns.Add(this.olvI3_MARCA);
            this.olvVeiculo.AllColumns.Add(this.olvI3_MODELO);
            this.olvVeiculo.AllColumns.Add(this.olvI3_RENAVAM);
            this.olvVeiculo.AllColumns.Add(this.olvI3_CHASSI);
            this.olvVeiculo.AllowColumnReorder = true;
            this.olvVeiculo.AllowDrop = true;
            this.olvVeiculo.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvVeiculo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvI3_ID,
            this.olvI3_PLACA,
            this.olvI3_MARCA,
            this.olvI3_MODELO,
            this.olvI3_RENAVAM,
            this.olvI3_CHASSI});
            this.olvVeiculo.EmptyListMsg = "Sem Registros";
            this.olvVeiculo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvVeiculo.FullRowSelect = true;
            this.olvVeiculo.GridLines = true;
            this.olvVeiculo.HeaderUsesThemes = false;
            this.olvVeiculo.HideSelection = false;
            this.olvVeiculo.Location = new System.Drawing.Point(3, 29);
            this.olvVeiculo.Name = "olvVeiculo";
            this.olvVeiculo.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvVeiculo.ShowCommandMenuOnRightClick = true;
            this.olvVeiculo.ShowGroups = false;
            this.olvVeiculo.ShowImagesOnSubItems = true;
            this.olvVeiculo.ShowItemToolTips = true;
            this.olvVeiculo.Size = new System.Drawing.Size(730, 301);
            this.olvVeiculo.TabIndex = 2;
            this.olvVeiculo.TintSortColumn = true;
            this.olvVeiculo.UseAlternatingBackColors = true;
            this.olvVeiculo.UseCompatibleStateImageBehavior = false;
            this.olvVeiculo.UseFilterIndicator = true;
            this.olvVeiculo.UseFiltering = true;
            this.olvVeiculo.View = System.Windows.Forms.View.Details;
            // 
            // olvI3_ID
            // 
            this.olvI3_ID.AspectName = "I3_ID";
            this.olvI3_ID.CellPadding = null;
            this.olvI3_ID.Text = "ID";
            this.olvI3_ID.Width = 100;
            // 
            // olvI3_PLACA
            // 
            this.olvI3_PLACA.AspectName = "I3_PLACA";
            this.olvI3_PLACA.CellPadding = null;
            this.olvI3_PLACA.Text = "Placa";
            this.olvI3_PLACA.Width = 100;
            // 
            // olvI3_MARCA
            // 
            this.olvI3_MARCA.AspectName = "I3_MARCA";
            this.olvI3_MARCA.CellPadding = null;
            this.olvI3_MARCA.Text = "Marca";
            this.olvI3_MARCA.Width = 200;
            // 
            // olvI3_MODELO
            // 
            this.olvI3_MODELO.AspectName = "I3_MODELO";
            this.olvI3_MODELO.CellPadding = null;
            this.olvI3_MODELO.Text = "Modelo";
            this.olvI3_MODELO.Width = 200;
            // 
            // olvI3_RENAVAM
            // 
            this.olvI3_RENAVAM.AspectName = "I3_RENAVAM";
            this.olvI3_RENAVAM.CellPadding = null;
            this.olvI3_RENAVAM.Text = "Renavam";
            this.olvI3_RENAVAM.Width = 100;
            // 
            // olvI3_CHASSI
            // 
            this.olvI3_CHASSI.AspectName = "I3_CHASSI";
            this.olvI3_CHASSI.CellPadding = null;
            this.olvI3_CHASSI.Text = "Chassi";
            this.olvI3_CHASSI.Width = 200;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscaTexto
            // 
            this.txtBuscaTexto.Location = new System.Drawing.Point(53, 3);
            this.txtBuscaTexto.MaxLength = 100;
            this.txtBuscaTexto.Name = "txtBuscaTexto";
            this.txtBuscaTexto.Size = new System.Drawing.Size(383, 20);
            this.txtBuscaTexto.TabIndex = 1;
            this.txtBuscaTexto.TextChanged += new System.EventHandler(this.txtBuscaTexto_TextChanged);
            // 
            // ControlVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaTexto);
            this.Controls.Add(this.olvVeiculo);
            this.Controls.Add(this.gbButtom);
            this.Name = "ControlVeiculo";
            this.Size = new System.Drawing.Size(736, 377);
            this.gbButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvVeiculo)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView olvVeiculo;
        private BrightIdeasSoftware.OLVColumn olvI3_ID;
        private BrightIdeasSoftware.OLVColumn olvI3_PLACA;
        private BrightIdeasSoftware.OLVColumn olvI3_RENAVAM;
        private BrightIdeasSoftware.OLVColumn olvI3_CHASSI;
        private BrightIdeasSoftware.OLVColumn olvI3_MARCA;
        private BrightIdeasSoftware.OLVColumn olvI3_MODELO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaTexto;
    }
}
