namespace UI
{
    partial class ControlPassageiro
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
            this.olvPassageiro = new BrightIdeasSoftware.ObjectListView();
            this.olvI0_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI0_NOME = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI0_LOGRADOURO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI0_NUMERO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaTexto = new System.Windows.Forms.TextBox();
            this.gbButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPassageiro)).BeginInit();
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
            // olvPassageiro
            // 
            this.olvPassageiro.AllColumns.Add(this.olvI0_ID);
            this.olvPassageiro.AllColumns.Add(this.olvI0_NOME);
            this.olvPassageiro.AllColumns.Add(this.olvI0_LOGRADOURO);
            this.olvPassageiro.AllColumns.Add(this.olvI0_NUMERO);
            this.olvPassageiro.AllowColumnReorder = true;
            this.olvPassageiro.AllowDrop = true;
            this.olvPassageiro.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvPassageiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPassageiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvPassageiro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvI0_ID,
            this.olvI0_NOME,
            this.olvI0_LOGRADOURO,
            this.olvI0_NUMERO});
            this.olvPassageiro.EmptyListMsg = "Sem Registros";
            this.olvPassageiro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvPassageiro.FullRowSelect = true;
            this.olvPassageiro.GridLines = true;
            this.olvPassageiro.HeaderUsesThemes = false;
            this.olvPassageiro.HideSelection = false;
            this.olvPassageiro.Location = new System.Drawing.Point(3, 29);
            this.olvPassageiro.Name = "olvPassageiro";
            this.olvPassageiro.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvPassageiro.ShowCommandMenuOnRightClick = true;
            this.olvPassageiro.ShowGroups = false;
            this.olvPassageiro.ShowImagesOnSubItems = true;
            this.olvPassageiro.ShowItemToolTips = true;
            this.olvPassageiro.Size = new System.Drawing.Size(730, 301);
            this.olvPassageiro.TabIndex = 2;
            this.olvPassageiro.TintSortColumn = true;
            this.olvPassageiro.UseAlternatingBackColors = true;
            this.olvPassageiro.UseCompatibleStateImageBehavior = false;
            this.olvPassageiro.UseFilterIndicator = true;
            this.olvPassageiro.UseFiltering = true;
            this.olvPassageiro.View = System.Windows.Forms.View.Details;
            // 
            // olvI0_ID
            // 
            this.olvI0_ID.AspectName = "I0_ID";
            this.olvI0_ID.CellPadding = null;
            this.olvI0_ID.Text = "ID";
            this.olvI0_ID.Width = 100;
            // 
            // olvI0_NOME
            // 
            this.olvI0_NOME.AspectName = "I0_NOME";
            this.olvI0_NOME.CellPadding = null;
            this.olvI0_NOME.Text = "Nome";
            this.olvI0_NOME.Width = 250;
            // 
            // olvI0_LOGRADOURO
            // 
            this.olvI0_LOGRADOURO.AspectName = "I0_LOGRADOURO";
            this.olvI0_LOGRADOURO.CellPadding = null;
            this.olvI0_LOGRADOURO.Text = "Logradouro";
            this.olvI0_LOGRADOURO.Width = 250;
            // 
            // olvI0_NUMERO
            // 
            this.olvI0_NUMERO.AspectName = "I0_NUMERO";
            this.olvI0_NUMERO.CellPadding = null;
            this.olvI0_NUMERO.Text = "Número";
            this.olvI0_NUMERO.Width = 100;
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
            // ControlPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaTexto);
            this.Controls.Add(this.olvPassageiro);
            this.Controls.Add(this.gbButtom);
            this.Name = "ControlPassageiro";
            this.Size = new System.Drawing.Size(736, 377);
            this.gbButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPassageiro)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView olvPassageiro;
        private BrightIdeasSoftware.OLVColumn olvI0_ID;
        private BrightIdeasSoftware.OLVColumn olvI0_NOME;
        private BrightIdeasSoftware.OLVColumn olvI0_LOGRADOURO;
        private BrightIdeasSoftware.OLVColumn olvI0_NUMERO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaTexto;
    }
}
