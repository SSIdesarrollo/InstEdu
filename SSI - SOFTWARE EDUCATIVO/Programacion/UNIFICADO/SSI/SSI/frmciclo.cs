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
    public partial class frmciclo : Form
    {

        public frmciclo()
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
            string tabla = "ciclo";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Nombre_ciclo", cmbciclo.Text);
            db.insertar(tabla, dict);



            dgciclo.Visible = true;
            string query = "select IdCiclo as 'Codigo Ciclo',Nombre_ciclo as 'Nombre Ciclo' from ciclo";
            dgciclo.DataSource = db.consulta_DataGridView(query);

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lblciclo.Visible = true;
            cmbciclo.Visible = true;
            dgciclo.Visible = true;
        }
    }
}
