using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregada  
using ODBCConnect;
using MySql.Data.MySqlClient;


namespace SSI
{
    public partial class frmAlumno : Form
    {

        Boolean ready = false;
       public frmAlumno()
        {
            InitializeComponent();
            lblcarneaño.Visible = false;
            
        }

       DBConnect db = new DBConnect("proyecto");
        
        string codigoalumno = "";

       int guardado = 0;
       int encontrado = 0;
       int busqueda = 0;
       int prepguardar = 0;
       int vaciar = 0;
       int editar = 0;
 
        private void Alumno_Load(object sender, EventArgs e)
        {
            cmbalumnorama.DataSource = db.consulta_ComboBox("select Cod_rama, Nombre_rama from rama;");
            cmbalumnorama.DisplayMember = "Nombre_rama";
            cmbalumnorama.ValueMember = "Cod_rama";

            cmbalumnociclo.DataSource = db.consulta_ComboBox("select idCiclo, Nombre_ciclo from ciclo;");
            cmbalumnociclo.DisplayMember = "Nombre_ciclo";
            cmbalumnociclo.ValueMember = "idCiclo";

            ready = true;
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prepguardar == 0)
            {
                MessageBox.Show("No hay ningun registro para guardar");
            }
            if (prepguardar == 1)
            {
                busqueda = 0;
                encontrado = 0;
                if (txbalumnoaño.Text.Length != 4)
                {
                    MessageBox.Show("El año debe contener 4 caracteres");
                }
                else
                {
                    if (txbtelefonoalumno.Text.Length != 8)
                    {
                        MessageBox.Show("El telefono debe contener 8 caracteres");
                    }
                    else
                    {
                        if (txbcelularalumno.Text.Length != 8)
                        {
                            MessageBox.Show("El celular debe contener 8 caracteres");
                        }
                        else
                        {
                            if (txbcetelefono1.Text.Length != 8)
                            {
                                MessageBox.Show("El telefono para el contacto de emergencia No.1 debe contener 8 caracteres");
                            }
                            else
                            {
                                if (txbcetelefono2.Text.Length != 8)
                                {
                                    MessageBox.Show("El telefono para el contacto de emergencia No.2 debe contener 8 caracteres");
                                }
                                else
                                {
                                    if ((txbnombrealumno.Text != "") && (txbapellidoalumno.Text != "") && (cmbdia.Text != "") && (cmbmes.Text != "") && (txbalumnoaño.Text != "") && (txbcelularalumno.Text != "") && (txbdireccionalumno.Text != "") && (txbtelefonoalumno.Text != "") && (txbemailalumno.Text != "") && (txbcenombre1.Text != "") && (txbcetelefono1.Text != "") && (txbcenombre2.Text != "") && (txbcetelefono2.Text != "") && (cmbalumnorama.Text != "") && (cmbalumnociclo.Text != "") && (cmbalumnojornada.Text != ""))
                                    {
                                        /*
                                        //string query = "select * from Rama where id=" + lblcodigorama.SelectedValue;
                                        //System.Collections.ArrayList array = db.consultar(query);
                                        //foreach (Dictionary<string, string> dict in array)
                                        //{
                                        //    lblcodigorama.Text = dict[Cod_rama];
                                        //}

                                        db.insertar(tabla, dict);
                                        MessageBox.Show("Alumno Registrado");
                                        //MessageBox.Show("NUMERO DE CARNET:" + (lblcarnerama) + (lblcarneaño) + (lblcarnealumno));
                                        */
                                        string tabla = "alumnos";
                                        Dictionary<string, string> dict = new Dictionary<string, string>();
                                        dict.Add("Nombre_alumnos", txbnombrealumno.Text);
                                        dict.Add("Apellido_alumnos", txbapellidoalumno.Text);
                                        dict.Add("Fechandia", cmbdia.Text);
                                        dict.Add("Fechanmes", cmbmes.Text);
                                        dict.Add("Fechanano", txbalumnoaño.Text);
                                        dict.Add("Direccion_alumno", txbdireccionalumno.Text);
                                        dict.Add("Correo_alumno", txbemailalumno.Text);
                                        dict.Add("Telefonocasa_alumno", txbtelefonoalumno.Text);
                                        dict.Add("Telefonocel_alumno", txbcelularalumno.Text);
                                        dict.Add("Codigo_final", lblcarnerama.Text + lblcarneaño.Text + lblcarnealumno.Text);
                                        dict.Add("Ce1nombre", txbcenombre1.Text);
                                        dict.Add("Ce2nombre", txbcenombre2.Text);
                                        dict.Add("Ce1telefono", txbcetelefono1.Text);
                                        dict.Add("Ce2telefono", txbcetelefono2.Text);
                                        dict.Add("Rama", cmbalumnorama.Text);
                                        dict.Add("Rama_Cod_rama", cmbalumnorama.SelectedValue.ToString());
                                        dict.Add("Ciclo", cmbalumnociclo.Text);
                                        dict.Add("Jornada", cmbalumnojornada.Text);
                                        if (guardado == 0)
                                        {
                                            try
                                            {
                                                db.insertar(tabla, dict);
                                                MessageBox.Show("Se ha registrado nuevo alumno");
                                            }
                                            catch
                                            {
                                                MessageBox.Show("No se ha podido registrar nuevo alumno");
                                            }
                                        }
                                        if (guardado == 1)
                                        {
                                            try
                                            {
                                                string condicion = "idAlumnos=" + codigoalumno;
                                                db.actualizar(tabla, dict, condicion);
                                            }
                                            catch
                                            {
                                                MessageBox.Show("No se ha podido realizar la actualizacion");
                                            }
                                            guardado = 0;
                                        }
                                        dgalumno.Visible = false;
                                        lblcarne.Hide(); lblcarnec.Hide(); lblcarnec.Text = "0"; txbcarne.Hide(); txbcarne.Clear();
                                        lblnombrealumno.Show(); lblnombrealumnoc.Hide(); lblnombrealumnoc.Text = ""; txbnombrealumno.Show(); txbnombrealumno.Clear();
                                        lblapellidoalumno.Show(); lblapellidoalumnoc.Hide(); lblapellidoalumnoc.Text = ""; txbapellidoalumno.Show(); txbapellidoalumno.Clear();
                                        lblfechanacimiento.Show(); lblslash1.Show(); lblslash2.Show(); lblce.Show();
                                        lbldia.Hide(); lbldia.Text = ""; cmbdia.Show(); cmbdia.Text = ""; lblmes.Hide(); lblmes.Text = ""; cmbmes.Show(); cmbmes.Text = ""; lblano.Hide(); lblano.Text = ""; txbalumnoaño.Show(); txbalumnoaño.Clear();
                                        lbltelefonoalumno.Show(); lbltelefonoalumnoc.Hide(); lbltelefonoalumnoc.Text = ""; txbtelefonoalumno.Show(); txbtelefonoalumno.Clear();
                                        lblcelularalumno.Show(); lblcelularalumnoc.Hide(); lblcelularalumnoc.Text = ""; txbcelularalumno.Show(); txbcelularalumno.Clear();
                                        lbldireccionalumno.Show(); lbldireccionalumnoc.Hide(); lbldireccionalumnoc.Text = ""; txbdireccionalumno.Show(); txbdireccionalumno.Clear();
                                        lblemailalumno.Show(); lblemailalumnoc.Hide(); lblemailalumnoc.Text = ""; txbemailalumno.Show(); txbemailalumno.Clear();
                                        lblalumnorama.Show(); lblalumnoramac.Hide(); lblalumnoramac.Text = ""; cmbalumnorama.Show(); cmbalumnorama.Text = "";
                                        lblalumnociclo.Show(); lblalumnocicloc.Hide(); lblalumnocicloc.Text = ""; cmbalumnociclo.Show(); cmbalumnociclo.Text = "";
                                        lblalumnojornada.Show(); lblalumnojornadac.Hide(); lblalumnojornadac.Text = ""; cmbalumnojornada.Show(); cmbalumnojornada.Text = "";
                                        lblnumcarne.Show(); lblguion1.Show(); lblguion2.Show(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
                                        lblcenombre1.Show(); lblcenombre1c.Hide(); lblcenombre1c.Text = ""; txbcenombre1.Show(); txbcenombre1.Clear();
                                        lblcetelefono1.Show(); lblcetelefono1c.Hide(); lblcetelefono1c.Text = ""; txbcetelefono1.Show(); txbcetelefono1.Clear();
                                        lblcenombre2.Show(); lblcenombre2c.Hide(); lblcenombre2c.Text = ""; txbcenombre2.Show(); txbcenombre2.Clear();
                                        lblcetelefono2.Show(); lblcetelefono2c.Hide(); lblcetelefono2c.Text = ""; txbcetelefono2.Show(); txbcetelefono2.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe llenar todos los campos");
                                    }
                                }
                            }
                        }
                    }
                }
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            vaciar = 1;
            prepguardar = 1;
            busqueda = 0;
            encontrado = 0;
            guardado = 0;
            dgalumno.Visible = false;
            lblcarne.Hide(); lblcarnec.Hide(); lblcarnec.Text = "0"; txbcarne.Hide(); txbcarne.Clear();
            lblnombrealumno.Show(); lblnombrealumnoc.Hide(); lblnombrealumnoc.Text = ""; txbnombrealumno.Show(); txbnombrealumno.Clear();
            lblapellidoalumno.Show(); lblapellidoalumnoc.Hide(); lblapellidoalumnoc.Text = ""; txbapellidoalumno.Show(); txbapellidoalumno.Clear();
            lblfechanacimiento.Show(); lblslash1.Show(); lblslash2.Show(); lblce.Show();
            lbldia.Hide(); lbldia.Text = ""; cmbdia.Show(); cmbdia.Text = ""; lblmes.Hide(); lblmes.Text = ""; cmbmes.Show(); cmbmes.Text = ""; lblano.Hide(); lblano.Text = ""; txbalumnoaño.Show(); txbalumnoaño.Clear();
            lbltelefonoalumno.Show(); lbltelefonoalumnoc.Hide(); lbltelefonoalumnoc.Text = ""; txbtelefonoalumno.Show(); txbtelefonoalumno.Clear();
            lblcelularalumno.Show(); lblcelularalumnoc.Hide(); lblcelularalumnoc.Text = ""; txbcelularalumno.Show(); txbcelularalumno.Clear();
            lbldireccionalumno.Show(); lbldireccionalumnoc.Hide(); lbldireccionalumnoc.Text = ""; txbdireccionalumno.Show(); txbdireccionalumno.Clear();
            lblemailalumno.Show(); lblemailalumnoc.Hide(); lblemailalumnoc.Text = ""; txbemailalumno.Show(); txbemailalumno.Clear();
            lblalumnorama.Show(); lblalumnoramac.Hide(); lblalumnoramac.Text = ""; cmbalumnorama.Show(); cmbalumnorama.Text = "";
            lblalumnociclo.Show(); lblalumnocicloc.Hide(); lblalumnocicloc.Text = ""; cmbalumnociclo.Show(); cmbalumnociclo.Text = "";
            lblalumnojornada.Show(); lblalumnojornadac.Hide(); lblalumnojornadac.Text = ""; cmbalumnojornada.Show(); cmbalumnojornada.Text = "";
            lblnumcarne.Show(); lblguion1.Show(); lblguion2.Show(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
            lblcenombre1.Show(); lblcenombre1c.Hide(); lblcenombre1c.Text = ""; txbcenombre1.Show(); txbcenombre1.Clear();
            lblcetelefono1.Show(); lblcetelefono1c.Hide(); lblcetelefono1c.Text = ""; txbcetelefono1.Show(); txbcetelefono1.Clear();
            lblcenombre2.Show(); lblcenombre2c.Hide(); lblcenombre2c.Text = ""; txbcenombre2.Show(); txbcenombre2.Clear();
            lblcetelefono2.Show(); lblcetelefono2c.Hide(); lblcetelefono2c.Text = ""; txbcetelefono2.Show(); txbcetelefono2.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            vaciar = 2;
            if (busqueda == 0)
            {
                MessageBox.Show("No hay ningun registro para editar");
                prepguardar = 0;
            }
            if (busqueda == 1)
            {
                if (editar == 1)
                {
                    editar = 0;
                    encontrado = 0;
                    guardado = 1;
                    prepguardar = 1;
                    dgalumno.Visible = false;
                    lblcarne.Show(); lblcarnec.Show(); txbcarne.Hide(); lblcarnec.Text = txbcarne.Text; txbcarne.Clear();
                    lblnombrealumno.Show(); lblnombrealumnoc.Hide(); txbnombrealumno.Show(); txbnombrealumno.Text = lblnombrealumnoc.Text; lblnombrealumnoc.Text = "";
                    lblapellidoalumno.Show(); lblapellidoalumnoc.Hide(); txbapellidoalumno.Show(); txbapellidoalumno.Text = lblapellidoalumnoc.Text; lblapellidoalumnoc.Text = "";
                    lblfechanacimiento.Show(); lblslash1.Show(); lblslash2.Show(); lblce.Show();
                    lbldia.Hide(); cmbdia.Show(); cmbdia.SelectedItem = lbldia.Text; lbldia.Text = ""; lblmes.Hide(); cmbmes.Show(); cmbmes.SelectedItem = lblmes.Text; lblmes.Text = ""; lblano.Hide(); txbalumnoaño.Show(); txbalumnoaño.Text = lblano.Text; lblano.Text = "";
                    lbltelefonoalumno.Show(); lbltelefonoalumnoc.Hide(); txbtelefonoalumno.Show(); txbtelefonoalumno.Text = lbltelefonoalumnoc.Text; lbltelefonoalumnoc.Text = "";
                    lblcelularalumno.Show(); lblcelularalumnoc.Hide(); txbcelularalumno.Show(); txbcelularalumno.Text = lblcelularalumnoc.Text; lblcelularalumnoc.Text = "";
                    lbldireccionalumno.Show(); lbldireccionalumnoc.Hide(); txbdireccionalumno.Show(); txbdireccionalumno.Text = lbldireccionalumnoc.Text; lbldireccionalumnoc.Text = "";
                    lblemailalumno.Show(); lblemailalumnoc.Hide(); txbemailalumno.Show(); txbemailalumno.Text = lblemailalumnoc.Text; lblemailalumnoc.Text = "";
                    lblalumnorama.Show(); lblalumnoramac.Hide(); cmbalumnorama.Show(); cmbalumnorama.SelectedItem = lblalumnoramac.Text; lblalumnoramac.Text = "";
                    lblalumnociclo.Show(); lblalumnocicloc.Hide(); cmbalumnociclo.Show(); cmbalumnociclo.SelectedItem = lblalumnocicloc.Text; lblalumnocicloc.Text = "";
                    lblalumnojornada.Show(); lblalumnojornadac.Hide(); cmbalumnojornada.Show(); cmbalumnojornada.SelectedItem = lblalumnojornadac.Text; lblalumnojornadac.Text = "";
                    lblnumcarne.Show(); lblguion1.Show(); lblguion2.Show(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
                    lblcenombre1.Show(); lblcenombre1c.Hide(); txbcenombre1.Show(); txbcenombre1.Text = lblcenombre1c.Text; lblcenombre1c.Text = "";
                    lblcetelefono1.Show(); lblcetelefono1c.Hide(); txbcetelefono1.Show(); txbcetelefono1.Text = lblcetelefono1c.Text; lblcetelefono1c.Text = "";
                    lblcenombre2.Show(); lblcenombre2c.Hide(); txbcenombre2.Show(); txbcenombre2.Text = lblcenombre2c.Text; lblcenombre2c.Text = "";
                    lblcetelefono2.Show(); lblcetelefono2c.Hide(); txbcetelefono2.Show(); txbcetelefono2.Text = lblcetelefono2c.Text; lblcetelefono2c.Text = "";
                }
            }
        }

        private void cmbaño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void cmbalumnorama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                lblcarnerama.Text = "";
                lblcarnerama.Text = cmbalumnorama.SelectedValue.ToString();
                lblcarneaño.Text = "";
                DateTime añoactual = DateTime.Now;
                string formato = @"yy";
                lblcarneaño.Text = añoactual.ToString(formato);
                if(lblcarnealumno.Text =="00")
                {
                    System.Collections.ArrayList array = db.consultar("select max(idAlumnos) + 1 as nextid from alumnos limit 0,1");
                    foreach (Dictionary<string, string> dict in array)
                    {
                        lblcarnealumno.Text = dict["nextid"];
                    }
                }
                lblcarnerama.Show();
                lblcarneaño.Show();
                lblcarnealumno.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            /*string query = "select * from alumnos where id=" + lblcodigorama.SelectedValue;
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                lblcodigorama.Text = dict[Cod_rama];
            }
            
            Dictionary<string, string> d = new DBConnect ("alumnos").consultar_un_registro(query)   
       */ }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtalumnoaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtalumnoaño_VisibleChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lblcarneaño_Click(object sender, EventArgs e)
        {
            lblcarneaño.Hide();
        }

        private void lblcarnealumno_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            vaciar = 2;
            prepguardar = 0;
            if (encontrado == 0)
            {
                busqueda = 0;
                dgalumno.Visible = true;
                lblcarne.Show(); lblcarnec.Hide(); lblcarnec.Text = "0"; txbcarne.Clear(); txbcarne.Show();
                lblnombrealumno.Hide(); lblnombrealumnoc.Hide(); lblnombrealumnoc.Text = ""; txbnombrealumno.Hide(); txbnombrealumno.Clear();
                lblapellidoalumno.Hide(); lblapellidoalumnoc.Hide(); lblapellidoalumnoc.Text = ""; txbapellidoalumno.Hide(); txbapellidoalumno.Clear();
                lblfechanacimiento.Hide(); lblslash1.Hide(); lblslash2.Hide(); lblce.Hide();
                lbldia.Hide(); lbldia.Text = ""; cmbdia.Hide(); cmbdia.Text = ""; lblmes.Hide(); lblmes.Text = ""; cmbmes.Hide(); cmbmes.Text = ""; lblano.Hide(); lblano.Text = ""; txbalumnoaño.Hide(); txbalumnoaño.Clear();
                lbltelefonoalumno.Hide(); lbltelefonoalumnoc.Hide(); lbltelefonoalumnoc.Text = ""; txbtelefonoalumno.Hide(); txbtelefonoalumno.Clear();
                lblcelularalumno.Hide(); lblcelularalumnoc.Hide(); lblcelularalumnoc.Text = ""; txbcelularalumno.Hide(); txbcelularalumno.Clear();
                lbldireccionalumno.Hide(); lbldireccionalumnoc.Hide(); lbldireccionalumnoc.Text = ""; txbdireccionalumno.Hide(); txbdireccionalumno.Clear();
                lblemailalumno.Hide(); lblemailalumnoc.Hide(); lblemailalumnoc.Text = ""; txbemailalumno.Hide(); txbemailalumno.Clear();
                lblalumnorama.Hide(); lblalumnoramac.Hide(); lblalumnoramac.Text = ""; cmbalumnorama.Hide(); cmbalumnorama.Text = "";
                lblalumnociclo.Hide(); lblalumnocicloc.Hide(); lblalumnocicloc.Text = ""; cmbalumnociclo.Hide(); cmbalumnociclo.Text = "";
                lblalumnojornada.Hide(); lblalumnojornadac.Hide(); lblalumnojornadac.Text = ""; cmbalumnojornada.Hide(); cmbalumnojornada.Text = "";
                lblnumcarne.Hide(); lblguion1.Hide(); lblguion2.Hide(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
                lblcenombre1.Hide(); lblcenombre1c.Hide(); lblcenombre1c.Text = ""; txbcenombre1.Hide(); txbcenombre1.Clear();
                lblcetelefono1.Hide(); lblcetelefono1c.Hide(); lblcetelefono1c.Text = ""; txbcetelefono1.Hide(); txbcetelefono1.Clear();
                lblcenombre2.Hide(); lblcenombre2c.Hide(); lblcenombre2c.Text = ""; txbcenombre2.Hide(); txbcenombre2.Clear();
                lblcetelefono2.Hide(); lblcetelefono2c.Hide(); lblcetelefono2c.Text = ""; txbcetelefono2.Hide(); txbcetelefono2.Clear();
                //DataGridView
                string query = "select Codigo_final as 'Numero De Carnet', Nombre_alumnos as 'Nombres Alumno', Apellido_alumnos as 'Apellidos Alumno', Fechandia as 'Dia De Nacimiento', Fechanmes as 'Mes De Nacimiento', Fechanano as 'Año De Nacimiento', Telefonocel_alumno as 'Telefono Alumno', Direccion_alumno as 'Direccion Alumno', Rama as 'Rama', Ciclo as 'Ciclo', Jornada as 'Jornada', Telefonocasa_alumno as 'Telefono Casa', Correo_alumno as 'Correo Electronico', Ce1nombre as 'Emergencia 1', Ce1telefono as 'Telefono Emergencia 1', Ce2nombre as 'Emergencia 2', Ce2telefono as 'Telefono Emergencia 2', Rama_Cod_rama as 'Codigo Rama' from alumnos order by idAlumnos";
                dgalumno.DataSource = db.consulta_DataGridView(query); 
                encontrado = 1;
            }
            else
            {
                if (txbcarne.Text == "")
                {
                    MessageBox.Show("Debe ingresar un codigo para realizar la busqueda");
                }
                else
                {
                    editar = 1;
                    encontrado = 0;
                    dgalumno.Visible = false;
                    lblcarnec.Text = txbcarne.Text;
                    txbcarne.Hide();
                    lblcarnec.Show();
                    string carnet = txbcarne.Text;
                    try
                    {
                        System.Collections.ArrayList array = db.consultar("select * from personal where Codigo_final=" + carnet);
                        foreach (Dictionary<string, string> dict in array)
                        {
                            lblcarnealumno.Text = dict["idAlumnos"];
                            lblnombrealumnoc.Text = dict["Nombre_alumnos"];
                            lblapellidoalumnoc.Text = dict["Apellido_alumnos"];
                            lbldia.Text = dict["Fechandia"];
                            lblmes.Text = dict["Fechanmes"];
                            lblano.Text = dict["Fechanano"];
                            lblcelularalumnoc.Text = dict["Telefonocel_alumno"];
                            lbldireccionalumnoc.Text = dict["Direccion_alumno"];
                            lblalumnoramac.Text = dict["Rama_Cod_rama"];
                            lblalumnocicloc.Text = dict["Ciclo"];
                            lblalumnojornadac.Text = dict["Jornada"];
                            lbltelefonoalumnoc.Text = dict["Telefonocasa_alumno"];
                            lblemailalumnoc.Text = dict["Correo_alumno"];
                            lblcenombre1c.Text = dict["Ce1nombre"];
                            lblcetelefono1c.Text = dict["Ce1telefono"];
                            lblcenombre2c.Text = dict["Ce2nombre"];
                            lblcetelefono2c.Text = dict["Ce2telefono"];
                        }
                        codigoalumno = lblcarnealumno.Text;
                        /*
                        System.Collections.ArrayList array2 = db.consultar("SELECT * FROM tipo_personal WHERE Tipo_personal=" + lbltipopersonalc.Text);
                        foreach (Dictionary<string, string> dict in array2)
                        {
                            lbltipopersonalc.Text = dict["Descripcion"];
                        }
                        */
                        busqueda = 1;
                    }
                    catch
                    {
                        MessageBox.Show(" No existe coincidencia en registro para carnet " + carnet);
                    }
                    dgalumno.Visible = false;
                    lblcarne.Show(); lblcarnec.Show(); txbcarne.Clear();
                    lblnombrealumno.Show(); lblnombrealumnoc.Show();
                    lblapellidoalumno.Show(); lblapellidoalumnoc.Show();
                    lblfechanacimiento.Show(); lblslash1.Show(); lblslash2.Show(); lblce.Show();
                    lbldia.Show(); lblmes.Show(); lblano.Show();
                    lbltelefonoalumno.Show(); lbltelefonoalumnoc.Show();
                    lblcelularalumno.Show(); lblcelularalumnoc.Show();
                    lbldireccionalumno.Show(); lbldireccionalumnoc.Show();
                    lblemailalumno.Show(); lblemailalumnoc.Show();
                    lblalumnorama.Show(); lblalumnoramac.Show();
                    lblalumnociclo.Show(); lblalumnocicloc.Show();
                    lblalumnojornada.Show(); lblalumnojornadac.Show();
                    lblnumcarne.Show(); lblguion1.Show(); lblguion2.Show(); lblcarnerama.Show(); lblcarneaño.Show(); lblcarnealumno.Show();
                    lblcenombre1.Show(); lblcenombre1c.Show();
                    lblcetelefono1.Show(); lblcetelefono1c.Show();
                    lblcenombre2.Show(); lblcenombre2c.Show();
                    lblcetelefono2.Show(); lblcetelefono2c.Show();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void lblnombre1_Click(object sender, EventArgs e)
        {

        }

        private void cmbjornada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (vaciar == 1)
            {
                dgalumno.Visible = false;
                lblcarne.Hide(); lblcarnec.Hide(); lblcarnec.Text = "0"; txbcarne.Hide(); txbcarne.Clear();
                lblnombrealumno.Hide(); lblnombrealumnoc.Hide(); lblnombrealumnoc.Text = ""; txbnombrealumno.Hide(); txbnombrealumno.Clear();
                lblapellidoalumno.Hide(); lblapellidoalumnoc.Hide(); lblapellidoalumnoc.Text = ""; txbapellidoalumno.Hide(); txbapellidoalumno.Clear();
                lblfechanacimiento.Hide(); lblslash1.Hide(); lblslash2.Hide(); lblce.Hide();
                lbldia.Hide(); lbldia.Text = ""; cmbdia.Hide(); cmbdia.Text = ""; lblmes.Hide(); lblmes.Text = ""; cmbmes.Hide(); cmbmes.Text = ""; lblano.Hide(); lblano.Text = ""; txbalumnoaño.Hide(); txbalumnoaño.Clear();
                lbltelefonoalumno.Hide(); lbltelefonoalumnoc.Hide(); lbltelefonoalumnoc.Text = ""; txbtelefonoalumno.Hide(); txbtelefonoalumno.Clear();
                lblcelularalumno.Hide(); lblcelularalumnoc.Hide(); lblcelularalumnoc.Text = ""; txbcelularalumno.Hide(); txbcelularalumno.Clear();
                lbldireccionalumno.Hide(); lbldireccionalumnoc.Hide(); lbldireccionalumnoc.Text = ""; txbdireccionalumno.Hide(); txbdireccionalumno.Clear();
                lblemailalumno.Hide(); lblemailalumnoc.Hide(); lblemailalumnoc.Text = ""; txbemailalumno.Hide(); txbemailalumno.Clear();
                lblalumnorama.Hide(); lblalumnoramac.Hide(); lblalumnoramac.Text = ""; cmbalumnorama.Hide(); cmbalumnorama.Text = "";
                lblalumnociclo.Hide(); lblalumnocicloc.Hide(); lblalumnocicloc.Text = ""; cmbalumnociclo.Hide(); cmbalumnociclo.Text = "";
                lblalumnojornada.Hide(); lblalumnojornadac.Hide(); lblalumnojornadac.Text = ""; cmbalumnojornada.Hide(); cmbalumnojornada.Text = "";
                lblnumcarne.Hide(); lblguion1.Hide(); lblguion2.Hide(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
                lblcenombre1.Hide(); lblcenombre1c.Hide(); lblcenombre1c.Text = ""; txbcenombre1.Hide(); txbcenombre1.Clear();
                lblcetelefono1.Hide(); lblcetelefono1c.Hide(); lblcetelefono1c.Text = ""; txbcetelefono1.Hide(); txbcetelefono1.Clear();
                lblcenombre2.Hide(); lblcenombre2c.Hide(); lblcenombre2c.Text = ""; txbcenombre2.Hide(); txbcenombre2.Clear();
                lblcetelefono2.Hide(); lblcetelefono2c.Hide(); lblcetelefono2c.Text = ""; txbcetelefono2.Hide(); txbcetelefono2.Clear(); 
                vaciar = 0;
                prepguardar = 0;
            }
            if (vaciar == 2)
            {
                vaciar = 0;
                if (dgalumno.Visible == true)
                {
                    lblcarne.Hide();
                    txbcarne.Hide();
                    dgalumno.Hide();
                    encontrado = 0;
                }
                else
                {
                    string tabla = "alumnos";
                    string condicion = "idAlumnos=" + codigoalumno;
                    db.eliminar(tabla, condicion);
                    dgalumno.Visible = false;
                    lblcarne.Hide(); lblcarnec.Hide(); lblcarnec.Text = "0"; txbcarne.Hide(); txbcarne.Clear();
                    lblnombrealumno.Hide(); lblnombrealumnoc.Hide(); lblnombrealumnoc.Text = ""; txbnombrealumno.Hide(); txbnombrealumno.Clear();
                    lblapellidoalumno.Hide(); lblapellidoalumnoc.Hide(); lblapellidoalumnoc.Text = ""; txbapellidoalumno.Hide(); txbapellidoalumno.Clear();
                    lblfechanacimiento.Hide(); lblslash1.Hide(); lblslash2.Hide(); lblce.Hide();
                    lbldia.Hide(); lbldia.Text = ""; cmbdia.Hide(); cmbdia.Text = ""; lblmes.Hide(); lblmes.Text = ""; cmbmes.Hide(); cmbmes.Text = ""; lblano.Hide(); lblano.Text = ""; txbalumnoaño.Hide(); txbalumnoaño.Clear();
                    lbltelefonoalumno.Hide(); lbltelefonoalumnoc.Hide(); lbltelefonoalumnoc.Text = ""; txbtelefonoalumno.Hide(); txbtelefonoalumno.Clear();
                    lblcelularalumno.Hide(); lblcelularalumnoc.Hide(); lblcelularalumnoc.Text = ""; txbcelularalumno.Hide(); txbcelularalumno.Clear();
                    lbldireccionalumno.Hide(); lbldireccionalumnoc.Hide(); lbldireccionalumnoc.Text = ""; txbdireccionalumno.Hide(); txbdireccionalumno.Clear();
                    lblemailalumno.Hide(); lblemailalumnoc.Hide(); lblemailalumnoc.Text = ""; txbemailalumno.Hide(); txbemailalumno.Clear();
                    lblalumnorama.Hide(); lblalumnoramac.Hide(); lblalumnoramac.Text = ""; cmbalumnorama.Hide(); cmbalumnorama.Text = "";
                    lblalumnociclo.Hide(); lblalumnocicloc.Hide(); lblalumnocicloc.Text = ""; cmbalumnociclo.Hide(); cmbalumnociclo.Text = "";
                    lblalumnojornada.Hide(); lblalumnojornadac.Hide(); lblalumnojornadac.Text = ""; cmbalumnojornada.Hide(); cmbalumnojornada.Text = "";
                    lblnumcarne.Hide(); lblguion1.Hide(); lblguion2.Hide(); lblcarnerama.Hide(); lblcarnerama.Text = "00"; lblcarneaño.Hide(); lblcarneaño.Text = "00"; lblcarnealumno.Hide(); lblcarnealumno.Text = "00";
                    lblcenombre1.Hide(); lblcenombre1c.Hide(); lblcenombre1c.Text = ""; txbcenombre1.Hide(); txbcenombre1.Clear();
                    lblcetelefono1.Hide(); lblcetelefono1c.Hide(); lblcetelefono1c.Text = ""; txbcetelefono1.Hide(); txbcetelefono1.Clear();
                    lblcenombre2.Hide(); lblcenombre2c.Hide(); lblcenombre2c.Text = ""; txbcenombre2.Hide(); txbcenombre2.Clear();
                    lblcetelefono2.Hide(); lblcetelefono2c.Hide(); lblcetelefono2c.Text = ""; txbcetelefono2.Hide(); txbcetelefono2.Clear(); 
                }
            }
        }
    }
}
