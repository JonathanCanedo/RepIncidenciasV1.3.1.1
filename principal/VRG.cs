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
    public partial class VRG : Form{
        public VRG(){
            InitializeComponent();
        }
        private void VRG_Load(object sender, EventArgs e){
            lblFecha.Text = DateTime.Today.ToString("dd MMMM yyyy");
        }
        private void btnRegresar_Click(object sender, EventArgs e){
            this.Dispose();
            Principal prin = new Principal();
            prin.Show();
        }
    }
}