namespace UI
{
    partial class Passageiro_cad
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
            this.I0_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.I0_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.I0_UF = new System.Windows.Forms.ComboBox();
            this.I0_MUN = new System.Windows.Forms.ComboBox();
            this.I0_COMPLEMENTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.I0_BAIRRO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.I0_LOGRADOURO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.I0_NUMERO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.I0_RG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.I0_NOME = new System.Windows.Forms.TextBox();
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
            this.gbDados.Controls.Add(this.I0_CEP);
            this.gbDados.Controls.Add(this.label10);
            this.gbDados.Controls.Add(this.I0_CPF);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.I0_UF);
            this.gbDados.Controls.Add(this.I0_MUN);
            this.gbDados.Controls.Add(this.I0_COMPLEMENTO);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.I0_BAIRRO);
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.I0_LOGRADOURO);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.I0_NUMERO);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.I0_RG);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.I0_NOME);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Location = new System.Drawing.Point(6, 2);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(600, 189);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // I0_CEP
            // 
            this.I0_CEP.Location = new System.Drawing.Point(82, 49);
            this.I0_CEP.Mask = "00000-000";
            this.I0_CEP.Name = "I0_CEP";
            this.I0_CEP.Size = new System.Drawing.Size(146, 20);
            this.I0_CEP.TabIndex = 5;
            this.I0_CEP.Leave += new System.EventHandler(this.I0_CEP_Leave);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "CEP";
            // 
            // I0_CPF
            // 
            this.I0_CPF.Location = new System.Drawing.Point(448, 23);
            this.I0_CPF.Mask = "000.000.000-00";
            this.I0_CPF.Name = "I0_CPF";
            this.I0_CPF.Size = new System.Drawing.Size(146, 20);
            this.I0_CPF.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(240, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Município";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "UF";
            // 
            // I0_UF
            // 
            this.I0_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I0_UF.FormattingEnabled = true;
            this.I0_UF.Location = new System.Drawing.Point(82, 127);
            this.I0_UF.Name = "I0_UF";
            this.I0_UF.Size = new System.Drawing.Size(146, 21);
            this.I0_UF.TabIndex = 17;
            this.I0_UF.SelectedValueChanged += new System.EventHandler(this.I0_UF_SelectedValueChanged);
            // 
            // I0_MUN
            // 
            this.I0_MUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I0_MUN.FormattingEnabled = true;
            this.I0_MUN.Location = new System.Drawing.Point(310, 127);
            this.I0_MUN.Name = "I0_MUN";
            this.I0_MUN.Size = new System.Drawing.Size(284, 21);
            this.I0_MUN.TabIndex = 19;
            // 
            // I0_COMPLEMENTO
            // 
            this.I0_COMPLEMENTO.Location = new System.Drawing.Point(448, 101);
            this.I0_COMPLEMENTO.MaxLength = 50;
            this.I0_COMPLEMENTO.Name = "I0_COMPLEMENTO";
            this.I0_COMPLEMENTO.Size = new System.Drawing.Size(146, 20);
            this.I0_COMPLEMENTO.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(373, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Complemento";
            // 
            // I0_BAIRRO
            // 
            this.I0_BAIRRO.Location = new System.Drawing.Point(82, 101);
            this.I0_BAIRRO.MaxLength = 100;
            this.I0_BAIRRO.Name = "I0_BAIRRO";
            this.I0_BAIRRO.Size = new System.Drawing.Size(284, 20);
            this.I0_BAIRRO.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bairro";
            // 
            // I0_LOGRADOURO
            // 
            this.I0_LOGRADOURO.Location = new System.Drawing.Point(82, 75);
            this.I0_LOGRADOURO.MaxLength = 100;
            this.I0_LOGRADOURO.Name = "I0_LOGRADOURO";
            this.I0_LOGRADOURO.Size = new System.Drawing.Size(284, 20);
            this.I0_LOGRADOURO.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Logradouro";
            // 
            // I0_NUMERO
            // 
            this.I0_NUMERO.Location = new System.Drawing.Point(448, 75);
            this.I0_NUMERO.MaxLength = 10;
            this.I0_NUMERO.Name = "I0_NUMERO";
            this.I0_NUMERO.Size = new System.Drawing.Size(146, 20);
            this.I0_NUMERO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(373, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Número";
            // 
            // I0_RG
            // 
            this.I0_RG.Location = new System.Drawing.Point(448, 49);
            this.I0_RG.MaxLength = 10;
            this.I0_RG.Name = "I0_RG";
            this.I0_RG.Size = new System.Drawing.Size(146, 20);
            this.I0_RG.TabIndex = 7;
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
            // I0_NOME
            // 
            this.I0_NOME.Location = new System.Drawing.Point(82, 23);
            this.I0_NOME.MaxLength = 250;
            this.I0_NOME.Name = "I0_NOME";
            this.I0_NOME.Size = new System.Drawing.Size(284, 20);
            this.I0_NOME.TabIndex = 1;
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
            this.gbButtom.Location = new System.Drawing.Point(6, 191);
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
            // Passageiro_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 240);
            this.Controls.Add(this.gbButtom);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Passageiro_cad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passageiro";
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
        private System.Windows.Forms.TextBox I0_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox I0_LOGRADOURO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox I0_NUMERO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox I0_COMPLEMENTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox I0_BAIRRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox I0_UF;
        private System.Windows.Forms.ComboBox I0_MUN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox I0_CPF;
        private System.Windows.Forms.TextBox I0_RG;
        private System.Windows.Forms.MaskedTextBox I0_CEP;
        private System.Windows.Forms.Label label10;
    }
}