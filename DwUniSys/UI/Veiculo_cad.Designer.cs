namespace UI
{
    partial class Veiculo_cad
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.I3_UF = new System.Windows.Forms.ComboBox();
            this.I3_MUN = new System.Windows.Forms.ComboBox();
            this.gbButtom = new System.Windows.Forms.GroupBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.I3_CATEGORIA = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.I3_TIPO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.I3_COR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.I3_MODELO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.I3_MARCA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.I3_RENAVAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.I3_CHASSI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.I3_PLACA = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbButtom.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(240, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Município";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "UF";
            // 
            // I3_UF
            // 
            this.I3_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I3_UF.FormattingEnabled = true;
            this.I3_UF.Location = new System.Drawing.Point(82, 123);
            this.I3_UF.Name = "I3_UF";
            this.I3_UF.Size = new System.Drawing.Size(146, 21);
            this.I3_UF.TabIndex = 17;
            this.I3_UF.SelectedValueChanged += new System.EventHandler(this.I2_UF_SelectedValueChanged);
            // 
            // I3_MUN
            // 
            this.I3_MUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I3_MUN.FormattingEnabled = true;
            this.I3_MUN.Location = new System.Drawing.Point(310, 123);
            this.I3_MUN.Name = "I3_MUN";
            this.I3_MUN.Size = new System.Drawing.Size(284, 21);
            this.I3_MUN.TabIndex = 19;
            // 
            // gbButtom
            // 
            this.gbButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtom.Controls.Add(this.btn_Confirmar);
            this.gbButtom.Controls.Add(this.btn_Cancelar);
            this.gbButtom.Location = new System.Drawing.Point(6, 197);
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
            // gbDados
            // 
            this.gbDados.Controls.Add(this.I3_CATEGORIA);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.label15);
            this.gbDados.Controls.Add(this.I3_UF);
            this.gbDados.Controls.Add(this.I3_TIPO);
            this.gbDados.Controls.Add(this.I3_MUN);
            this.gbDados.Controls.Add(this.label14);
            this.gbDados.Controls.Add(this.I3_COR);
            this.gbDados.Controls.Add(this.label13);
            this.gbDados.Controls.Add(this.I3_MODELO);
            this.gbDados.Controls.Add(this.label11);
            this.gbDados.Controls.Add(this.I3_MARCA);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.I3_RENAVAM);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.I3_CHASSI);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.I3_PLACA);
            this.gbDados.Controls.Add(this.label12);
            this.gbDados.Location = new System.Drawing.Point(6, 2);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(600, 193);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // I3_CATEGORIA
            // 
            this.I3_CATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I3_CATEGORIA.FormattingEnabled = true;
            this.I3_CATEGORIA.Items.AddRange(new object[] {
            "Particular",
            "Aluguel",
            "Oficial",
            "Diplomático",
            "Aprendizagem"});
            this.I3_CATEGORIA.Location = new System.Drawing.Point(448, 97);
            this.I3_CATEGORIA.Name = "I3_CATEGORIA";
            this.I3_CATEGORIA.Size = new System.Drawing.Size(146, 21);
            this.I3_CATEGORIA.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(373, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Categoria";
            // 
            // I3_TIPO
            // 
            this.I3_TIPO.Location = new System.Drawing.Point(448, 71);
            this.I3_TIPO.MaxLength = 10;
            this.I3_TIPO.Name = "I3_TIPO";
            this.I3_TIPO.Size = new System.Drawing.Size(146, 20);
            this.I3_TIPO.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(373, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tipo";
            // 
            // I3_COR
            // 
            this.I3_COR.Location = new System.Drawing.Point(448, 45);
            this.I3_COR.MaxLength = 10;
            this.I3_COR.Name = "I3_COR";
            this.I3_COR.Size = new System.Drawing.Size(146, 20);
            this.I3_COR.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(373, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cor";
            // 
            // I3_MODELO
            // 
            this.I3_MODELO.Location = new System.Drawing.Point(82, 97);
            this.I3_MODELO.MaxLength = 100;
            this.I3_MODELO.Name = "I3_MODELO";
            this.I3_MODELO.Size = new System.Drawing.Size(284, 20);
            this.I3_MODELO.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Modelo";
            // 
            // I3_MARCA
            // 
            this.I3_MARCA.Location = new System.Drawing.Point(82, 71);
            this.I3_MARCA.MaxLength = 100;
            this.I3_MARCA.Name = "I3_MARCA";
            this.I3_MARCA.Size = new System.Drawing.Size(284, 20);
            this.I3_MARCA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // I3_RENAVAM
            // 
            this.I3_RENAVAM.Location = new System.Drawing.Point(82, 45);
            this.I3_RENAVAM.MaxLength = 100;
            this.I3_RENAVAM.Name = "I3_RENAVAM";
            this.I3_RENAVAM.Size = new System.Drawing.Size(284, 20);
            this.I3_RENAVAM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "RENAVAM";
            // 
            // I3_CHASSI
            // 
            this.I3_CHASSI.Location = new System.Drawing.Point(309, 19);
            this.I3_CHASSI.MaxLength = 100;
            this.I3_CHASSI.Name = "I3_CHASSI";
            this.I3_CHASSI.Size = new System.Drawing.Size(284, 20);
            this.I3_CHASSI.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(245, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chassi";
            // 
            // I3_PLACA
            // 
            this.I3_PLACA.Location = new System.Drawing.Point(82, 19);
            this.I3_PLACA.Mask = "AAA-0000";
            this.I3_PLACA.Name = "I3_PLACA";
            this.I3_PLACA.Size = new System.Drawing.Size(146, 20);
            this.I3_PLACA.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(18, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Placa";
            // 
            // Veiculo_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 246);
            this.Controls.Add(this.gbButtom);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Veiculo_cad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículo";
            this.gbButtom.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbButtom;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox I3_UF;
        private System.Windows.Forms.ComboBox I3_MUN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.MaskedTextBox I3_PLACA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox I3_RENAVAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox I3_CHASSI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox I3_MODELO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox I3_MARCA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox I3_TIPO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox I3_COR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox I3_CATEGORIA;
    }
}