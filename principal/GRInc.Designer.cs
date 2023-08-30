namespace principal
{
    partial class GRInc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRInc));
            this.btnBusc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.chZap = new System.Windows.Forms.CheckBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.chPant = new System.Windows.Forms.CheckBox();
            this.btnGuard = new System.Windows.Forms.Button();
            this.chPlayDep = new System.Windows.Forms.CheckBox();
            this.chPlay = new System.Windows.Forms.CheckBox();
            this.chPants = new System.Windows.Forms.CheckBox();
            this.chSuet = new System.Windows.Forms.CheckBox();
            this.chCred = new System.Windows.Forms.CheckBox();
            this.gBA = new System.Windows.Forms.GroupBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.gBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusc
            // 
            this.btnBusc.Location = new System.Drawing.Point(233, 14);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(58, 21);
            this.btnBusc.TabIndex = 1;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Matricula:";
            // 
            // LB
            // 
            this.LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 18;
            this.LB.Location = new System.Drawing.Point(104, 39);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(268, 148);
            this.LB.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegresar);
            this.groupBox2.Controls.Add(this.chZap);
            this.groupBox2.Controls.Add(this.btncancel);
            this.groupBox2.Controls.Add(this.chPant);
            this.groupBox2.Controls.Add(this.btnGuard);
            this.groupBox2.Controls.Add(this.chPlayDep);
            this.groupBox2.Controls.Add(this.chPlay);
            this.groupBox2.Controls.Add(this.chPants);
            this.groupBox2.Controls.Add(this.chSuet);
            this.groupBox2.Controls.Add(this.chCred);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 103);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de incidencia: ";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(292, 70);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 25);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // chZap
            // 
            this.chZap.AutoSize = true;
            this.chZap.Location = new System.Drawing.Point(221, 49);
            this.chZap.Name = "chZap";
            this.chZap.Size = new System.Drawing.Size(65, 17);
            this.chZap.TabIndex = 7;
            this.chZap.Text = "Zapatos";
            this.chZap.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(292, 41);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(78, 25);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // chPant
            // 
            this.chPant.AutoSize = true;
            this.chPant.Location = new System.Drawing.Point(12, 29);
            this.chPant.Name = "chPant";
            this.chPant.Size = new System.Drawing.Size(98, 17);
            this.chPant.TabIndex = 2;
            this.chPant.Text = "Pantalón Diario";
            this.chPant.UseVisualStyleBackColor = true;
            // 
            // btnGuard
            // 
            this.btnGuard.Location = new System.Drawing.Point(292, 10);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(78, 25);
            this.btnGuard.TabIndex = 9;
            this.btnGuard.Text = "Guardar";
            this.btnGuard.UseVisualStyleBackColor = true;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // chPlayDep
            // 
            this.chPlayDep.AutoSize = true;
            this.chPlayDep.Location = new System.Drawing.Point(115, 49);
            this.chPlayDep.Name = "chPlayDep";
            this.chPlayDep.Size = new System.Drawing.Size(108, 17);
            this.chPlayDep.TabIndex = 6;
            this.chPlayDep.Text = "Playera deportiva";
            this.chPlayDep.UseVisualStyleBackColor = true;
            // 
            // chPlay
            // 
            this.chPlay.AutoSize = true;
            this.chPlay.Location = new System.Drawing.Point(115, 29);
            this.chPlay.Name = "chPlay";
            this.chPlay.Size = new System.Drawing.Size(91, 17);
            this.chPlay.TabIndex = 3;
            this.chPlay.Text = "Playera Diario";
            this.chPlay.UseVisualStyleBackColor = true;
            // 
            // chPants
            // 
            this.chPants.AutoSize = true;
            this.chPants.Location = new System.Drawing.Point(222, 29);
            this.chPants.Name = "chPants";
            this.chPants.Size = new System.Drawing.Size(53, 17);
            this.chPants.TabIndex = 4;
            this.chPants.Text = "Pants";
            this.chPants.UseVisualStyleBackColor = true;
            // 
            // chSuet
            // 
            this.chSuet.AutoSize = true;
            this.chSuet.Location = new System.Drawing.Point(12, 52);
            this.chSuet.Name = "chSuet";
            this.chSuet.Size = new System.Drawing.Size(57, 17);
            this.chSuet.TabIndex = 5;
            this.chSuet.Text = "Súeter";
            this.chSuet.UseVisualStyleBackColor = true;
            // 
            // chCred
            // 
            this.chCred.AutoSize = true;
            this.chCred.Location = new System.Drawing.Point(12, 75);
            this.chCred.Name = "chCred";
            this.chCred.Size = new System.Drawing.Size(76, 17);
            this.chCred.TabIndex = 8;
            this.chCred.Text = "Credencial";
            this.chCred.UseVisualStyleBackColor = true;
            // 
            // gBA
            // 
            this.gBA.Controls.Add(this.txtMat);
            this.gBA.Controls.Add(this.LB);
            this.gBA.Controls.Add(this.pbFoto);
            this.gBA.Controls.Add(this.label4);
            this.gBA.Controls.Add(this.btnBusc);
            this.gBA.Location = new System.Drawing.Point(12, 24);
            this.gBA.Name = "gBA";
            this.gBA.Size = new System.Drawing.Size(376, 165);
            this.gBA.TabIndex = 66;
            this.gBA.TabStop = false;
            this.gBA.Text = "Alumno: ";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(84, 15);
            this.txtMat.MaxLength = 14;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(143, 20);
            this.txtMat.TabIndex = 0;
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMat_KeyPress);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Location = new System.Drawing.Point(6, 39);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(88, 93);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 54;
            this.pbFoto.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(230, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 67;
            this.lblFecha.Text = "Fecha";
            // 
            // GRInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(402, 309);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gBA);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GRInc";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRInc";
            this.Load += new System.EventHandler(this.GRInc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gBA.ResumeLayout(false);
            this.gBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chZap;
        private System.Windows.Forms.CheckBox chPant;
        private System.Windows.Forms.CheckBox chPlayDep;
        private System.Windows.Forms.CheckBox chPlay;
        private System.Windows.Forms.CheckBox chPants;
        private System.Windows.Forms.CheckBox chSuet;
        private System.Windows.Forms.CheckBox chCred;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnGuard;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gBA;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMat;
    }
}