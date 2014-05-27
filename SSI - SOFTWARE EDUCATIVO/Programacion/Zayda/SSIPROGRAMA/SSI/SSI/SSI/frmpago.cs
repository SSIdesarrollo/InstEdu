using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ODBCConnect;

namespace SSI
{
    public partial class frmpago : Form
    {
        public frmpago()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        bool editar = false;
        string id;

        private void btntipo_pago_Click(object sender, EventArgs e)
        {
            frmtipopago tipopago = new frmtipopago();
            tipopago.Show();

        }

        private void frmpago_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //combobox de estudiantes
            cmbestudiante.DataSource = db.consulta_ComboBox("select idAlumnos, Nombre_alumnos from alumnos;");

            cmbestudiante.DisplayMember = "Nombre_alumnos";
            cmbestudiante.ValueMember = "idAlumnos";

            //Combobox de personal
            cmbpersonal.DataSource = db.consulta_ComboBox("select Cod_personal, Nombre_personal from personal;");

            cmbpersonal.DisplayMember = "Nombre_personal";
            cmbpersonal.ValueMember = "Cod_personal";
           
            //Combobox de pagos

            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopago, Descripcion from tipo_pago;");

            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopago";
           
        }
    }
}
