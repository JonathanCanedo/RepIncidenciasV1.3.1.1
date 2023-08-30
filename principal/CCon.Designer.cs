namespace principal
{
    partial class CCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCon));
            this.gB = new System.Windows.Forms.GroupBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.txtConA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB2 = new System.Windows.Forms.GroupBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.txtConN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gB.SuspendLayout();
            this.gB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB
            // 
            this.gB.Controls.Add(this.lblCont);
            this.gB.Controls.Add(this.txtConA);
            this.gB.Controls.Add(this.label3);
            this.gB.Controls.Add(this.label1);
            this.gB.Location = new System.Drawing.Point(12, 12);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(203, 87);
            this.gB.TabIndex = 6;
            this.gB.TabStop = false;
            this.gB.Text = "Contraseña Actual";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.BackColor = System.Drawing.Color.Transparent;
            this.lblCont.Location = new System.Drawing.Point(122, 64);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(52, 13);
            this.lblCont.TabIndex = 5;
            this.lblCont.Text = "Continuar";
            this.lblCont.Click += new System.EventHandler(this.lblCont_Click);
            this.lblCont.MouseLeave += new System.EventHandler(this.lblCont_MouseLeave);
            this.lblCont.MouseHover += new System.EventHandler(this.lblCont_MouseHover);
            // 
            // txtConA
            // 
            this.txtConA.Location = new System.Drawing.Point(97, 42);
            this.txtConA.Name = "txtConA";
            this.txtConA.PasswordChar = '*';
            this.txtConA.Size = new System.Drawing.Size(100, 20);
            this.txtConA.TabIndex = 4;
            this.txtConA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: Administrador";
            // 
            // gB2
            // 
            this.gB2.Controls.Add(this.lblGuardar);
            this.gB2.Controls.Add(this.txtConN);
            this.gB2.Controls.Add(this.label4);
            this.gB2.Controls.Add(this.label2);
            this.gB2.Location = new System.Drawing.Point(12, 12);
            this.gB2.Name = "gB2";
            this.gB2.Size = new System.Drawing.Size(203, 86);
            this.gB2.TabIndex = 7;
            this.gB2.TabStop = false;
            this.gB2.Text = "Nueva Contraseña";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(122, 64);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(45, 13);
            this.lblGuardar.TabIndex = 4;
            this.lblGuardar.Text = "Guardar";
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            this.lblGuardar.MouseLeave += new System.EventHandler(this.lblGuardar_MouseLeave);
            this.lblGuardar.MouseHover += new System.EventHandler(this.lblGuardar_MouseHover);
            // 
            // txtConN
            // 
            this.txtConN.Location = new System.Drawing.Point(97, 41);
            this.txtConN.Name = "txtConN";
            this.txtConN.Size = new System.Drawing.Size(100, 20);
            this.txtConN.TabIndex = 3;
            this.txtConN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario: Administrador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(222, 139);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gB2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CCon";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCon";
            this.Load += new System.EventHandler(this.CCon_Load);
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            this.gB2.ResumeLayout(false);
            this.gB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.TextBox txtConA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB2;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.TextBox txtConN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}