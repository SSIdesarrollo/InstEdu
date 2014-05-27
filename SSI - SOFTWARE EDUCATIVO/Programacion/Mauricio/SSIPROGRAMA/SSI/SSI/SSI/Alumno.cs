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
            
            string tabla = "alumnos";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            dict.Add("Nombre_alumnos", txbnombrealumno.Text);
            dict.Add("Apellido_alumnos", txbapellidoalumno.Text);
            dict.Add("Fechandia", cmbdia.Text);
            dict.Add("Fechanmes", cmbmes.Text);
            dict.Add("Fechanano", txtalumnoaño.Text);
            dict.Add("Direccion_alumno", txbdireccion.Text);
            dict.Add("Correo_alumno", txbcorreoelectronico.Text);
            dict.Add("Telefonocasa_alumno", txbtelefono1.Text);
            dict.Add("Telefonocel_alumno", txbcelular.Text);
            dict.Add("Ce1nombre", txbnombre1.Text);
            dict.Add("Ce2nombre", txbnombre2.Text);
            dict.Add("Ce1telefono", txbtelefono2.Text);
            dict.Add("Ce2telefono", txbtelefono3.Text);
            dict.Add("Rama", cmbalumnorama.Text);
            dict.Add("Rama_Cod_rama", cmbalumnorama.SelectedValue.ToString());
            dict.Add("Ciclo", cmbalumnociclo.Text);
            dict.Add("Jornada", cmbjornada.Text);

            /*string query = "select * from Rama where id=" + lblcodigorama.SelectedValue;
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                lblcodigorama.Text = dict[Cod_rama];
            }*/

            //Ocultando
            lblcarneaño.Visible = false;
            txbnombrealumno.Visible = false;
            txbnombrealumno.Clear();
            txbapellidoalumno.Visible = false;
            txbapellidoalumno.Clear();
            cmbdia.Visible = false;
            cmbmes.Visible = false;
            lblnumcarne.Visible = false;
            lblguion1.Visible = false;
            lblguion2.Visible = false;
            txtalumnoaño.Visible = false;
            txtalumnoaño.Clear();
            lblnombrealumno.Visible = false;
            lblapellidoalumno.Visible = false;
            lblfechanacimiento.Visible = false;
            lblslash1.Visible = false;
            lblslash2.Visible = false;
            lblalumnorama.Visible = false;
            cmbalumnorama.Visible = false;
            lblalumnociclo.Visible = false;
            cmbalumnociclo.Visible = false;
            lbldireccion.Visible = false;
            txbdireccion.Visible = false;
            txbdireccion.Clear();
            txtalumnoaño.Visible = false;
            txtalumnoaño.Clear();
            lblcorreoelectronico.Visible = false;
            txbcorreoelectronico.Visible = false;
            txbcorreoelectronico.Clear();
            lbltelefono1.Visible = false;
            txbtelefono1.Visible = false;
            txbtelefono1.Clear();
            lbltelefono2.Visible = false;
            txbtelefono2.Visible = false;
            txbtelefono2.Clear();
            lbltelefono3.Visible = false;
            txbtelefono3.Visible = false;
            txbtelefono3.Clear();
            lblcelular.Visible = false;
            txbcelular.Visible = false;
            txbcelular.Clear();
            lblcontactosemergencia.Visible = false;
            lblnombre1.Visible = false;
            lblnombre2.Visible = false;
            txbnombre1.Visible = false;
            txbnombre1.Clear();
            txbnombre2.Visible = false;
            txbnombre2.Clear();
            lbljornada.Visible = false;
            cmbjornada.Visible = false;
            lblcarnerama.Visible = false;
            dgalumno.Visible = true;
            
            db.insertar(tabla, dict);
            MessageBox.Show("Alumno Registrado");
            //MessageBox.Show("NUMERO DE CARNET:" + (lblcarnerama) + (lblcarneaño) + (lblcarnealumno));

            //DataGridView
            string query = "select idAlumnos as 'Codigo Alumno',Nombre_alumnos as 'Nombres Alumno', Apellido_alumnos as 'Apellidos Alumno', Fechandia as 'Dia De Nacimiento', Fechanmes as 'Mes De Nacimiento', Fechanano as 'Año De Nacimiento', Telefonocel_alumno as 'Telefono Alumno', Direccion_alumno as 'Direccion Alumno', Rama as 'Rama', Ciclo as 'Ciclo', Jornada as 'Jornada', Codigo_final as 'Numero De Carnet', Telefonocasa_alumno as 'Telefono Casa', Correo_alumno as 'Correo Electronico', Ce1nombre as 'Emergencia 1', Ce1telefono as 'Telefono Emergencia 1', Ce2nombre as 'Emergencia 2', Ce2telefono as 'Telefono Emergencia 2', Rama_Cod_rama as 'Codigo Rama' from alumnos order by idAlumnos";
            dgalumno.DataSource = db.consulta_DataGridView(query);
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
            System.Collections.ArrayList array = db.consultar("select max(idAlumnos) + 1 as nextid from alumnos limit 0,1");
            foreach (Dictionary<string, string> dict in array)
            {
                lblcarnealumno.Text=dict["nextid"];
            }
            dgalumno.Visible = false;
            lblcarnerama.Text = "";
            lblcarneaño.Text = "";
            txbnombrealumno.Visible = true;
            txbapellidoalumno.Visible = true;
            cmbdia.Visible = true;
            cmbmes.Visible = true;
            lblnumcarne.Visible = true;
            lblguion1.Visible = true;
            lblguion2.Visible = true;
            txtalumnoaño .Visible = true;
            lblnombrealumno.Visible = true;
            lblapellidoalumno.Visible = true;
            lblfechanacimiento.Visible = true;
            lblslash1.Visible = true;
            lblslash2.Visible = true;
            lblalumnorama.Visible = true;
            cmbalumnorama.Visible = true;
            lblalumnociclo.Visible = true;
            cmbalumnociclo.Visible = true;
            lbldireccion.Visible = true;
            txbdireccion.Visible = true;
            txtalumnoaño.Visible = true;
            lblcorreoelectronico.Visible = true;
            txbcorreoelectronico.Visible = true;
            lbltelefono1.Visible = true;
            txbtelefono1.Visible = true;
            lbltelefono2.Visible = true;
            txbtelefono2.Visible = true;
            lbltelefono3.Visible = true;
            txbtelefono3.Visible = true;
            lblcelular.Visible = true;
            txbcelular.Visible = true;
            lblcontactosemergencia.Visible = true;
            lblnombre1.Visible = true;
            lblnombre2.Visible = true;
            txbnombre1.Visible = true;
            txbnombre2.Visible = true;
            lbljornada.Visible = true;
            cmbjornada.Visible = true;
            lblcarnerama.Visible = true;
            
            txbrama.Visible = false;
            txbaño.Visible = false;
            txbcarnet.Visible = false;
            lblcarne.Visible = false;
            btnConsultar.Visible = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            




            

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
            txbrama.Visible = true;
            txbaño.Visible = true;
            txbcarnet.Visible = true;
            lblcarne.Visible = true;
            btnConsultar.Visible = true;
            txbnombrealumno.Visible = false;
            txbapellidoalumno.Visible = false;
            cmbdia.Visible = false;
            cmbmes.Visible = false;
            txtalumnoaño.Visible = false;
            lblnombrealumno.Visible = false;
            lblapellidoalumno.Visible = false;
            lblfechanacimiento.Visible = false;
            lblslash1.Visible = false;
            lblslash2.Visible = false;

            lbldireccion.Visible = false;
            txbdireccion.Visible = false;
            txtalumnoaño.Visible = false;
            lblcorreoelectronico.Visible = false;
            txbcorreoelectronico.Visible = false;
            lbltelefono1.Visible = false;
            txbtelefono1.Visible = false;
            lbltelefono2.Visible = false;
            txbtelefono2.Visible = false;
            lbltelefono3.Visible = false;
            txbtelefono3.Visible = false;
            lblcelular.Visible = false;
            txbcelular.Visible = false;
            lblcontactosemergencia.Visible = false;
            lblnombre1.Visible = false;
            lblnombre2.Visible = false;
            txbnombre1.Visible = false;
            txbnombre2.Visible = false;
            lbljornada.Visible = false;
            cmbjornada.Visible = false;
            lblcarnerama.Visible = false;

            lblalumnorama.Visible = false;
            cmbalumnorama.Visible = false;
            lblalumnociclo.Visible = false;
            cmbalumnociclo.Visible = false;
            lblnumcarne.Visible = false;
            lblguion1.Visible = false;
            lblguion2.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void lblnombre1_Click(object sender, EventArgs e)
        {

        }
    }
}
