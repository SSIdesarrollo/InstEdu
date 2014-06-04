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
            dict.Add("Nombre_ciclo", textBox1.Text);
            db.insertar(tabla, dict);
        }
    }
}
