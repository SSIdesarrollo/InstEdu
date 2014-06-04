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
    public partial class frmasignacioncursos : Form
    {
        public frmasignacioncursos()
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

        string carnet = "";


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lblrama1.Visible = true;
            lblcurso.Visible = true;
            lblciclo.Visible = true;
            lblasignacion.Visible = true;
            lblnotafinal.Visible = true;
            cmbrama1.Visible = true;
            cmbrama1.Text = "";
            cmbcurso.Visible = true;
            cmbcurso.Text = "";
            cmbciclo.Visible = true;
            cmbciclo.Text = "";
            cmbasignacion.Visible = true;
            cmbasignacion.Text = "";
            cmbnotafinal.Visible = true;
            cmbnotafinal.Text = "";

            vaciar = 2;
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
                    lblalumnorama.Show(); lblalumnoramac.Show();
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmasignacioncursos_Load(object sender, EventArgs e)
        {
            cmbrama1.DataSource = db.consulta_ComboBox("select Cod_rama, Nombre_rama from rama;");
            cmbrama1.DisplayMember = "Nombre_rama";
            cmbrama1.ValueMember = "Cod_rama";

            cmbcurso.DataSource = db.consulta_ComboBox("select Cod_curso, Nombre_curso from curso;");
            cmbcurso.DisplayMember = "Nombre_curso";
            cmbcurso.ValueMember = "Cod_curso";

            cmbciclo.DataSource = db.consulta_ComboBox("select idCiclo, Nombre_ciclo from ciclo;");
            cmbciclo.DisplayMember = "Nombre_ciclo";
            cmbciclo.ValueMember = "idCiclo";

            cmbasignacion.DataSource = db.consulta_ComboBox("select idAsigcurso, ano from asigcurso;");
            cmbasignacion.DisplayMember = "ano";
            cmbasignacion.ValueMember = "idAsigcurso";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "detalleasigcurso";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Rama_Cod_rama", cmbrama1.SelectedValue.ToString());
            dict.Add("Ciclo_idCiclo", cmbciclo.SelectedValue.ToString());
            dict.Add("Curso_Cod_curso", cmbcurso.SelectedValue.ToString());
            dict.Add("Asigcurso_idAsigcurso", cmbasignacion.SelectedValue.ToString());
            dict.Add("NotaFinal", cmbnotafinal.Text);
            db.insertar(tabla, dict);

            string query = "select Asigcurso_idAsigcurso as 'Codigo De Asignación', Ciclo_idCiclo as 'Código De Ciclo', Rama_Cod_rama as 'Rama', Curso_Cod_curso as 'Código De Curso', Notafinal as 'Nota Final' from detalleasigcurso order by Asigcurso_idAsigcurso";
            dgasignacioncurso.DataSource = db.consulta_DataGridView(query);

            dgasignacioncurso.Visible = true;
        }
    }
}
