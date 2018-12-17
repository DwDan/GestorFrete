namespace UI
{
    partial class Cliente_cad
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
            this.I2_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.I2_UF = new System.Windows.Forms.ComboBox();
            this.I2_MUN = new System.Windows.Forms.ComboBox();
            this.I2_COMPLEMENTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.I2_BAIRRO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.I2_LOGRADOURO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.I2_NUMERO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.I2_CPF = new System.Windows.Forms.MaskedTextBox();
            this.I2_RG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.I2_NOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbButtom = new System.Windows.Forms.GroupBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbFisica = new System.Windows.Forms.GroupBox();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.gbPessoa = new System.Windows.Forms.GroupBox();
            this.gbJuridica = new System.Windows.Forms.GroupBox();
            this.I2_INSCESTADUAL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.I2_RAZAOSOCIAL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.I2_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.I2_INSCMUNICIPAL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.gbButtom.SuspendLayout();
            this.gbFisica.SuspendLayout();
            this.gbPessoa.SuspendLayout();
            this.gbJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.I2_CEP);
            this.gbDados.Controls.Add(this.label10);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.I2_UF);
            this.gbDados.Controls.Add(this.I2_MUN);
            this.gbDados.Controls.Add(this.I2_COMPLEMENTO);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.I2_BAIRRO);
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.I2_LOGRADOURO);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.I2_NUMERO);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Location = new System.Drawing.Point(6, 137);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(600, 158);
            this.gbDados.TabIndex = 3;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // I2_CEP
            // 
            this.I2_CEP.Location = new System.Drawing.Point(82, 19);
            this.I2_CEP.Mask = "00000-000";
            this.I2_CEP.Name = "I2_CEP";
            this.I2_CEP.Size = new System.Drawing.Size(146, 20);
            this.I2_CEP.TabIndex = 1;
            this.I2_CEP.Tag = "CEP";
            this.I2_CEP.Leave += new System.EventHandler(this.I2_CEP_Leave);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "CEP";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(240, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Município";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "UF";
            // 
            // I2_UF
            // 
            this.I2_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I2_UF.FormattingEnabled = true;
            this.I2_UF.Location = new System.Drawing.Point(82, 97);
            this.I2_UF.Name = "I2_UF";
            this.I2_UF.Size = new System.Drawing.Size(146, 21);
            this.I2_UF.TabIndex = 11;
            this.I2_UF.Tag = "UF";
            this.I2_UF.SelectedValueChanged += new System.EventHandler(this.I2_UF_SelectedValueChanged);
            // 
            // I2_MUN
            // 
            this.I2_MUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I2_MUN.FormattingEnabled = true;
            this.I2_MUN.Location = new System.Drawing.Point(310, 97);
            this.I2_MUN.Name = "I2_MUN";
            this.I2_MUN.Size = new System.Drawing.Size(284, 21);
            this.I2_MUN.TabIndex = 13;
            this.I2_MUN.Tag = "Município";
            // 
            // I2_COMPLEMENTO
            // 
            this.I2_COMPLEMENTO.Location = new System.Drawing.Point(448, 71);
            this.I2_COMPLEMENTO.MaxLength = 50;
            this.I2_COMPLEMENTO.Name = "I2_COMPLEMENTO";
            this.I2_COMPLEMENTO.Size = new System.Drawing.Size(146, 20);
            this.I2_COMPLEMENTO.TabIndex = 9;
            this.I2_COMPLEMENTO.Tag = "Complemento";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(373, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Complemento";
            // 
            // I2_BAIRRO
            // 
            this.I2_BAIRRO.Location = new System.Drawing.Point(82, 71);
            this.I2_BAIRRO.MaxLength = 100;
            this.I2_BAIRRO.Name = "I2_BAIRRO";
            this.I2_BAIRRO.Size = new System.Drawing.Size(284, 20);
            this.I2_BAIRRO.TabIndex = 7;
            this.I2_BAIRRO.Tag = "Bairro";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bairro";
            // 
            // I2_LOGRADOURO
            // 
            this.I2_LOGRADOURO.Location = new System.Drawing.Point(82, 45);
            this.I2_LOGRADOURO.MaxLength = 100;
            this.I2_LOGRADOURO.Name = "I2_LOGRADOURO";
            this.I2_LOGRADOURO.Size = new System.Drawing.Size(284, 20);
            this.I2_LOGRADOURO.TabIndex = 3;
            this.I2_LOGRADOURO.Tag = "Logradouro";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Logradouro";
            // 
            // I2_NUMERO
            // 
            this.I2_NUMERO.Location = new System.Drawing.Point(448, 45);
            this.I2_NUMERO.MaxLength = 10;
            this.I2_NUMERO.Name = "I2_NUMERO";
            this.I2_NUMERO.Size = new System.Drawing.Size(146, 20);
            this.I2_NUMERO.TabIndex = 5;
            this.I2_NUMERO.Tag = "Número";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(373, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número";
            // 
            // I2_CPF
            // 
            this.I2_CPF.Location = new System.Drawing.Point(438, 19);
            this.I2_CPF.Mask = "000.000.000-00";
            this.I2_CPF.Name = "I2_CPF";
            this.I2_CPF.Size = new System.Drawing.Size(146, 20);
            this.I2_CPF.TabIndex = 3;
            this.I2_CPF.Tag = "CPF";
            // 
            // I2_RG
            // 
            this.I2_RG.Location = new System.Drawing.Point(438, 45);
            this.I2_RG.MaxLength = 10;
            this.I2_RG.Name = "I2_RG";
            this.I2_RG.Size = new System.Drawing.Size(146, 20);
            this.I2_RG.TabIndex = 5;
            this.I2_RG.Tag = "RG";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(363, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(363, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // I2_NOME
            // 
            this.I2_NOME.Location = new System.Drawing.Point(72, 19);
            this.I2_NOME.MaxLength = 250;
            this.I2_NOME.Name = "I2_NOME";
            this.I2_NOME.Size = new System.Drawing.Size(284, 20);
            this.I2_NOME.TabIndex = 1;
            this.I2_NOME.Tag = "Nome";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 22);
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
            this.gbButtom.Location = new System.Drawing.Point(6, 299);
            this.gbButtom.Name = "gbButtom";
            this.gbButtom.Size = new System.Drawing.Size(600, 44);
            this.gbButtom.TabIndex = 4;
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
            // gbFisica
            // 
            this.gbFisica.Controls.Add(this.I2_NOME);
            this.gbFisica.Controls.Add(this.label1);
            this.gbFisica.Controls.Add(this.I2_CPF);
            this.gbFisica.Controls.Add(this.label2);
            this.gbFisica.Controls.Add(this.I2_RG);
            this.gbFisica.Controls.Add(this.label3);
            this.gbFisica.Location = new System.Drawing.Point(6, 50);
            this.gbFisica.Name = "gbFisica";
            this.gbFisica.Size = new System.Drawing.Size(600, 81);
            this.gbFisica.TabIndex = 2;
            this.gbFisica.TabStop = false;
            this.gbFisica.Text = "Física";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(235, 16);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(295, 16);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(61, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // gbPessoa
            // 
            this.gbPessoa.Controls.Add(this.rbJuridica);
            this.gbPessoa.Controls.Add(this.rbFisica);
            this.gbPessoa.Location = new System.Drawing.Point(6, 0);
            this.gbPessoa.Name = "gbPessoa";
            this.gbPessoa.Size = new System.Drawing.Size(600, 44);
            this.gbPessoa.TabIndex = 0;
            this.gbPessoa.TabStop = false;
            this.gbPessoa.Text = "Pessoa";
            // 
            // gbJuridica
            // 
            this.gbJuridica.Controls.Add(this.I2_INSCESTADUAL);
            this.gbJuridica.Controls.Add(this.label14);
            this.gbJuridica.Controls.Add(this.I2_RAZAOSOCIAL);
            this.gbJuridica.Controls.Add(this.label11);
            this.gbJuridica.Controls.Add(this.I2_CNPJ);
            this.gbJuridica.Controls.Add(this.label12);
            this.gbJuridica.Controls.Add(this.I2_INSCMUNICIPAL);
            this.gbJuridica.Controls.Add(this.label13);
            this.gbJuridica.Location = new System.Drawing.Point(6, 50);
            this.gbJuridica.Name = "gbJuridica";
            this.gbJuridica.Size = new System.Drawing.Size(600, 81);
            this.gbJuridica.TabIndex = 1;
            this.gbJuridica.TabStop = false;
            this.gbJuridica.Text = "Juridica";
            this.gbJuridica.Visible = false;
            // 
            // I2_INSCESTADUAL
            // 
            this.I2_INSCESTADUAL.Location = new System.Drawing.Point(220, 45);
            this.I2_INSCESTADUAL.MaxLength = 10;
            this.I2_INSCESTADUAL.Name = "I2_INSCESTADUAL";
            this.I2_INSCESTADUAL.Size = new System.Drawing.Size(146, 20);
            this.I2_INSCESTADUAL.TabIndex = 5;
            this.I2_INSCESTADUAL.Tag = "Inscrição Estadual";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(146, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "I. Estadual";
            // 
            // I2_RAZAOSOCIAL
            // 
            this.I2_RAZAOSOCIAL.Location = new System.Drawing.Point(82, 19);
            this.I2_RAZAOSOCIAL.MaxLength = 250;
            this.I2_RAZAOSOCIAL.Name = "I2_RAZAOSOCIAL";
            this.I2_RAZAOSOCIAL.Size = new System.Drawing.Size(284, 20);
            this.I2_RAZAOSOCIAL.TabIndex = 1;
            this.I2_RAZAOSOCIAL.Tag = "Razão Social";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Razão Social";
            // 
            // I2_CNPJ
            // 
            this.I2_CNPJ.Location = new System.Drawing.Point(448, 19);
            this.I2_CNPJ.Mask = "00.000.000/0000-00";
            this.I2_CNPJ.Name = "I2_CNPJ";
            this.I2_CNPJ.Size = new System.Drawing.Size(146, 20);
            this.I2_CNPJ.TabIndex = 3;
            this.I2_CNPJ.Tag = "CNPJ";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(373, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "CNPJ";
            // 
            // I2_INSCMUNICIPAL
            // 
            this.I2_INSCMUNICIPAL.Location = new System.Drawing.Point(448, 45);
            this.I2_INSCMUNICIPAL.MaxLength = 10;
            this.I2_INSCMUNICIPAL.Name = "I2_INSCMUNICIPAL";
            this.I2_INSCMUNICIPAL.Size = new System.Drawing.Size(146, 20);
            this.I2_INSCMUNICIPAL.TabIndex = 7;
            this.I2_INSCMUNICIPAL.Tag = "Inscrição Municipal";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(373, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "I. Municipal";
            // 
            // Cliente_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 348);
            this.Controls.Add(this.gbFisica);
            this.Controls.Add(this.gbPessoa);
            this.Controls.Add(this.gbButtom);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.gbJuridica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cliente_cad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbButtom.ResumeLayout(false);
            this.gbFisica.ResumeLayout(false);
            this.gbFisica.PerformLayout();
            this.gbPessoa.ResumeLayout(false);
            this.gbPessoa.PerformLayout();
            this.gbJuridica.ResumeLayout(false);
            this.gbJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox gbButtom;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox I2_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox I2_LOGRADOURO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox I2_NUMERO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox I2_COMPLEMENTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox I2_BAIRRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox I2_UF;
        private System.Windows.Forms.ComboBox I2_MUN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox I2_CPF;
        private System.Windows.Forms.TextBox I2_RG;
        private System.Windows.Forms.MaskedTextBox I2_CEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbFisica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.GroupBox gbPessoa;
        private System.Windows.Forms.GroupBox gbJuridica;
        private System.Windows.Forms.TextBox I2_RAZAOSOCIAL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox I2_CNPJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox I2_INSCMUNICIPAL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox I2_INSCESTADUAL;
        private System.Windows.Forms.Label label14;
    }
}