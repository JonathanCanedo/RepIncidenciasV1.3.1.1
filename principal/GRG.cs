using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace principal{
    public partial class GRG : Form{
        string TipoFalta = "Especificada";
        int cant = 0;
        public GRG(){
            InitializeComponent();
        }
        private void btnRegresar_Click(object sender, EventArgs e){
            this.Dispose();
            Principal prin = new Principal();
            prin.Show();
        }
        private void GRG_Load(object sender, EventArgs e){
            lblFecha.Text = DateTime.Today.ToString("dd MMMM yyyy");
            nuevo();
        }
        private void btnCan_Click(object sender, EventArgs e){
            nuevo();
        }        
        private void btnGuard_Click(object sender, EventArgs e){
            if (txtG.Text != ""){
                buscar();
            }else{
                MessageBox.Show("Debe ingresar un grupo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtG.Focus();
            }
        }
        private void nuevo(){
            txtG.Text = "";
            txtG.Enabled = true;
            groupBox1.Enabled = true;
            chIn.Checked = false;
            chH.Checked = false;
            chD.Checked = false;
            chFalt.Checked = false;
            chCred.Checked = false;
            chLamp.Checked = false;
            txtOtr.Text = "[-- Ya especificado ---]";
            txtPers.Text = "";
            txtPerR.Text = "";
            dtpFecha.Value = DateTime.Today;
            comboBox1.SelectedIndex = 0;
            groupBox1.Enabled = true;
            btnGuard.Enabled = true;
            txtG.Enabled = true;
            comboBox1.Enabled = true;
        }
        public static bool Existe(string grupo){
            MySqlConnection conn = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            string query = "SELECT COUNT(*) FROM Alumnos WHERE grupo=@grupo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("grupo", grupo);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0){
                return false;
            }else{
                return true;
            }
        }
        private void buscar(){
            #region tipo
            TipoFalta = "";
            if (chCred.Checked == true){
                TipoFalta = TipoFalta + chCred.Text + ", ";
            }
            if (chH.Checked == true){
                TipoFalta = TipoFalta + chH.Text + ", ";
            }
            if (chIn.Checked == true){
                TipoFalta = TipoFalta + chIn.Text + ", ";
            }
            if (chFalt.Checked == true){
                TipoFalta = TipoFalta + chFalt.Text + ", ";
            }
            if (chLamp.Checked == true){
                TipoFalta = TipoFalta + chLamp.Text + ", ";
            }
            if (chD.Checked == true){
                TipoFalta = TipoFalta + chD.Text;
            }
            #endregion
            if (Existe(txtG.Text)){
                try{
                    MySqlCommand cmd;
                    MySqlConnection Con = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
                    if (chIn.Checked == false && chH.Checked == false && chFalt.Checked == false && chCred.Checked == false && chD.Checked == false && chLamp.Checked == false && txtOtr.Text == "[-- Ya especificado ---]" || chIn.Checked == false && chH.Checked == false && chFalt.Checked == false && chCred.Checked == false && chD.Checked == false && chLamp.Checked == false && txtOtr.Text == ""){
                        MessageBox.Show("Debe seleccionar al menos una incidencia grupal o especficarla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else {
                        using (cmd = new MySqlCommand("SELECT Rgrupal FROM Alumnos WHERE semestre = '" + comboBox1.Text + "' AND grupo ='" + txtG.Text + "'")){
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = Con;
                            Con.Open();
                            cant = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                            Con.Close();
                        }
                        cant++;

                        string consul = "UPDATE Alumnos SET Rgrupal=@Rgrupal WHERE semestre = '" + comboBox1.Text + "' AND grupo ='" + txtG.Text + "'";
                        cmd = new MySqlCommand(consul, Con);
                        cmd.Parameters.AddWithValue("@Rgrupal", cant);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        //grupo,fecha,incidencia,otros,fechaTrabajo,prefecto,quienRecibe 
                        string consu = "INSERT INTO repGrup (grupo,fecha,incidencia,otros,fechaTrabajo,prefecto,quienRecibe) VALUES(@grupo,@fecha,@incidencia,@otros,@fechaTrabajo,@prefecto,@quienRecibe)";
                        cmd = new MySqlCommand(consu, Con);
                        #region Datos
                        cmd.Parameters.AddWithValue("@grupo", comboBox1.Text+" "+txtG.Text);
                        cmd.Parameters.AddWithValue("@fecha", lblFecha.Text);
                        cmd.Parameters.AddWithValue("@incidencia", TipoFalta);
                        cmd.Parameters.AddWithValue("@otros", txtOtr.Text);
                        cmd.Parameters.AddWithValue("@fechaTrabajo", dtpFecha.Text);
                        cmd.Parameters.AddWithValue("@prefecto", txtPers.Text);
                        cmd.Parameters.AddWithValue("@quienRecibe", txtPerR.Text);
                        #endregion
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Se ha agregado el reporte individual a la Base de Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Enabled = false;
                        btnGuard.Enabled = false;
                        txtG.Enabled = false;
                        comboBox1.Enabled = false;
                    }
                }catch (Exception ex){
                    MessageBox.Show("Error: " + ex.Message);
                }
            }else{
                MessageBox.Show("El grupo ingresado no existe\nIngrese un grupo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nuevo();
            }
        }
    }
}