using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principal
{
    public partial class Load : Form{
        public Load(){
            InitializeComponent();
        }
        public void Barra(){
            progressBar1.Increment(1);
            lbl3.Text = progressBar1.Value.ToString() + " %";
            if (progressBar1.Value == progressBar1.Maximum){
                timer1.Stop();
                this.Hide();
                Login prin = new Login();
                prin.Show();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e){
            Barra();
        }
        private void Load_Load(object sender, EventArgs e){
            lbl3.BackColor = Color.Transparent;
            timer1.Start();
        }
    }
}