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
        //Variables De Conexion.
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public frmAlumno()
        {
            InitializeComponent();    
        }

        //------
        

        //Void Conexion
        private void iniciarConexion()
         {
             try
             {
                 cnn.ConnectionString = "server=127.0.0.1; database=proyecto; Uid=root; pwd=;";
                 cnn.Open();
                 //label1.Text="Conexion exitosa";
                // MessageBox.Show("Conexion Exitosa :)");
             }
             catch (MySqlException)
             {
                 //MessageBox.Show("Error de Conexion, :( ");
                //label1.Text = "Error de conexion";
             }
         }
        // Termina void

        private void Alumno_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txbnombrealumno.Visible = true;
            txbapellidoalumno.Visible = true;
            cmbdia.Visible = true;
            cmbmes.Visible = true;
            cmbaño.Visible = true;
            lblnombrealumno.Visible = true;
            lblapellidoalumno.Visible = true;
            lblfechanacimiento.Visible = true;
            lblslash1.Visible = true;
            lblslash2.Visible = true;
            txbrama.Visible = false;
            txbaño.Visible = false;
            txbcarnet.Visible = false;
            lblcarne.Visible = false;
            btnConsultar.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
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
            cmbaño.Visible = false;
            lblnombrealumno.Visible = false;
            lblapellidoalumno.Visible = false;
            lblfechanacimiento.Visible = false;
            lblslash1.Visible = false;
            lblslash2.Visible = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {/*
            {
                if (txbnombrealumno.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("Descripcion", txbnombrealumno.Text);

                    if (editar)
                    {
                        db.actualizar("alumnos", dict, "Codigo_final=" + id);
                        txbnombrealumno.Text = "";
                        txbnombrealumno.ReadOnly = true;
                        editar = false;
                    }
                    else
                    {
                        if (txbnombrealumno.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        bool ingresa = true;
                        if (ingresa)
                        {
                            db.insertar("alumnos", dict);
                            txbnombrealumno.Text = "";
                            txbnombrealumno.ReadOnly = false;
                        }
                    }
                    //dgvtipopago.DataSource = db.consulta_DataGridView("select *from Tipo_pago");
                }
            }*/
        }
    }
}
