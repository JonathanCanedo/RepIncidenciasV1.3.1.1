using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principal{
    public partial class Login : Form{
        int c = 0;
        public Login(){
            InitializeComponent();
        }
        private void entrar_Click(object sender, EventArgs e){
            acceder();
        }
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyValue == (char)Keys.Enter){
                acceder();
            }else{
            }
        }        
        private void btnSalir_Click(object sender, EventArgs e){
            DialogResult respuesta = MessageBox.Show("Desea Cerrar el sistema Reporte de Incidencias?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes){
                Application.Exit();
            }else{
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
                #region EnviarContraseña
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                msg.To.Add("jcanedoislas@gmail.com");//Para quien
                msg.Subject = "Nueva contraseña del Sistema de Incidencias";//Asunto
                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                msg.Body = nu;//msj
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress("15030371@itesa.edu.mx");//Quien lo envia

                System.Net.Mail.SmtpClient cl = new System.Net.Mail.SmtpClient();
                cl.Credentials = new System.Net.NetworkCredential("15030371@itesa.edu.mx", "jona.sagitario.95"); //usuario y contraseña

                cl.Port = 587;
                cl.EnableSsl = true;

                cl.Host = "smtp.gmail.com"; //Dominio

                try{
                    cl.Send(msg);
                    MessageBox.Show("Se envio la nueva contraseña al administrador por correo electronico");
                }catch (Exception ex){
                    MessageBox.Show("Error al enviar" + ex);
                }
                #endregion
            }
            catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void acceder(){
            MySqlConnection connStr = new MySqlConnection("SERVER=107.161.179.72;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            connStr.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();
            cmd.Connection = connStr;
            cmd.CommandText = "SELECT contraseña FROM user WHERE contraseña = '" + txtContraseña.Text + "'";
            MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read()) {
                    connStr.Close();
                    this.Hide();
                    Principal pr = new Principal();
                    pr.Show();
                } else {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c++;
                    if (c == 3) {
                        NuC();
                        inhab();
                        Cuenta cu = new Cuenta();
                        cu.Show();
                        cu.TopMost = true;
                        c = 0;
                    }
                txtContraseña.Focus();
            }
        }
        public void inhab(){
            txtContraseña.Enabled = false;
            btnSalir.Enabled = false;
            entrar.Enabled = false;
        }
    }
}