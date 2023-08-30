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
    public partial class Cuenta : Form{
        public Cuenta(){
            InitializeComponent();
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e){
            i--;
            label1.Text = i.ToString() + " segundos";
            if (i == 0){
                Application.Exit();
            }
        }
    }
}