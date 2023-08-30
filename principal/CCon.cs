using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace principal{
    public partial class CCon : Form{
        int c = 0;
        public CCon(){
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e){
            gB2.Visible = false;
            txtConN.Text = "";
            Principal prin = new Principal();
            this.Dispose();
            prin.ShowDialog();
        }
        private void CCon_Load(object sender, EventArgs e){
            gB.Visible = true;
            gB2.Visible = false;
        }
        //Comprobor
        private void txtConA_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == (char)Keys.Enter){
                log();
            }else {}
        }
        private void lblCont_MouseHover(object sender, EventArgs e){
            lblCont.ForeColor = Color.DarkCyan;
        }
        private void lblCont_MouseLeave(object sender, EventArgs e){
            lblCont.ForeColor = Color.Black;
        }
        private void lblCont_Click(object sender, EventArgs e){
            log();
        }
        //Guardar
        private void txtConN_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == (char)Keys.Enter){
                gB.Enabled = true;
                val();
                this.Close();
                Principal prin = new Principal();
                prin.Show();
            }else { }
        }
        private void lblGuardar_MouseHover(object sender, EventArgs e){
            lblGuardar.ForeColor = Color.DarkCyan;
        }
        private void lblGuardar_MouseLeave(object sender, EventArgs e){
            lblGuardar.ForeColor = Color.Black;
        }
        private void lblGuardar_Click(object sender, EventArgs e){
            gB.Enabled = true;
            val();
            this.Close();
            Principal prin = new Principal();
            prin.Show();
        }
        public void cerrar(){
            if (c == 3){
                NuC();
                Cuenta cu = new Cuenta();
                inh();
                cu.Show();
                cu.TopMost = true;
            }
        }
        public void inh(){
            txtConA.Enabled = false;
            button1.Enabled = false;
            lblCont.Enabled = false;
        }
        public void log(){
            MySqlConnection connStr = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            connStr.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();
            cmd.Connection = connStr;
            cmd.CommandText = "SELECT contraseña FROM user WHERE contraseña = '" + txtConA.Text + "'";
            MySqlDataReader leer = cmd.ExecuteReader();
            if (txtConA.Text != "" && leer.Read()){
                txtConA.Enabled = false;
                lblCont.Enabled = false;
                gB.Visible = false;
                gB2.Visible = true;
                txtConN.Focus();
            } else{
                MessageBox.Show("Contraseña erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConA.Text = "";
                c++;                
                gB.Visible = true;
                gB2.Visible = false;
                cerrar();
                txtConA.Focus();
            }
            connStr.Close();
        }
        public void ed(){            
            MySqlConnection connStr = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            MySqlCommand cmd = new MySqlCommand();
            //Com.Parameters["@Contraseña"].Value = txtConN.Text;
            if (txtConN.Text == ""){
                MessageBox.Show("El campo nombre no puede ir en blanco");
                txtConN.Focus();
            }else{
                try{
                    connStr.Open();
                    string consul = "UPDATE user SET id='1',usuario='Administrador',contraseña ='" + txtConN.Text + "' WHERE id = '1'";
                    cmd = new MySqlCommand(consul, connStr);
                    cmd.ExecuteNonQuery();
                    connStr.Close();
                    MessageBox.Show("La contraseña se modifico con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch (Exception ex){
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
                
        }
        public void val(){
            if ((txtConA.Text).Equals(txtConN.Text)){
                MessageBox.Show("La nueva contraseña no puede ser la antigua contraseña", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                ed();
            }
        }
        private void NuC(){
            string n = "!#$12345%&/()=?¡\'+*{}[]-aABbCcKkLlMmNnOoPpQqRrSsDdEeFfGgHhIiJj06789TtUuVvWwXxYyZz_.;:,<>";
            Random r = new Random();
            int a = r.Next(0, n.Length);
            string cadena = n.Substring(a, 10);
            string nu = cadena;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection connStr = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            try{
                connStr.Open();
                string consul = "UPDATE user SET contraseña ='" + nu + "' WHERE id = '1'";
                cmd = new MySqlCommand(consul, connStr);
                cmd.ExecuteNonQuery();
                connStr.Close();
            }catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}