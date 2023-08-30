namespace principal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGrupalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFecha.Location = new System.Drawing.Point(329, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 52;
            this.lblFecha.Text = "Fecha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.vizualizarToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeIncidenciaToolStripMenuItem,
            this.reporteIndividualToolStripMenuItem,
            this.reporteGrupalToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // reporteDeIncidenciaToolStripMenuItem
            // 
            this.reporteDeIncidenciaToolStripMenuItem.Name = "reporteDeIncidenciaToolStripMenuItem";
            this.reporteDeIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeIncidenciaToolStripMenuItem.Text = "Reporte de incidencia";
            this.reporteDeIncidenciaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeIncidenciaToolStripMenuItem_Click);
            // 
            // reporteIndividualToolStripMenuItem
            // 
            this.reporteIndividualToolStripMenuItem.Name = "reporteIndividualToolStripMenuItem";
            this.reporteIndividualToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteIndividualToolStripMenuItem.Text = "Reporte individual";
            this.reporteIndividualToolStripMenuItem.Click += new System.EventHandler(this.reporteIndividualToolStripMenuItem_Click);
            // 
            // reporteGrupalToolStripMenuItem
            // 
            this.reporteGrupalToolStripMenuItem.Name = "reporteGrupalToolStripMenuItem";
            this.reporteGrupalToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteGrupalToolStripMenuItem.Text = "Reporte grupal";
            this.reporteGrupalToolStripMenuItem.Click += new System.EventHandler(this.reporteGrupalToolStripMenuItem_Click);
            // 
            // vizualizarToolStripMenuItem
            // 
            this.vizualizarToolStripMenuItem.Name = "vizualizarToolStripMenuItem";
            this.vizualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.vizualizarToolStripMenuItem.Text = "Visualizar";
            this.vizualizarToolStripMenuItem.Click += new System.EventHandler(this.vizualizarToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Location = new System.Drawing.Point(352, 247);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(85, 13);
            this.info.TabIndex = 55;
            this.info.Text = "Mas Información";
            this.info.Click += new System.EventHandler(this.info_Click);
            this.info.MouseLeave += new System.EventHandler(this.info_MouseLeave);
            this.info.MouseHover += new System.EventHandler(this.info_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::principal.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(440, 269);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ToolStripMenuItem reporteDeIncidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGrupalToolStripMenuItem;
    }
}