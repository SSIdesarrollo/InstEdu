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
    public partial class frmtipopersonal : Form
    {
        
        public frmtipopersonal()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "tipo_personal";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Descripcion", txbtipopersonal.Text);
            db.insertar(tabla, dict);
            lbltipopersonal.Visible = false;
            txbtipopersonal.Visible = false;
            txbtipopersonal.Clear();

            //DataGridView
            string query = "select Tipo_personal as 'Codigo Personal',Descripcion as 'Descripcion Personal' from tipo_personal";
            dgtipopersonal.DataSource = db.consulta_DataGridView(query);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lbltipopersonal.Visible = true;
            txbtipopersonal.Visible = true;
            dgtipopersonal.Visible = true;
        }
    }
}
