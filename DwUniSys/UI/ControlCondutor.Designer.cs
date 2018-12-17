namespace UI
{
    partial class ControlCondutor
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
            this.olvCondutor = new BrightIdeasSoftware.ObjectListView();
            this.olvI4_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_NOME = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_CPF = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_HABILITACAO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_CATEGORIA = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_LOGRADOURO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvI4_NUMERO = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaTexto = new System.Windows.Forms.TextBox();
            this.gbButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCondutor)).BeginInit();
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
            // olvCondutor
            // 
            this.olvCondutor.AllColumns.Add(this.olvI4_ID);
            this.olvCondutor.AllColumns.Add(this.olvI4_NOME);
            this.olvCondutor.AllColumns.Add(this.olvI4_CPF);
            this.olvCondutor.AllColumns.Add(this.olvI4_HABILITACAO);
            this.olvCondutor.AllColumns.Add(this.olvI4_CATEGORIA);
            this.olvCondutor.AllColumns.Add(this.olvI4_LOGRADOURO);
            this.olvCondutor.AllColumns.Add(this.olvI4_NUMERO);
            this.olvCondutor.AllowColumnReorder = true;
            this.olvCondutor.AllowDrop = true;
            this.olvCondutor.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvCondutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvCondutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvCondutor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvI4_ID,
            this.olvI4_NOME,
            this.olvI4_CPF,
            this.olvI4_HABILITACAO,
            this.olvI4_CATEGORIA,
            this.olvI4_LOGRADOURO,
            this.olvI4_NUMERO});
            this.olvCondutor.EmptyListMsg = "Sem Registros";
            this.olvCondutor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvCondutor.FullRowSelect = true;
            this.olvCondutor.GridLines = true;
            this.olvCondutor.HeaderUsesThemes = false;
            this.olvCondutor.HideSelection = false;
            this.olvCondutor.Location = new System.Drawing.Point(3, 29);
            this.olvCondutor.Name = "olvCondutor";
            this.olvCondutor.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvCondutor.ShowCommandMenuOnRightClick = true;
            this.olvCondutor.ShowGroups = false;
            this.olvCondutor.ShowImagesOnSubItems = true;
            this.olvCondutor.ShowItemToolTips = true;
            this.olvCondutor.Size = new System.Drawing.Size(730, 301);
            this.olvCondutor.TabIndex = 2;
            this.olvCondutor.TintSortColumn = true;
            this.olvCondutor.UseAlternatingBackColors = true;
            this.olvCondutor.UseCompatibleStateImageBehavior = false;
            this.olvCondutor.UseFilterIndicator = true;
            this.olvCondutor.UseFiltering = true;
            this.olvCondutor.View = System.Windows.Forms.View.Details;
            // 
            // olvI4_ID
            // 
            this.olvI4_ID.AspectName = "I4_ID";
            this.olvI4_ID.CellPadding = null;
            this.olvI4_ID.Text = "ID";
            this.olvI4_ID.Width = 100;
            // 
            // olvI4_NOME
            // 
            this.olvI4_NOME.AspectName = "I4_NOME";
            this.olvI4_NOME.CellPadding = null;
            this.olvI4_NOME.Text = "Nome";
            this.olvI4_NOME.Width = 250;
            // 
            // olvI4_CPF
            // 
            this.olvI4_CPF.AspectName = "I4_CPF";
            this.olvI4_CPF.CellPadding = null;
            this.olvI4_CPF.Text = "CPF";
            this.olvI4_CPF.Width = 100;
            // 
            // olvI4_HABILITACAO
            // 
            this.olvI4_HABILITACAO.AspectName = "I4_HABILITACAO";
            this.olvI4_HABILITACAO.CellPadding = null;
            this.olvI4_HABILITACAO.Text = "Habilitação";
            this.olvI4_HABILITACAO.Width = 100;
            // 
            // olvI4_CATEGORIA
            // 
            this.olvI4_CATEGORIA.AspectName = "I4_CATEGORIA";
            this.olvI4_CATEGORIA.CellPadding = null;
            this.olvI4_CATEGORIA.Text = "Categoria";
            this.olvI4_CATEGORIA.Width = 100;
            // 
            // olvI4_LOGRADOURO
            // 
            this.olvI4_LOGRADOURO.AspectName = "I4_LOGRADOURO";
            this.olvI4_LOGRADOURO.CellPadding = null;
            this.olvI4_LOGRADOURO.Text = "Logradouro";
            this.olvI4_LOGRADOURO.Width = 250;
            // 
            // olvI4_NUMERO
            // 
            this.olvI4_NUMERO.AspectName = "I4_NUMERO";
            this.olvI4_NUMERO.CellPadding = null;
            this.olvI4_NUMERO.Text = "Número";
            this.olvI4_NUMERO.Width = 100;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscaTexto
            // 
            this.txtBuscaTexto.Location = new System.Drawing.Point(51, 3);
            this.txtBuscaTexto.MaxLength = 100;
            this.txtBuscaTexto.Name = "txtBuscaTexto";
            this.txtBuscaTexto.Size = new System.Drawing.Size(383, 20);
            this.txtBuscaTexto.TabIndex = 1;
            // 
            // ControlCondutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaTexto);
            this.Controls.Add(this.olvCondutor);
            this.Controls.Add(this.gbButtom);
            this.Name = "ControlCondutor";
            this.Size = new System.Drawing.Size(736, 377);
            this.gbButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvCondutor)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView olvCondutor;
        private BrightIdeasSoftware.OLVColumn olvI4_ID;
        private BrightIdeasSoftware.OLVColumn olvI4_NOME;
        private BrightIdeasSoftware.OLVColumn olvI4_LOGRADOURO;
        private BrightIdeasSoftware.OLVColumn olvI4_NUMERO;
        private BrightIdeasSoftware.OLVColumn olvI4_CPF;
        private BrightIdeasSoftware.OLVColumn olvI4_HABILITACAO;
        private BrightIdeasSoftware.OLVColumn olvI4_CATEGORIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaTexto;
    }
}
