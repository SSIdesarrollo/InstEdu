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
    public partial class frmpersonal : Form
    {
        public frmpersonal()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            cmbtipopersonal.DataSource = db.consulta_ComboBox("SELECT * FROM tipo_personal");
            cmbtipopersonal.DisplayMember = "Descripcion";
            cmbtipopersonal.ValueMember = "Tipo_personal";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbtelefonopersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcelularpersonal_Click(object sender, EventArgs e)
        {

        }

        private void btnsaliralumno_Click(object sender, EventArgs e)
        {
            this.Close();
            guardado = 0;
        }

        private void btnguardarpersonal_Click(object sender, EventArgs e)
        {
            btnconsultarpersonal.Hide();
            lblcodigopersonal.Hide();
            lblcodigopersonalc.Hide();
            txbcodigopersonal.Hide();
            string tabla = "personal";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Nombre_personal", txbnombrepersonal.Text);
            dict.Add("Apellido_personal", txbapellidopersonal.Text);
            dict.Add("Fechandia", cmbdiapersonal.Text);
            dict.Add("Fechanmes", cmbmespersonal.Text);
            dict.Add("Fechanano", txbanopersonal.Text);
            dict.Add("Telefonocel_personal", txbcelularpersonal.Text);
            dict.Add("Direccion_personal", txbdireccionpersonal.Text);
            dict.Add("Telefonocasa_personal", txbtelefonopersonal.Text);
            dict.Add("Correo_personal", txbemailpersonal.Text);
            dict.Add("Ce1nombre", txbcenombre1.Text);
            dict.Add("Ce1telefono", txbcetelefono1.Text);
            dict.Add("Ce2nombre", txbcenombre2.Text);
            dict.Add("Ce2telefono", txbcetelefono2.Text);
            dict.Add("Tipo_personal_Tipo_personal", cmbtipopersonal.SelectedValue.ToString());
            if(guardado==0)
            {
                try
                {
                    db.insertar(tabla, dict);
                }
                catch
                {
                    MessageBox.Show("No se ha podido registrar nuevo empleado");
                }
            }
            if(guardado==1)
            {
                try
                {
                    string condicion = "idPersonal=" + codigopersonal;
                    db.actualizar(tabla, dict, condicion);
                }
                catch
                {
                    MessageBox.Show("No se ha podido realizar la actualizacion");
                }
                guardado = 0;
            }
            lblce.Hide();
            txbnombrepersonal.Hide(); lblnombrepersonal.Hide(); lblnombrepersonalc.Hide();
            txbapellidopersonal.Hide(); lblapellidopersonal.Hide(); lblapellidopersonalc.Hide();
            cmbdiapersonal.Hide(); lblfechanacimientopersonal.Hide(); lbldiapersonalc.Hide();
            cmbmespersonal.Hide(); lblslash1.Hide(); lblmespersonalc.Hide();
            txbanopersonal.Hide(); lblslash2.Hide(); lblañopersonalc.Hide();
            txbcelularpersonal.Hide(); lblcelularpersonal.Hide(); lblcelularpersonalc.Hide();
            txbdireccionpersonal.Hide(); lbldireccionpersonal.Hide(); lbldireccionpersonalc.Hide();
            txbtelefonopersonal.Hide(); lbltelefonopersonal.Hide(); lbltelefonopersonalc.Hide();
            txbemailpersonal.Hide(); lblemailpersonal.Hide(); lblemailpersonalc.Hide();
            txbcenombre1.Hide(); lblcenombre1.Hide(); lblcenombre1c.Hide();
            txbcetelefono1.Hide(); lblcetelefono1.Hide(); lblcetelefono1c.Hide();
            txbcenombre2.Hide(); lblcenombre2.Hide(); lblcenombre2c.Hide();
            txbcetelefono2.Hide(); lblcetelefono2.Hide(); lblcetelefono2c.Hide();
            cmbtipopersonal.Hide(); lbltipopersonal.Hide(); lbltipopersonalc.Hide();
            lblcodigopersonalc.Text = "";
            lblnombrepersonalc.Text = "";
            lblapellidopersonalc.Text = "";
            lbldiapersonalc.Text = "";
            lblmespersonalc.Text = "";
            lblañopersonalc.Text = "";
            lblcelularpersonalc.Text = "";
            lbldireccionpersonalc.Text = "";
            lbltelefonopersonalc.Text = "";
            lblemailpersonalc.Text = "";
            lblcenombre1c.Text = "";
            lblcetelefono1c.Text = "";
            lblcenombre2c.Text = "";
            lblcetelefono2c.Text = "";
            lbltipopersonalc.Text = "";
            cmbdiapersonal.Text = "";
            cmbmespersonal.Text = "";

            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevopersonal_Click(object sender, EventArgs e)
        {
            guardado = 0;
            dgpersonal.Visible = false;
            lblcodigopersonalc.Text = "0";
            btnconsultarpersonal.Hide();
            lblcodigopersonal.Hide();
            lblcodigopersonalc.Hide();
            txbcodigopersonal.Hide();
            txbnombrepersonal.Clear();
            txbapellidopersonal.Clear();
            txbanopersonal.Clear();
            txbcelularpersonal.Clear();
            txbdireccionpersonal.Clear();
            txbtelefonopersonal.Clear();
            txbemailpersonal.Clear();
            txbcenombre1.Clear();
            txbcetelefono1.Clear();
            txbcenombre2.Clear();
            txbcetelefono2.Clear();
            lblce.Show();
            txbnombrepersonal.Show(); lblnombrepersonal.Show();
            txbapellidopersonal.Show(); lblapellidopersonal.Show();
            cmbdiapersonal.Show(); lblfechanacimientopersonal.Show();
            cmbmespersonal.Show(); lblslash1.Show();
            txbanopersonal.Show(); lblslash2.Show();
            txbcelularpersonal.Show(); lblcelularpersonal.Show();
            txbdireccionpersonal.Show(); lbldireccionpersonal.Show();
            txbtelefonopersonal.Show(); lbltelefonopersonal.Show();
            txbemailpersonal.Show(); lblemailpersonal.Show();
            txbcenombre1.Show(); lblcenombre1.Show();
            txbcetelefono1.Show(); lblcetelefono1.Show();
            txbcenombre2.Show(); lblcenombre2.Show();
            txbcetelefono2.Show(); lblcetelefono2.Show();
            cmbtipopersonal.Show(); lbltipopersonal.Show();
            lblcodigopersonal.Hide();
            lblcodigopersonalc.Hide(); lblcodigopersonalc.Text = "";
            lblnombrepersonalc.Hide(); lblnombrepersonalc.Text = "";
            lblapellidopersonalc.Hide(); lblapellidopersonalc.Text = "";
            lbldiapersonalc.Hide(); lbldiapersonalc.Text = "";
            lblmespersonalc.Hide(); lblmespersonalc.Text = "";
            lblañopersonalc.Hide(); lblañopersonalc.Text = "";
            lblcelularpersonalc.Hide(); lblcelularpersonalc.Text = "";
            lbldireccionpersonalc.Hide(); lbldireccionpersonalc.Text = "";
            lbltelefonopersonalc.Hide(); lbltelefonopersonalc.Text = "";
            lblemailpersonalc.Hide(); lblemailpersonalc.Text = "";
            lblcenombre1c.Hide(); lblcenombre1c.Text = "";
            lblcetelefono1c.Hide(); lblcetelefono1c.Text = "";
            lblcenombre2c.Hide(); lblcenombre2c.Text = "";
            lblcetelefono2c.Hide(); lblcetelefono2c.Text = "";
            lbltipopersonalc.Hide(); lbltipopersonalc.Text = "";
            cmbdiapersonal.Text = "";
            cmbmespersonal.Text = "";
        }

        private void cmbtipopersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnbuscarpersonal_Click(object sender, EventArgs e)
        {
            dgpersonal.Visible = true;
            lblcodigopersonalc.Text = "";
            lblnombrepersonalc.Text = "";
            lblapellidopersonalc.Text = "";
            lbldiapersonalc.Text = "";
            lblmespersonalc.Text = "";
            lblañopersonalc.Text = "";
            lblcelularpersonalc.Text = "";
            lbldireccionpersonalc.Text = "";
            lbltelefonopersonalc.Text = "";
            lblemailpersonalc.Text = "";
            lblcenombre1c.Text = "";
            lblcetelefono1c.Text = "";
            lblcenombre2c.Text = "";
            lblcetelefono2c.Text = "";
            lbltipopersonalc.Text = "";
            cmbdiapersonal.Text = "";
            cmbmespersonal.Text = ""; 
            lblcodigopersonalc.Text = "0";
            lblcodigopersonal.Show();
            txbcodigopersonal.Show();
            btnconsultarpersonal.Show();
            lblce.Hide();
            lblnombrepersonalc.Hide(); lblnombrepersonal.Hide();
            lblapellidopersonalc.Hide(); lblapellidopersonal.Hide();
            lbldiapersonalc.Hide(); lblfechanacimientopersonal.Hide();
            lblmespersonalc.Hide(); lblslash1.Hide();
            lblañopersonalc.Hide(); lblslash2.Hide();
            lblcelularpersonalc.Hide(); lblcelularpersonal.Hide();
            lbldireccionpersonalc.Hide(); lbldireccionpersonal.Hide();
            lbltelefonopersonalc.Hide(); lbltelefonopersonal.Hide();
            lblemailpersonalc.Hide(); lblemailpersonal.Hide();
            lblcenombre1c.Hide(); lblcenombre1.Hide();
            lblcetelefono1c.Hide(); lblcetelefono1.Hide();
            lblcenombre2c.Hide(); lblcenombre2.Hide();
            lblcetelefono2c.Hide(); lblcetelefono2.Hide();
            lbltipopersonalc.Hide(); lbltipopersonal.Hide();
            lblnombrepersonalc.Text = "";
            lblapellidopersonalc.Text = "";
            lbldiapersonalc.Text = "";
            lblmespersonalc.Text = "";
            lblañopersonalc.Text = "";
            lblcelularpersonalc.Text = "";
            lbldireccionpersonalc.Text = "";
            lbltelefonopersonalc.Text = "";
            lblemailpersonalc.Text = "";
            lblcenombre1c.Text = "";
            lblcetelefono1c.Text = "";
            lblcenombre2c.Text = "";
            lblcetelefono2c.Text = "";
            lbltipopersonalc.Text = "";
            txbnombrepersonal.Hide(); lblnombrepersonal.Hide();
            txbapellidopersonal.Hide(); lblapellidopersonal.Hide();
            cmbdiapersonal.Hide(); lblfechanacimientopersonal.Hide();
            cmbmespersonal.Hide(); lblslash1.Hide();
            txbanopersonal.Hide(); lblslash2.Hide();
            txbcelularpersonal.Hide(); lblcelularpersonal.Hide();
            txbdireccionpersonal.Hide(); lbldireccionpersonal.Hide();
            txbtelefonopersonal.Hide(); lbltelefonopersonal.Hide();
            txbemailpersonal.Hide(); lblemailpersonal.Hide();
            txbcenombre1.Hide(); lblcenombre1.Hide();
            txbcetelefono1.Hide(); lblcetelefono1.Hide();
            txbcenombre2.Hide(); lblcenombre2.Hide();
            txbcetelefono2.Hide(); lblcetelefono2.Hide();
            cmbtipopersonal.Hide(); lbltipopersonal.Hide();

            //DataGridView
            string query = "select idPersonal as 'Codigo Personal',Nombre_personal as 'Nombres Personal', Apellido_personal as 'Apellidos Personal', Fechandia as 'Dia De Nacimiento', Fechanmes as 'Mes De Nacimiento', Fechanano as 'Año De Nacimiento', Telefonocel_personal as 'Telefono Personal', Direccion_personal as 'Direccion Personal', Telefonocasa_personal as 'Telefono Casa', Correo_personal as 'Correo Electronico', Ce1nombre as 'Emergencia 1', Ce1telefono as 'Telefono Emergencia 1', Ce2nombre as 'Emergencia 2', Ce2telefono as 'Telefono Emergencia 2', Tipo_personal_Tipo_personal as 'Tipo Personal' from personal order by idPersonal";
            dgpersonal.DataSource = db.consulta_DataGridView(query);

        }
        string codigopersonal = "";
        private void btnconsultarpersonal_Click(object sender, EventArgs e)
        {
            dgpersonal.Visible = false;
            btnconsultarpersonal.Hide();
            lblcodigopersonalc.Text = txbcodigopersonal.Text;
            txbcodigopersonal.Hide();
            lblcodigopersonalc.Show();
            codigopersonal = txbcodigopersonal.Text;
            try
            {
                System.Collections.ArrayList array = db.consultar("select * from personal where idPersonal=" + codigopersonal);
                foreach(Dictionary<string,string> dict in array)
                {
                    lblnombrepersonalc.Text = dict["Nombre_personal"];
                    lblapellidopersonalc.Text = dict["Apellido_personal"];
                    lbldiapersonalc.Text = dict["Fechandia"];
                    lblmespersonalc.Text = dict["Fechanmes"];
                    lblañopersonalc.Text = dict["Fechanano"];
                    lblcelularpersonalc.Text = dict["Telefonocel_personal"];
                    lbldireccionpersonalc.Text = dict["Direccion_personal"];
                    lbltelefonopersonalc.Text = dict["Telefonocasa_personal"];
                    lblemailpersonalc.Text = dict["Correo_personal"];
                    lblcenombre1c.Text = dict["Ce1nombre"];
                    lblcetelefono1c.Text = dict["Ce1telefono"];
                    lblcenombre2c.Text = dict["Ce2nombre"];
                    lblcetelefono2c.Text = dict["Ce2telefono"];
                    lbltipopersonalc.Text = dict["Tipo_personal_Tipo_personal"];
                }
            }
            catch
            {
                MessageBox.Show(" No existe coincidencia en registro para codigo " + codigopersonal);
            }
            txbcodigopersonal.Clear();
            lblce.Show();
            lblnombrepersonalc.Show(); lblnombrepersonal.Show();
            lblapellidopersonalc.Show(); lblapellidopersonal.Show();
            lbldiapersonalc.Show(); lblfechanacimientopersonal.Show();
            lblmespersonalc.Show(); lblslash1.Show();
            lblañopersonalc.Show(); lblslash2.Show();
            lblcelularpersonalc.Show(); lblcelularpersonal.Show();
            lbldireccionpersonalc.Show(); lbldireccionpersonal.Show();
            lbltelefonopersonalc.Show(); lbltelefonopersonal.Show();
            lblemailpersonalc.Show(); lblemailpersonal.Show();
            lblcenombre1c.Show(); lblcenombre1.Show();
            lblcetelefono1c.Show(); lblcetelefono1.Show();
            lblcenombre2c.Show(); lblcenombre2.Show();
            lblcetelefono2c.Show(); lblcetelefono2.Show();
            lbltipopersonalc.Show(); lbltipopersonal.Show();
        }

        int guardado = 0;

        private void btneditarpersonal_Click(object sender, EventArgs e)
        {
            guardado = 1;
            btnconsultarpersonal.Hide();
            txbnombrepersonal.Clear(); txbnombrepersonal.Text = lblnombrepersonalc.Text;
            txbapellidopersonal.Clear(); txbapellidopersonal.Text = lblapellidopersonalc.Text;
            txbanopersonal.Clear(); txbanopersonal.Text = lblañopersonalc.Text;
            txbcelularpersonal.Clear(); txbcelularpersonal.Text = lblañopersonalc.Text;
            txbdireccionpersonal.Clear(); txbdireccionpersonal.Text = lbldireccionpersonalc.Text;
            txbtelefonopersonal.Clear(); txbtelefonopersonal.Text = lbltelefonopersonalc.Text;
            txbemailpersonal.Clear(); txbemailpersonal.Text = lblemailpersonalc.Text;
            txbcenombre1.Clear(); txbcenombre1.Text = lblcenombre1c.Text;
            txbcetelefono1.Clear(); txbcetelefono1.Text = lblcetelefono1c.Text;
            txbcenombre2.Clear(); txbcenombre2.Text = lblcenombre2c.Text;
            txbcetelefono2.Clear(); txbcetelefono2.Text = lblcetelefono2c.Text;
            cmbdiapersonal.SelectedItem = lbldiapersonalc.Text;
            cmbmespersonal.SelectedItem = lblmespersonalc.Text;
            lblce.Show();
            txbnombrepersonal.Show(); lblnombrepersonal.Show();
            txbapellidopersonal.Show(); lblapellidopersonal.Show();
            cmbdiapersonal.Show(); lblfechanacimientopersonal.Show();
            cmbmespersonal.Show(); lblslash1.Show();
            txbanopersonal.Show(); lblslash2.Show();
            txbcelularpersonal.Show(); lblcelularpersonal.Show();
            txbdireccionpersonal.Show(); lbldireccionpersonal.Show();
            txbtelefonopersonal.Show(); lbltelefonopersonal.Show();
            txbemailpersonal.Show(); lblemailpersonal.Show();
            txbcenombre1.Show(); lblcenombre1.Show();
            txbcetelefono1.Show(); lblcetelefono1.Show();
            txbcenombre2.Show(); lblcenombre2.Show();
            txbcetelefono2.Show(); lblcetelefono2.Show();
            cmbtipopersonal.Show(); lbltipopersonal.Show();
            lblnombrepersonalc.Hide();
            lblapellidopersonalc.Hide();
            lbldiapersonalc.Hide();
            lblmespersonalc.Hide();
            lblañopersonalc.Hide();
            lblcelularpersonalc.Hide();
            lbldireccionpersonalc.Hide();
            lbltelefonopersonalc.Hide();
            lblemailpersonalc.Hide();
            lblcenombre1c.Hide();
            lblcetelefono1c.Hide();
            lblcenombre2c.Hide();
            lblcetelefono2c.Hide();
            lbltipopersonalc.Hide();
            lblnombrepersonalc.Text = "";
            lblapellidopersonalc.Text = "";
            lbldiapersonalc.Text = "";
            lblmespersonalc.Text = "";
            lblañopersonalc.Text = "";
            lblcelularpersonalc.Text = "";
            lbldireccionpersonalc.Text = "";
            lbltelefonopersonalc.Text = "";
            lblemailpersonalc.Text = "";
            lblcenombre1c.Text = "";
            lblcetelefono1c.Text = "";
            lblcenombre2c.Text = "";
            lblcetelefono2c.Text = "";
            lbltipopersonalc.Text = "";
            lblcodigopersonal.Show();
        }

        private void btneliminarpersonal_Click(object sender, EventArgs e)
        {
            btnconsultarpersonal.Hide();
            lblcodigopersonal.Hide();
            lblcodigopersonalc.Hide();
            txbcodigopersonal.Hide();
            string tabla = "personal";
            string condicion = "idPersonal=" + codigopersonal;
            db.eliminar(tabla, condicion);
            lblce.Hide();
            txbnombrepersonal.Hide(); lblnombrepersonal.Hide(); lblnombrepersonalc.Hide();
            txbapellidopersonal.Hide(); lblapellidopersonal.Hide(); lblapellidopersonalc.Hide();
            cmbdiapersonal.Hide(); lblfechanacimientopersonal.Hide(); lbldiapersonalc.Hide();
            cmbmespersonal.Hide(); lblslash1.Hide(); lblmespersonalc.Hide();
            txbanopersonal.Hide(); lblslash2.Hide(); lblañopersonalc.Hide();
            txbcelularpersonal.Hide(); lblcelularpersonal.Hide(); lblcelularpersonalc.Hide();
            txbdireccionpersonal.Hide(); lbldireccionpersonal.Hide(); lbldireccionpersonalc.Hide();
            txbtelefonopersonal.Hide(); lbltelefonopersonal.Hide(); lbltelefonopersonalc.Hide();
            txbemailpersonal.Hide(); lblemailpersonal.Hide(); lblemailpersonalc.Hide();
            txbcenombre1.Hide(); lblcenombre1.Hide(); lblcenombre1c.Hide();
            txbcetelefono1.Hide(); lblcetelefono1.Hide(); lblcetelefono1c.Hide();
            txbcenombre2.Hide(); lblcenombre2.Hide(); lblcenombre2c.Hide();
            txbcetelefono2.Hide(); lblcetelefono2.Hide(); lblcetelefono2c.Hide();
            cmbtipopersonal.Hide(); lbltipopersonal.Hide(); lbltipopersonalc.Hide();
        }

        private void cmbdiapersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcodigopersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
