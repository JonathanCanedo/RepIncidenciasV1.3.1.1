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
using System.IO;
using System.Threading;

namespace principal{
    public partial class GRInc : Form{
        string nomb = "",ap="",gpo="",TipoFalta = "Especificada", mat = "";
        int cant = 0,sem=0;
        public GRInc(){
            InitializeComponent();
        }
        private void GRInc_Load(object sender, EventArgs e){            
            lblFecha.Text = DateTime.Today.ToString("dd MMMM yyyy");
            txtMat.Clear();
            txtMat.Focus();
            #region inhabilitar
            LB.Enabled = false;
            chCred.Enabled = false;
            chSuet.Enabled = false;
            chPants.Enabled = false;
            chPlay.Enabled = false;
            chPlayDep.Enabled = false;
            chPant.Enabled = false;
            chZap.Enabled = false;
            btnGuard.Enabled = false;
            btncancel.Enabled = false;
            #endregion
        }
        private void btnRegresar_Click(object sender, EventArgs e){
            this.Dispose();
            Principal prin = new Principal();
            prin.Show();
        }
        private void btnBusc_Click(object sender, EventArgs e){
            if (txtMat.Text!="") {
                buscar();                                
            }else{
                MessageBox.Show("Debe ingresar una matricula", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMat.Focus();
            }
        }
        private void btncancel_Click(object sender, EventArgs e){
            pbFoto.Image = null;
            LB.Items.Clear();
            txtMat.Enabled = true;
            btnBusc.Enabled = true;
            txtMat.Focus();
            chCred.Checked = false;
            chSuet.Checked = false;
            chPants.Checked = false;
            chPlay.Checked = false;
            chPlayDep.Checked = false;
            chPant.Checked = false;
            chZap.Checked = false;
            inh();
            txtMat.Clear();
            txtMat.Focus();
        }
        private void txtMat_KeyPress(object sender, KeyPressEventArgs e){
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void buscar(){
            if (Existe(txtMat.Text)){
                try{
                    MySqlConnection connStr = new MySqlConnection("SERVER=107.161.179.72;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
                    MySqlCommand cmd = new MySqlCommand("SELECT nombres,apellidos,matricula,semestre,grupo,incidencia,Rindividual,Rgrupal FROM Alumnos WHERE matricula ='" + txtMat.Text + "'", connStr);
                    connStr.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows){
                        while (dr.Read()){
                            nomb = dr.GetString(0);
                            ap = dr.GetString(1);
                            mat = dr.GetString(2);
                            sem = Convert.ToInt32(dr.GetString(3));
                            gpo = dr.GetString(4);
                            this.LB.Items.Add("Nombre: " + nomb + " " + ap);
                            this.LB.Items.Add("Matricula: " + mat);
                            this.LB.Items.Add("Semestre: " + sem);
                            this.LB.Items.Add("Grupo: " + gpo);
                            this.LB.Items.Add("Incidencias: " + dr.GetString(5));
                            this.LB.Items.Add("Reportes individuales: " + dr.GetString(6));
                            this.LB.Items.Add("Reportes Grupales: " + dr.GetString(7));
                        }
                    }
                    connStr.Close();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT foto FROM Alumnos WHERE matricula ='" + txtMat.Text + "'", connStr);
                    connStr.Open();
                    MySqlDataAdapter dp = new MySqlDataAdapter(cmd1);
                    DataSet ds = new DataSet("Alumnos");

                    byte[] Misdatos = new byte[0];
                    dp.Fill(ds, "Alumnos");

                    DataRow myRow = ds.Tables["Alumnos"].Rows[0];
                    Misdatos = (byte[])myRow["foto"];
                    MemoryStream ms = new MemoryStream(Misdatos);
                    pbFoto.Image = Image.FromStream(ms);
                    connStr.Close();

                    #region habilitar
                    chCred.Enabled = true;
                    chSuet.Enabled = true;
                    chPants.Enabled = true;
                    chPlay.Enabled = true;
                    chPlayDep.Enabled = true;
                    chPant.Enabled = true;
                    chZap.Enabled = true;
                    btnGuard.Enabled = true;
                    btncancel.Enabled = true;
                    #endregion
                    LB.Enabled = true;
                    txtMat.Enabled = false;
                    btnBusc.Enabled = false;
                }catch(Exception ex){
                    MessageBox.Show("Error: " + ex.Message);
                }
            }else {
                MessageBox.Show("La matrícula ingresada no existe\nIngrese una matrícula valida", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                #region habilitar
                chCred.Enabled = false;
                chSuet.Enabled = false;
                chPants.Enabled = false;
                chPlay.Enabled = false;
                chPlayDep.Enabled = false;
                chPant.Enabled = false;
                chZap.Enabled = false;
                btnGuard.Enabled = false;
                btncancel.Enabled = false;
                #endregion
                gBA.Enabled = true;
                txtMat.Enabled = true;
                txtMat.Enabled = true;                
                txtMat.Text = "";
                txtMat.Focus();
            }            
        }
        private void inh(){
            chCred.Enabled = false;
            chSuet.Enabled = false;
            chPants.Enabled = false;
            chPlay.Enabled = false;
            chPlayDep.Enabled = false;
            chPant.Enabled = false;
            chZap.Enabled = false;
            btnGuard.Enabled = false;
            btncancel.Enabled = false;
        }
        private void btnGuard_Click(object sender, EventArgs e) {
            #region tipo
            TipoFalta = "";
            if (chCred.Checked == true){
                TipoFalta = TipoFalta + chCred.Text + ", ";
            }
            if (chSuet.Checked == true){
                TipoFalta = TipoFalta + chSuet.Text + ", ";
            }
            if (chPants.Checked == true){
                TipoFalta = TipoFalta + chPants.Text + ", ";
            }
            if (chPlay.Checked == true){
                TipoFalta = TipoFalta + chPlay.Text + ", ";
            }
            if (chPlayDep.Checked == true){
                TipoFalta = TipoFalta + chPlayDep.Text + ", ";
            }
            if (chPant.Checked == true){
                TipoFalta = TipoFalta + chPant.Text + ", ";
            }
            if (chZap.Checked == true){
                TipoFalta = TipoFalta + chZap.Text;
            }
            #endregion
            try{
                MySqlCommand cmd;
                MySqlConnection Con = new MySqlConnection("SERVER=107.161.179.72;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
                if (chPant.Checked == false && chPlay.Checked == false && chPants.Checked == false && chSuet.Checked == false && chPlayDep.Checked == false && chZap.Checked == false && chCred.Checked == false){
                    MessageBox.Show("Debe seleccionar al menos una incidencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else{
                    using (cmd = new MySqlCommand("SELECT incidencia FROM Alumnos WHERE matricula ='" + txtMat.Text + "'")){
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Con;
                        Con.Open();
                        cant = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        Con.Close();
                    }
                    cant++;
                    string consul = "UPDATE Alumnos SET incidencia=@incidencia WHERE matricula = '" + txtMat.Text + "'";
                    cmd = new MySqlCommand(consul, Con);
                    cmd.Parameters.AddWithValue("@incidencia", cant);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    string consu = "INSERT INTO repInc (nombre,apellido,matricula,semestre,grupo,incidencia,fecha) VALUES (@nombre,@apellido,@matricula,@semestre,@grupo,@incidencia,@fecha)";
                    cmd = new MySqlCommand(consu, Con);
                    #region Datos
                    cmd.Parameters.AddWithValue("@nombre", nomb);
                    cmd.Parameters.AddWithValue("@apellido", ap);
                    cmd.Parameters.AddWithValue("@matricula", mat);
                    cmd.Parameters.AddWithValue("@semestre", sem);
                    cmd.Parameters.AddWithValue("@grupo", gpo);
                    cmd.Parameters.AddWithValue("@incidencia", TipoFalta);
                    cmd.Parameters.AddWithValue("@fecha", lblFecha.Text);
                    #endregion
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Se ha agregado la incidencia a la Base de Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inh();
                }
            }catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
         }
        public static bool Existe(string matricula){
            MySqlConnection conn = new MySqlConnection("SERVER=107.161.179.72;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
            string query = "SELECT COUNT(*) FROM Alumnos WHERE matricula=@matricula";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("matricula", matricula);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0){
                return false;
            }else{
                return true;
            }
        }
    }
}