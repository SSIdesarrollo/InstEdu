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
    public partial class frmpensum : Form
    {

        public frmpensum()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");
              
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "pensum";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Descripcion", txbdescripcion.Text);
            dict.Add("ano", txbaño.Text);
            db.insertar(tabla, dict);
            lblaño.Visible = false;
            lbldescripcio.Visible = false;
            txbdescripcion.Visible = false;
            txbaño.Visible = false;
            txbaño.Clear();
            txbdescripcion.Clear();

            //DataGridView
            string query = "select idPensum as 'Codigo Pensum',Descripcion as 'Descripcion Pensum', ano as 'Año' from pensum";
            dgpensum.DataSource = db.consulta_DataGridView(query);

            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lbldescripcio.Visible = true;
            lblaño.Visible = true;
            txbdescripcion.Visible = true;
            txbaño.Visible = true;
            dgpensum.Visible = true;
        }
    }
}
