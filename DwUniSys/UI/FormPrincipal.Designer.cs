namespace UI
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tbInicio = new System.Windows.Forms.TabPage();
            this.gbButtom = new System.Windows.Forms.GroupBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passageiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fretamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.tbInicio.SuspendLayout();
            this.gbButtom.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tbInicio);
            this.TabControl.Location = new System.Drawing.Point(5, 26);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(960, 517);
            this.TabControl.TabIndex = 0;
            // 
            // tbInicio
            // 
            this.tbInicio.Controls.Add(this.GMapControl);
            this.tbInicio.Location = new System.Drawing.Point(4, 22);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbInicio.Size = new System.Drawing.Size(952, 491);
            this.tbInicio.TabIndex = 0;
            this.tbInicio.Text = "Início";
            this.tbInicio.UseVisualStyleBackColor = true;
            // 
            // gbButtom
            // 
            this.gbButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbButtom.Controls.Add(this.btn_Fechar);
            this.gbButtom.Location = new System.Drawing.Point(5, 544);
            this.gbButtom.Name = "gbButtom";
            this.gbButtom.Size = new System.Drawing.Size(960, 44);
            this.gbButtom.TabIndex = 2;
            this.gbButtom.TabStop = false;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Location = new System.Drawing.Point(854, 10);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_Fechar.TabIndex = 1;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.fretamentoToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(969, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.passageiroToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.condutorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // passageiroToolStripMenuItem
            // 
            this.passageiroToolStripMenuItem.Name = "passageiroToolStripMenuItem";
            this.passageiroToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.passageiroToolStripMenuItem.Text = "Passageiro";
            this.passageiroToolStripMenuItem.Click += new System.EventHandler(this.passageiroToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // condutorToolStripMenuItem
            // 
            this.condutorToolStripMenuItem.Name = "condutorToolStripMenuItem";
            this.condutorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.condutorToolStripMenuItem.Text = "Condutor";
            this.condutorToolStripMenuItem.Click += new System.EventHandler(this.condutorToolStripMenuItem_Click);
            // 
            // fretamentoToolStripMenuItem
            // 
            this.fretamentoToolStripMenuItem.Name = "fretamentoToolStripMenuItem";
            this.fretamentoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fretamentoToolStripMenuItem.Text = "Fretamento";
            this.fretamentoToolStripMenuItem.Click += new System.EventHandler(this.fretamentoToolStripMenuItem_Click);
            // 
            // GMapControl
            // 
            this.GMapControl.Bearing = 0F;
            this.GMapControl.CanDragMap = true;
            this.GMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapControl.GrayScaleMode = false;
            this.GMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapControl.LevelsKeepInMemmory = 5;
            this.GMapControl.Location = new System.Drawing.Point(3, 3);
            this.GMapControl.MarkersEnabled = true;
            this.GMapControl.MaxZoom = 2;
            this.GMapControl.MinZoom = 2;
            this.GMapControl.MouseWheelZoomEnabled = true;
            this.GMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapControl.Name = "GMapControl";
            this.GMapControl.NegativeMode = false;
            this.GMapControl.PolygonsEnabled = true;
            this.GMapControl.RetryLoadTile = 0;
            this.GMapControl.RoutesEnabled = true;
            this.GMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapControl.ShowTileGridLines = false;
            this.GMapControl.Size = new System.Drawing.Size(946, 485);
            this.GMapControl.TabIndex = 0;
            this.GMapControl.Zoom = 0D;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 30000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(969, 592);
            this.Controls.Add(this.gbButtom);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Fretamento";
            this.TabControl.ResumeLayout(false);
            this.tbInicio.ResumeLayout(false);
            this.gbButtom.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tbInicio;
        private System.Windows.Forms.GroupBox gbButtom;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passageiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fretamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condutorToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl GMapControl;
        private System.Windows.Forms.Timer Timer;
    }
}

