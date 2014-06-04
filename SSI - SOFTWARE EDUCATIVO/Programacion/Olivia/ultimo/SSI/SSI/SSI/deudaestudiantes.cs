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
    public partial class frmdestudiantes : Form
    {
             
        public frmdestudiantes()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect("proyecto");


        private void btndestudiantes_Click(object sender, EventArgs e)
        {
         


        }

        private void frmdestudiantes_Load(object sender, EventArgs e)
        {
            cmbdd.DataSource = db.consulta_ComboBox("select id_tipopago, Descripcion from tipo_pago;");
            cmbdd.DisplayMember = "Descripcion";
            cmbdd.ValueMember = "id_tipopago";
            
            cmbde.DataSource = db.consulta_ComboBox("select idAlumnos, Nombre_alumnos from alumnos;");
            cmbde.DisplayMember = "Nombre_alumnos";
            cmbde.ValueMember = "idAlumnos";

            //cmbdd.DataSource = db.consulta_ComboBox("select iddestudiantes, Nombre from destudiantes;");
            //cmbdd.DisplayMember = "Nombre";
            //cmbdd.ValueMember = "iddestudiantes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "Deudores";
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Alumnos_idAlumnos", cmbde.SelectedValue.ToString());
            dict.Add("Tipo_pago_id_tipopago", cmbdd.SelectedValue.ToString());


            db.insertar(tabla, dict);
            MessageBox.Show("La deuda se la ingresado correctamente");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
