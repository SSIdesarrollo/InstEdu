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
    public partial class frmpagoe : Form
    {
        public frmpagoe()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");

        OdbcConnection DbConnection = new OdbcConnection("DSN=" + Properties.Settings.Default.odbc);


        bool editar = false;
        bool borrar = false;
        string id;
        string ide;
        string estudiante;
        string estudiantes;
        bool busqueda1 = false;
        bool busqueda2 = false;
        bool solvente = false;
        string borrard;
        



        private void frmpagoe_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label1.Visible = false;
            txbestudiante.Visible = false;
            button1.Visible = false;
            dtpfecha.Visible = false;
            cmbpago.Visible = false;
            txbmonto.Visible = false;
            dgvestudiante.Visible = false;
            button2.Visible = false;
            fecha.Visible = false;
            pago.Visible = false;
            monto.Visible = false;
            




            gestudiantes.Visible = false;
            label6.Visible = false;
            txbedeudores.Visible = false;
            button3.Visible = false;
            dgwdeudores.Visible = false;
            btndestudiantes.Visible = false;
            dgvedeudores.Visible = false;


            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopago, Descripcion from tipo_pago;");
            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopago";



            //reportes
            label8.Visible = false;
            dtpreportes.Visible = false;
            dgvreporte.Visible = false;

            dgvdeudas.Visible = false;
            btnpagar.Visible = false;

            idsolvente.Visible = false;

            actualizar();

        }

        private void actualizardeudores()
        {
            groupBox1.Visible = false;
            label1.Visible = false;
            txbestudiante.Visible = false;
            button1.Visible = false;
            dtpfecha.Visible = false;
            cmbpago.Visible = false;
            txbmonto.Visible = false;
            dgvestudiante.Visible = false;
            button2.Visible = false;
            fecha.Visible = false;
            pago.Visible = false;
            monto.Visible = false;
            
        }

        private void actualizarpago()
        {

            gestudiantes.Visible = false;
            label6.Visible = false;
            txbedeudores.Visible = false;
            button3.Visible = false;
            dgwdeudores.Visible = false;
            btndestudiantes.Visible = false;
            dgvedeudores.Visible = false;
        }
        private void actualizar()
        {
            //combobox pago
            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopago, Descripcion from tipo_pago;");
            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopago";

            
            //combobox estudiates 
            //cmbestudiante2.DataSource = db.consulta_ComboBox("select idPersonal, Nombre_personal from personal;");
            //cmbestudiante2.DisplayMember = "Nombre_personal";
            //cmbestudiante2.ValueMember = "idPersonal";

            //reporte

            dgvreporte.DataSource = db.consulta_DataGridView("select * from pagoe;");
            dgvreporte.Columns[0].HeaderText = "ID Pago";
            dgvreporte.Columns[1].HeaderText = "Fecha";
            dgvreporte.Columns[2].HeaderText = "Monto";
            dgvreporte.Columns[3].HeaderText = "ID Pago";
            dgvreporte.Columns[4].HeaderText = "ID Personal";



                   
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label1.Visible = true;
            txbestudiante.Visible = true;
            button1.Visible = true;
            dtpfecha.Visible = true;
            cmbpago.Visible = true;
            txbmonto.Visible = true;
            dgvestudiante.Visible = true;
            button2.Visible = true;
            fecha.Visible = true;
            pago.Visible = true;
            monto.Visible = true;
            actualizarpago();

            label8.Visible = false;
            dtpreportes.Visible =false;
            dgvreporte.Visible = false;


            txbestudiante.Text = "";
            txbmonto.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
            {

                dgvestudiante.DataSource = db.consulta_DataGridView("select * from alumnos where Nombre_alumnos ='" + txbestudiante.Text + "';");
                dgvestudiante.Columns[0].Visible = false;
                dgvestudiante.Columns[1].HeaderText = "Nombre";
                dgvestudiante.Columns[2].HeaderText = "Apellido";
                dgvestudiante.Columns[3].Visible = false;
                dgvestudiante.Columns[4].Visible = false;
                dgvestudiante.Columns[5].Visible = false;
                dgvestudiante.Columns[6].Visible = false;
                dgvestudiante.Columns[7].Visible = false;
                dgvestudiante.Columns[8].HeaderText="Rama";
                dgvestudiante.Columns[9].Visible = false;
                dgvestudiante.Columns[10].Visible = false;
                dgvestudiante.Columns[11].Visible = false;
                dgvestudiante.Columns[12].Visible = false;
                dgvestudiante.Columns[13].Visible = false;
                dgvestudiante.Columns[14].Visible = false;
                dgvestudiante.Columns[15].Visible = false;
                dgvestudiante.Columns[16].Visible = false;
                dgvestudiante.Columns[17].Visible = false;
                dgvestudiante.Columns[18].Visible = false;
                dgvestudiante.Columns[19].Visible = false;

              
            }
            catch { }

        }

         private void eliminard()
          {
              string idpago;
              idpago= cmbpago.SelectedValue.ToString();

              string iddeuda;

              int i = dgvdeudas.CurrentRow.Index;
              iddeuda = dgvdeudas.Rows[i].Cells[0].Value.ToString();


              OdbcCommand CommandQuery = new OdbcCommand("DELETE FROM deudores WHERE idDeudores =" + iddeuda + " AND Tipo_pago_id_tipopago='" +idpago  + "'", DbConnection);
              OdbcDataAdapter delete = new OdbcDataAdapter();
              DbConnection.Open();
              delete.DeleteCommand = CommandQuery;
              delete.DeleteCommand.ExecuteNonQuery();
              DbConnection.Close();
      }   
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                    editar = true;
                    txbestudiante.ReadOnly = false;
                    int i = dgvestudiante.CurrentRow.Index;
                    id = dgvestudiante.Rows[i].Cells[0].Value.ToString();
                    txbestudiante.Text = dgvestudiante.Rows[i].Cells[1].Value.ToString();
                   

                    dgvdeudas.DataSource = db.consulta_DataGridView("select * from deudores where Alumnos_idAlumnos =" + id);
                    idsolvente.Text = id;
                    solventever();
                    btnpagar.Visible = true;
                    dgvdeudas.Visible = true;

                   // MessageBox.Show(id);
                    //dgvdeudas.DataSource = db.consulta_DataGridView("select * from deudores where idDeudores=" + id);
                   // dgvestudiante.DataSource = db.consulta_DataGridView("select * from alumnos where Nombre_alumnos ='" + txbedeudores.Text + "';");
                   
                   // MessageBox.Show("Deudas Pendientes");
                    
            }
            catch { }
            
         
                   
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string query = "select idAlumnos from alumnos where Nombre_alumnos ='" + txbestudiante.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                estudiante = dict["idAlumnos"];
               // MessageBox.Show(estudiante);

            }

            {
                string tabla = "pagoe";
                Dictionary<string, string> dict = new Dictionary<string, string>();

                dict.Add("Fecha", dtpfecha.Value.Date.ToString("yyyy-MM-dd"));
                dict.Add("Monto", txbmonto.Text);
                dict.Add("Tipo_pago_id_tipopago", cmbpago.SelectedValue.ToString());
                dict.Add("Alumnos_idAlumnos", estudiante);
               
                db.insertar(tabla, dict);
                txbmonto.Text = "";
                txbestudiante.Text = "";
                eliminard();




                dgvdeudas.Visible = false;
                btnpagar.Visible = false;
                dgvedeudores.ClearSelection();
                actualizar();



            }
           

        }

        private void btntipo_pago_Click(object sender, EventArgs e)
        {
            frmtipopago frm = new frmtipopago();
            frm.Show();

            frmdestudiantes frm2 = new frmdestudiantes();
            frm2.Close();

        }

        private void btndeuda_Click(object sender, EventArgs e)
        {
            frmdestudiantes frm = new frmdestudiantes();
            frm.Show();
                     
            frmtipopago frm3 = new frmtipopago();
            frm3.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                dgwdeudores.DataSource = db.consulta_DataGridView("select * from alumnos where Nombre_alumnos ='" + txbedeudores.Text + "';");
                dgwdeudores.Columns[0].Visible = false;
                dgwdeudores.Columns[1].HeaderText = "Nombre";
                dgwdeudores.Columns[2].HeaderText = "Apellido";
                dgwdeudores.Columns[3].Visible = false;
                dgwdeudores.Columns[4].Visible = false;
                dgwdeudores.Columns[5].Visible = false;
                dgwdeudores.Columns[6].Visible = false;
                dgwdeudores.Columns[7].Visible = false;
                dgwdeudores.Columns[8].HeaderText = "Rama";
                dgwdeudores.Columns[9].Visible = false;
                dgwdeudores.Columns[10].Visible = false;
                dgwdeudores.Columns[11].Visible = false;
                dgwdeudores.Columns[12].Visible = false;
                dgwdeudores.Columns[13].Visible = false;
                dgwdeudores.Columns[14].Visible = false;
                dgwdeudores.Columns[15].Visible = false;
                dgwdeudores.Columns[16].Visible = false;
                dgwdeudores.Columns[17].Visible = false;
                dgwdeudores.Columns[18].Visible = false;
                dgwdeudores.Columns[19].Visible = false;


            }
            catch { }

        }

        private void btndeudores_Click(object sender, EventArgs e)
        {
            txbedeudores.Visible = true;
          
            gestudiantes.Visible = true;
            label6.Visible = true;
            txbedeudores.Visible = true;
            button3.Visible = true;
            dgwdeudores.Visible = true;
            btndestudiantes.Visible = true;
            dgvedeudores.Visible = true;



            groupBox1.Visible = false;
            txbestudiante.Visible = false;
            button1.Visible = false;
            dgvestudiante.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            fecha.Visible = false;
            dtpfecha.Visible = false;
            pago.Visible = false;
            cmbpago.Visible = false;
            monto.Visible = false;
            txbmonto.Visible = false;

            label8.Visible = false;
            dtpreportes.Visible = false;
            dgvreporte.Visible = false;

            busqueda1 = true;

            

        /*  if(borrar==true)

          {
              
              string condicion = "id_deudores" + ultimo;
              db.eliminar("id_deudores", condicion);
             // dataGridView1.DataSource = db.consulta_DataGridView("select *from tbt_libro_diario");
          }    */

        }

        private void btndestudiantes_Click(object sender, EventArgs e)
        {
            
            
            
            
            solvente = true;

            
            
            try
            {

                int i = dgwdeudores.CurrentRow.Index;
                id = dgwdeudores.Rows[i].Cells[1].Value.ToString();
                MessageBox.Show(id);
                //txbedeudores.Text = dgvestudiante.Rows[i].Cells[1].Selected.ToString();
                dgvedeudores.DataSource = db.consulta_DataGridView("select * from deudores where Alumnos_idAlumnos=" + id);
                dgwdeudores.Columns[0].Visible = false;
                dgwdeudores.Columns[1].HeaderText = "Alumnos";
                dgwdeudores.Columns[2].HeaderText = "Deudas";


                
            }
            catch { }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (busqueda1 == true)
            {
                 string query = "select idAlumnos from alumnos where Nombre_alumnos ='" + txbedeudores.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                estudiante = dict["idAlumnos"];
                MessageBox.Show(estudiante);

            }
                string deudor;
                deudor = estudiante;
                dgvedeudores.DataSource = db.consulta_DataGridView("select * from deudores where idDeudores =" + deudor);
                dgvedeudores.Columns[0].HeaderText = "ID Deuda";
                dgvedeudores.Columns[1].Visible = false;
                dgvedeudores.Columns[2].HeaderText = "Deuda";
            }
            if (busqueda2 == true)
            {
                string reporte;
                reporte = dtpfecha.Value.Date.ToString("yyyy-MM-dd");
                //MessageBox.Show(reporte);
                dgvreporte.DataSource = db.consulta_DataGridView("select * from pagoe where fecha ='" + reporte + "';");
                
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            busqueda2 = true;
            label8.Visible = true;
            dtpreportes.Visible = true;
            dgvreporte.Visible = true;

            
            txbedeudores.Visible = false;
            gestudiantes.Visible = false;
            label6.Visible = false;
            txbedeudores.Visible = false;
            button3.Visible = false;
            dgwdeudores.Visible = false;
            btndestudiantes.Visible = false;
            dgvedeudores.Visible = false;



            groupBox1.Visible = false;
            txbestudiante.Visible = false;
            button1.Visible = false;
            dgvestudiante.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            fecha.Visible = false;
            dtpfecha.Visible = false;
            pago.Visible = false;
            cmbpago.Visible = false;
            monto.Visible = false;
            txbmonto.Visible = false;

        }

        private void dtpreportes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvreporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (busqueda2 == true)
            {
                int i = dgvreporte.CurrentRow.Index;
                id = dgvreporte.Rows[i].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string condicion = "Cod_pago=" + id;
                    db.eliminar("pagoe", condicion);
                    dgvreporte.DataSource = db.consulta_DataGridView("select *from pagoe");

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }

           
        }

        private void dgwdeudores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvestudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvedeudores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalirAlumno_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            try
            {

                editar = true;
                int i = dgvdeudas.CurrentRow.Index;
                id = dgvdeudas.Rows[i].Cells[0].Value.ToString();
                cmbpago.SelectedValue = dgvdeudas.Rows[i].Cells[2].Value.ToString();
               // MessageBox.Show(cmbpago.SelectedValue.ToString());
                

            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = dgvestudiante.CurrentRow.Index;
            id = dgvestudiante.Rows[i].Cells[0].Value.ToString();
           // txbestudiante.Text = dgvestudiante.Rows[i].Cells[1].Value.ToString();
            dgvdeudas.DataSource = db.consulta_DataGridView("select * from deudores where Alumnos_idAlumnos =" + id);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OdbcCommand CommandQuery = new OdbcCommand("DELETE FROM deudores WHERE idDeudores ='5' AND Tipo_pago_id_tipopago='3';", DbConnection);
            OdbcDataAdapter delete = new OdbcDataAdapter();
            DbConnection.Open();
            delete.DeleteCommand = CommandQuery;
            delete.DeleteCommand.ExecuteNonQuery();
            DbConnection.Close();

        }

        private void dgvdeudas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void solventever()
        {
            btnpagar.Visible = false;
            dgvdeudas.Visible = false;

            string query = "select * from deudores where Alumnos_idAlumnos='" + idsolvente.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                estudiantes = dict["idDeudores"];
               // MessageBox.Show(estudiante);

            }

            if (estudiantes == null)
            {
                MessageBox.Show("El alumno no tiene deudas");
            }
        }
       /* private void button4_Click_2(object sender, EventArgs e)
        {


            string query = "select * from deudores where Alumnos_idAlumnos='" + textBox1.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                estudiante = dict["idDeudores"];
                MessageBox.Show(estudiante);

            }

            if (estudiante==null){
                MessageBox.Show("El alumno esta solvente");
            }
        }*/

        
    }
}
