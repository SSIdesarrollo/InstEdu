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
    public partial class frmrama : Form
    {
        
        public frmrama()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");
              
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tabla = "rama";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Nombre_rama", txbrama.Text);
            db.insertar(tabla, dict);
            txbrama.Visible = false;
            lblnombrederama.Visible = false;
            MessageBox.Show("Rama Ingresada Exitosamente");

            //DataGridView
            string query = "select Cod_rama as 'Codigo Rama',Nombre_rama as 'Nombre Rama' from rama";
            dgrama.DataSource = db.consulta_DataGridView(query);
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            lblnombrederama.Visible = true;
            txbrama.Visible = true;
            dgrama.Visible = true;
        }
    }
}
