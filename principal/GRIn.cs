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
    public partial class GRIn : Form{
        string nomb = "", ap = "", gpo = "", TipoFalta = "Especificada", mat = "";
        int cant = 0, sem = 0;
        public GRIn(){
            InitializeComponent();
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
        private void btnCan_Click(object sender, EventArgs e){
            cancelar();
        }
        private void btnRegresar_Click(object sender, EventArgs e){
            this.Dispose();
            Principal prin = new Principal();
            prin.Show();
        }
        private void btnGu_Click(object sender, EventArgs e){
            #region tipo
            TipoFalta = "";
            if (checkBox1.Checked == true){
                TipoFalta = TipoFalta + checkBox1.Text + ", ";
            }
            if (checkBox2.Checked == true){
                TipoFalta = TipoFalta + checkBox2.Text + ", ";
            }
            if (checkBox3.Checked == true){
                TipoFalta = TipoFalta + checkBox3.Text + ", ";
            }
            if (checkBox4.Checked == true){
                TipoFalta = TipoFalta + checkBox4.Text + ", ";
            }
            if (checkBox5.Checked == true){
                TipoFalta = TipoFalta + checkBox5.Text + ", ";
            }
            if (checkBox6.Checked == true){
                TipoFalta = TipoFalta + checkBox6.Text;
            }
            #endregion
            try{
                MySqlCommand cmd;
                MySqlConnection Con = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false&& textBox3.Text == "[-- Ya especificado ---]"|| checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && textBox3.Text == ""){
                    MessageBox.Show("Debe seleccionar al menos una incidencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else{
                    //Rgrupal
                    using (cmd = new MySqlCommand("SELECT Rindividual FROM Alumnos WHERE matricula ='" + txtMat.Text + "'")){
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = Con;
                        Con.Open();
                        cant = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        Con.Close();
                    }
                    cant++;
                    string consul = "UPDATE Alumnos SET Rindividual=@Rindividual WHERE matricula = '" + txtMat.Text + "'";
                    cmd = new MySqlCommand(consul, Con);
                    cmd.Parameters.AddWithValue("@Rindividual", cant);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    string consu = "INSERT INTO repInd (nombre,apellido,matricula,grupo,fecha,incidencia,otros,fechaTrabajo,hora,sancion,prefecto) VALUES (@nombre,@apellido,@matricula,@grupo,@fecha,@incidencia,@otros,@fechaTrabajo,@hora,@sancion,@prefecto)";
                    cmd = new MySqlCommand(consu, Con);
                    #region Datos
                    cmd.Parameters.AddWithValue("@nombre", nomb);
                    cmd.Parameters.AddWithValue("@apellido", ap);
                    cmd.Parameters.AddWithValue("@matricula", mat);                    
                    cmd.Parameters.AddWithValue("@grupo", (sem+" "+gpo));                    
                    cmd.Parameters.AddWithValue("@fecha", lblFecha.Text);
                    cmd.Parameters.AddWithValue("@incidencia", TipoFalta);
                    cmd.Parameters.AddWithValue("@otros", textBox3.Text);
                    cmd.Parameters.AddWithValue("@fechaTrabajo", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@hora", (comboBox3.Text+" : "+comboBox4.Text));
                    cmd.Parameters.AddWithValue("@sancion", textBox1.Text);
                    cmd.Parameters.AddWithValue("@prefecto", textBox2.Text);
                    #endregion
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Se ha agregado el reporte individual a la Base de Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = false;
                    btnGu.Enabled = false;
                }
            }catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void GRIn_Load(object sender, EventArgs e){
            lblFecha.Text = DateTime.Today.ToString("dd MMMM yyyy");
            groupBox2.Enabled = false;
            gBA.Enabled = true;
            btnCan.Enabled = false;
            btnGu.Enabled = false;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }
        private void btnBusc_Click(object sender, EventArgs e){
            if (txtMat.Text != ""){
                buscar();
            }else{
                MessageBox.Show("Debe ingresar una matricula", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMat.Focus();
            }
        }
        public static bool Existe(string matricula){
            MySqlConnection conn = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
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
        private void buscar(){
            if (Existe(txtMat.Text)){
                try{
                    MySqlConnection connStr = new MySqlConnection("SERVER=66.7.193.154;PORT=3306;DATABASE=cbtisedu_SistemaRI;UID=cbtisedu_Admin; password =7I_+wZ=(I]v4;");
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
                    groupBox2.Enabled = true;
                    btnGu.Enabled = true;
                    btnCan.Enabled = true;
                    #endregion
                    LB.Enabled = true;
                    txtMat.Enabled = false;
                    btnBusc.Enabled = false;
                }catch (Exception ex){
                    MessageBox.Show("Error: " + ex.Message);
                }
            }else{
                MessageBox.Show("La matrícula ingresada no existe\nIngrese una matrícula valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                #region inhabilitar
                groupBox2.Enabled = false;
                btnGu.Enabled = false;
                btnCan.Enabled = false;
                #endregion
                gBA.Enabled = true;
                txtMat.Enabled = true;
                txtMat.Enabled = true;
                txtMat.Text = "";
                txtMat.Focus();
            }
        }
        private void cancelar(){
            txtMat.Text = "";
            txtMat.Enabled = true;
            btnBusc.Enabled = true;
            pbFoto.Enabled = false;
            LB.Enabled = false;
            pbFoto.Image=null;
            LB.Items.Clear();
            groupBox2.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "[-- Ya especificado ---]";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            btnCan.Enabled = false;
            btnGu.Enabled = false;
        }
    }
}