using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODBCConnect;

namespace SSI
{
    public partial class frmplanificacionhorario : Form
    {
        public frmplanificacionhorario()
        {
            InitializeComponent();
            //lblcarneaño.Visible = false;

        }

        DBConnect db = new DBConnect("proyecto");

        string codigoalumno = "";

        int guardado = 0;
        int encontrado = 0;
        int busqueda = 0;
        int prepguardar = 0;
        int vaciar = 0;
        int editar = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string carnet = "";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmasignaciondecursos_Load(object sender, EventArgs e)
        {
            cmbalumnociclo.DataSource = db.consulta_ComboBox("select idCiclo, Nombre_ciclo from ciclo;");
            cmbalumnociclo.DisplayMember = "Nombre_ciclo";
            cmbalumnociclo.ValueMember = "idCiclo";

            cmbcurso.DataSource = db.consulta_ComboBox("select Cod_curso, Nombre_curso from curso;");
            cmbcurso.DisplayMember = "Nombre_curso";
            cmbcurso.ValueMember = "Cod_curso";

            cmbaño.DataSource = db.consulta_ComboBox("select idPlanhr, ano from Planhr;");
            cmbaño.DisplayMember = "ano";
            cmbaño.ValueMember = "idPlanhr";

            cmbrama.DataSource = db.consulta_ComboBox("select Cod_rama, Nombre_rama from rama;");
            cmbrama.DisplayMember = "Nombre_rama";
            cmbrama.ValueMember = "Cod_rama";
            

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        /*    vaciar = 2;
            prepguardar = 0;
            {
                if (txbcarne.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Carnet para realizar la busqueda");
                }
                else
                {
                    editar = 1;
                    encontrado = 0;
                    txbcarne.Hide();
                    carnet = txbcarne.Text;
                    try
                    {
                        System.Collections.ArrayList array = db.consultar("select * from alumnos where Codigo_final=" + carnet);
                        foreach (Dictionary<string, string> dict in array)
                        {
                            //lblcarnealumno.Text = dict["idAlumnos"];
                            lblnombrealumnoc.Text = dict["Nombre_alumnos"];
                            lblapellidoalumnoc.Text = dict["Apellido_alumnos"];
                            lblalumnoramac.Text = dict["Rama_Cod_rama"];
                        }
                        //codigoalumno = lblcarnealumno.Text;
                        busqueda = 1;
                    }
                    catch
                    {
                        MessageBox.Show(" No existe coincidencia en registro para carnet " + carnet);
                    }
                    lblnombrealumno.Show(); lblnombrealumnoc.Show();
                    lblapellidoalumno.Show(); lblapellidoalumnoc.Show();
                    lblalumnorama.Show(); lblalumnoramac.Show();*/
                   

                    /*string query = "select Nombre_Curso as 'Curso' from curso order by Cod_curso";
                    dgasignacionalumnos.DataSource = db.consulta_DataGridView(query); */

              //  }
            //}
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            dgplanificacionhorario.Visible = true;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lblciclo.Visible = true;
            lblcurso.Visible = true;
            lblinicio.Visible = true;
            lblfin.Visible = true;
            lbldia.Visible = true;
            lblaño.Visible = true;
            lblrama.Visible = true;
            cmbaño.Visible = true;
            cmbaño.Text = "";
            cmbrama.Visible = true;
            cmbrama.Text = "";
            cmbalumnociclo.Visible = true;
            cmbalumnociclo.Text = "";
            cmbcurso.Visible = true;
            cmbcurso.Text = "";
            cmbinicio.Visible = true;
            cmbinicio.Text = "";
            cmbfin.Visible = true;
            cmbinicio.Text = "";
            cmbdia.Visible = true;
            cmbdia.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "detplanhr";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Planhr_idPlanhr", cmbaño.SelectedValue.ToString());
            dict.Add("Rama_Cod_rama", cmbrama.SelectedValue.ToString());
            dict.Add("Ciclo_idCiclo", cmbalumnociclo.SelectedValue.ToString());
            dict.Add("Curso_Cod_curso", cmbcurso.SelectedValue.ToString());
            dict.Add("Hinicio", cmbinicio.Text);
            dict.Add("Hfin", cmbfin.Text);
            dict.Add("Dia", cmbdia.Text);
            db.insertar(tabla, dict);

            string query = "select Planhr_idPlanhr as 'Codigo De Planificación', Rama_Cod_rama as 'Rama', Ciclo_idCiclo as 'Ciclo', Curso_Cod_curso as 'Curso', Hinicio as 'Inicio', Hfin as 'Fin', Dia as 'Dia' from detplanhr order by Planhr_idPlanhr";
            dgplanificacionhorario.DataSource = db.consulta_DataGridView(query);

            dgplanificacionhorario.Visible = true;
        }
    }
}
