using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principal{
    public partial class Acerca : Form{
        public Acerca(){
            InitializeComponent();
        }
        private void lblReg_MouseHover(object sender, EventArgs e){
            lblReg.ForeColor = Color.Blue;
        }
        private void lblReg_MouseLeave(object sender, EventArgs e){
            lblReg.ForeColor = Color.Black;
        }
        private void lblReg_Click(object sender, EventArgs e){
            this.Dispose();
        }
        private void Acerca_Load(object sender, EventArgs e){
            lblAcerca.Visible = true;
        }
    }
}