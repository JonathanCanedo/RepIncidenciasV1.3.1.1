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
    public partial class Principal : Form{
        public Principal(){
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e){
            lblFecha.Text = DateTime.Today.ToString("dd MMMM yyyy");
        }
        private void info_MouseHover(object sender, EventArgs e){
            info.ForeColor = Color.Blue;
        }
        private void info_MouseLeave(object sender, EventArgs e){
            info.ForeColor = Color.Black;
        }
        private void info_Click(object sender, EventArgs e){
            Acerca Ac = new Acerca();
            this.Hide();
            Ac.ShowDialog();
            this.Show();
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e){
            this.Dispose();
            Login log = new Login();
            log.Show();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e){
            CCon caContra = new CCon();
            this.Hide();
            caContra.ShowDialog();
        }
        private void reporteDeIncidenciaToolStripMenuItem_Click(object sender, EventArgs e){
            GRInc inc = new GRInc();
            this.Hide();
            inc.ShowDialog();
        }
        private void reporteIndividualToolStripMenuItem_Click(object sender, EventArgs e){
            GRIn ind = new GRIn();
            this.Hide();
            ind.ShowDialog();
        }
        private void reporteGrupalToolStripMenuItem_Click(object sender, EventArgs e){
            GRG rg = new GRG();
            this.Hide();
            rg.ShowDialog();
        }
        private void vizualizarToolStripMenuItem_Click(object sender, EventArgs e){
            Visualizar vi = new Visualizar();
            this.Hide();
            vi.ShowDialog();
        }
    }
}