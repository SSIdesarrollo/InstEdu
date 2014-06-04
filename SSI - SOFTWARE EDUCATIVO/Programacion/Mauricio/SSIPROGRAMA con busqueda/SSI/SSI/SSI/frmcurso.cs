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
    public partial class frmcurso : Form
    {

        public frmcurso()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "Curso";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Nombre_curso", txbnombrecurso.Text);
            db.insertar(tabla, dict);
            lblnombrecurso.Visible = false;
            txbnombrecurso.Visible = false;
            txbnombrecurso.Clear();

            //DataGridView
            string query = "select Cod_curso as 'Codigo Curso',Nombre_curso as 'Nombre Curso' from curso";
            dgcurso.DataSource = db.consulta_DataGridView(query);

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lblnombrecurso.Visible = true;
            txbnombrecurso.Visible = true;
            dgcurso.Visible = true;
        }
    }
}
