namespace UI
{
    partial class Condutor_cad
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.I4_CATEGORIA = new System.Windows.Forms.ComboBox();
            this.I4_HABILITACAO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.I4_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.I4_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.I4_UF = new System.Windows.Forms.ComboBox();
            this.I4_MUN = new System.Windows.Forms.ComboBox();
            this.I4_COMPLEMENTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.I4_BAIRRO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.I4_LOGRADOURO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.I4_NUMERO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.I4_RG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.I4_NOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbButtom = new System.Windows.Forms.GroupBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            this.gbButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.label12);
            this.gbDados.Controls.Add(this.I4_CATEGORIA);
            this.gbDados.Controls.Add(this.I4_HABILITACAO);
            this.gbDados.Controls.Add(this.label11);
            this.gbDados.Controls.Add(this.I4_CEP);
            this.gbDados.Controls.Add(this.label10);
            this.gbDados.Controls.Add(this.I4_CPF);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.I4_UF);
            this.gbDados.Controls.Add(this.I4_MUN);
            this.gbDados.Controls.Add(this.I4_COMPLEMENTO);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.I4_BAIRRO);
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.I4_LOGRADOURO);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.I4_NUMERO);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.I4_RG);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.I4_NOME);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Location = new System.Drawing.Point(6, 2);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(600, 235);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(18, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Categoria";
            // 
            // I4_CATEGORIA
            // 
            this.I4_CATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I4_CATEGORIA.FormattingEnabled = true;
            this.I4_CATEGORIA.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "AB"});
            this.I4_CATEGORIA.Location = new System.Drawing.Point(82, 75);
            this.I4_CATEGORIA.Name = "I4_CATEGORIA";
            this.I4_CATEGORIA.Size = new System.Drawing.Size(146, 21);
            this.I4_CATEGORIA.TabIndex = 9;
            this.I4_CATEGORIA.Tag = "Categoria";
            // 
            // I4_HABILITACAO
            // 
            this.I4_HABILITACAO.Location = new System.Drawing.Point(82, 49);
            this.I4_HABILITACAO.MaxLength = 10;
            this.I4_HABILITACAO.Name = "I4_HABILITACAO";
            this.I4_HABILITACAO.Size = new System.Drawing.Size(146, 20);
            this.I4_HABILITACAO.TabIndex = 5;
            this.I4_HABILITACAO.Tag = "Habilitação";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Habilitação";
            // 
            // I4_CEP
            // 
            this.I4_CEP.Location = new System.Drawing.Point(82, 104);
            this.I4_CEP.Mask = "00000-000";
            this.I4_CEP.Name = "I4_CEP";
            this.I4_CEP.Size = new System.Drawing.Size(146, 20);
            this.I4_CEP.TabIndex = 11;
            this.I4_CEP.Tag = "CEP";
            this.I4_CEP.Leave += new System.EventHandler(this.I4_CEP_Leave);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "CEP";
            // 
            // I4_CPF
            // 
            this.I4_CPF.Location = new System.Drawing.Point(448, 23);
            this.I4_CPF.Mask = "000.000.000-00";
            this.I4_CPF.Name = "I4_CPF";
            this.I4_CPF.Size = new System.Drawing.Size(146, 20);
            this.I4_CPF.TabIndex = 3;
            this.I4_CPF.Tag = "CPF";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(240, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Município";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "UF";
            // 
            // I4_UF
            // 
            this.I4_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I4_UF.FormattingEnabled = true;
            this.I4_UF.Location = new System.Drawing.Point(82, 182);
            this.I4_UF.Name = "I4_UF";
            this.I4_UF.Size = new System.Drawing.Size(146, 21);
            this.I4_UF.TabIndex = 21;
            this.I4_UF.Tag = "UF";
            this.I4_UF.SelectedValueChanged += new System.EventHandler(this.I4_UF_SelectedValueChanged);
            // 
            // I4_MUN
            // 
            this.I4_MUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I4_MUN.FormattingEnabled = true;
            this.I4_MUN.Location = new System.Drawing.Point(310, 182);
            this.I4_MUN.Name = "I4_MUN";
            this.I4_MUN.Size = new System.Drawing.Size(284, 21);
            this.I4_MUN.TabIndex = 23;
            this.I4_MUN.Tag = "Município";
            // 
            // I4_COMPLEMENTO
            // 
            this.I4_COMPLEMENTO.Location = new System.Drawing.Point(448, 156);
            this.I4_COMPLEMENTO.MaxLength = 50;
            this.I4_COMPLEMENTO.Name = "I4_COMPLEMENTO";
            this.I4_COMPLEMENTO.Size = new System.Drawing.Size(146, 20);
            this.I4_COMPLEMENTO.TabIndex = 19;
            this.I4_COMPLEMENTO.Tag = "Complemento";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(373, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Complemento";
            // 
            // I4_BAIRRO
            // 
            this.I4_BAIRRO.Location = new System.Drawing.Point(82, 156);
            this.I4_BAIRRO.MaxLength = 100;
            this.I4_BAIRRO.Name = "I4_BAIRRO";
            this.I4_BAIRRO.Size = new System.Drawing.Size(284, 20);
            this.I4_BAIRRO.TabIndex = 17;
            this.I4_BAIRRO.Tag = "Bairro";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bairro";
            // 
            // I4_LOGRADOURO
            // 
            this.I4_LOGRADOURO.Location = new System.Drawing.Point(82, 130);
            this.I4_LOGRADOURO.MaxLength = 100;
            this.I4_LOGRADOURO.Name = "I4_LOGRADOURO";
            this.I4_LOGRADOURO.Size = new System.Drawing.Size(284, 20);
            this.I4_LOGRADOURO.TabIndex = 13;
            this.I4_LOGRADOURO.Tag = "Logradouro";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logradouro";
            // 
            // I4_NUMERO
            // 
            this.I4_NUMERO.Location = new System.Drawing.Point(448, 130);
            this.I4_NUMERO.MaxLength = 10;
            this.I4_NUMERO.Name = "I4_NUMERO";
            this.I4_NUMERO.Size = new System.Drawing.Size(146, 20);
            this.I4_NUMERO.TabIndex = 15;
            this.I4_NUMERO.Tag = "Número";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(373, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número";
            // 
            // I4_RG
            // 
            this.I4_RG.Location = new System.Drawing.Point(448, 49);
            this.I4_RG.MaxLength = 10;
            this.I4_RG.Name = "I4_RG";
            this.I4_RG.Size = new System.Drawing.Size(146, 20);
            this.I4_RG.TabIndex = 7;
            this.I4_RG.Tag = "RG";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(373, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(373, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // I4_NOME
            // 
            this.I4_NOME.Location = new System.Drawing.Point(82, 23);
            this.I4_NOME.MaxLength = 250;
            this.I4_NOME.Name = "I4_NOME";
            this.I4_NOME.Size = new System.Drawing.Size(284, 20);
            this.I4_NOME.TabIndex = 1;
            this.I4_NOME.Tag = "Cliente";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // gbButtom
            // 
            this.gbButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtom.Controls.Add(this.btn_Confirmar);
            this.gbButtom.Controls.Add(this.btn_Cancelar);
            this.gbButtom.Location = new System.Drawing.Point(6, 243);
            this.gbButtom.Name = "gbButtom";
            this.gbButtom.Size = new System.Drawing.Size(600, 44);
            this.gbButtom.TabIndex = 1;
            this.gbButtom.TabStop = false;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.Location = new System.Drawing.Point(488, 10);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(106, 29);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Location = new System.Drawing.Point(376, 10);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(106, 29);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Condutor_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 292);
            this.Controls.Add(this.gbButtom);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Condutor_cad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condutor";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbButtom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox gbButtom;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox I4_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox I4_LOGRADOURO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox I4_NUMERO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox I4_COMPLEMENTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox I4_BAIRRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox I4_UF;
        private System.Windows.Forms.ComboBox I4_MUN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox I4_CPF;
        private System.Windows.Forms.TextBox I4_RG;
        private System.Windows.Forms.MaskedTextBox I4_CEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox I4_CATEGORIA;
        private System.Windows.Forms.TextBox I4_HABILITACAO;
        private System.Windows.Forms.Label label11;
    }
}