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
    public partial class frmpagop : Form
    {
        public frmpagop()
        {
            InitializeComponentpagop();
        }

        DBConnect db = new DBConnect("proyecto");


        bool editar = false;
        string id;
        string ide;
        string personal;
        bool busqueda1 = false;
        bool busqueda2 = false;
        private void btntipo_pago_Click(object sender, EventArgs e)
        {
            frmtipopagop frm = new frmtipopagop();
            frm.Show();
        }

        private void btndeuda_Click(object sender, EventArgs e)
        {
            frmdeudasp frm = new frmdeudasp();
            frm.Show();
        }

        private void frmpagop_Load(object sender, EventArgs e)
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


            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopagop, Descripcion from tipo_pagop;");
            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopagop";



            //reportes
            label8.Visible = false;
            dtpreportes.Visible = false;
            dgvreporte.Visible = false;

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
            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopagop, Descripcion from tipo_pagop;");
            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopagop";


            //combobox estudiates 
            //cmbestudiante2.DataSource = db.consulta_ComboBox("select idPersonal, Nombre_personal from personal;");
            //cmbestudiante2.DisplayMember = "Nombre_personal";
            //cmbestudiante2.ValueMember = "idPersonal";

            //reporte

            dgvreporte.DataSource = db.consulta_DataGridView("select * from pagop;");
            dgvreporte.Columns[0].HeaderText = "ID Pago";
            dgvreporte.Columns[1].HeaderText = "Fecha";
            dgvreporte.Columns[2].HeaderText = "Monto";
            dgvreporte.Columns[3].HeaderText = "ID Pago";
            dgvreporte.Columns[4].HeaderText = "ID Personal";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // if (tccobranza.SelectedIndex.ToString() == "0")
                {
                    editar = true;
                    txbestudiante.ReadOnly = false;
                    int i = dgvestudiante.CurrentRow.Index;
                    id = dgvestudiante.Rows[i].Cells[0].Value.ToString();
                    txbestudiante.Text = dgvestudiante.Rows[i].Cells[1].Value.ToString();
                    dgvestudiante.DataSource = db.consulta_DataGridView("select * from personal where Nombre_personal ='" + txbestudiante.Text + "';");
                }
            }
            catch { }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string query = "select idPersonal from personal where Nombre_personal ='" + txbestudiante.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dict in array)
            {
                personal = dict["idPersonal"];
                MessageBox.Show(personal);

            }


            //  if (tccobranza.SelectedIndex.ToString() == "0")
            {
                string tabla = "pagop";
                Dictionary<string, string> dict = new Dictionary<string, string>();

                dict.Add("Fecha", dtpfecha.Value.Date.ToString("yyyy-MM-dd"));
                dict.Add("Monto", txbmonto.Text);
                dict.Add("Tipo_pagop_id_tipopagop", cmbpago.SelectedValue.ToString());
                dict.Add("Personal_idPersonal", personal);





                db.insertar(tabla, dict);
                // txbfecha.Text = "";
                txbmonto.Text = "";
                txbestudiante.Text = "";

                actualizar();
            }
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
            dtpreportes.Visible = false;
            dgvreporte.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                dgvestudiante.DataSource = db.consulta_DataGridView("select * from personal where Nombre_personal ='" + txbestudiante.Text + "';");
                dgvestudiante.Columns[0].Visible = false;
                dgvestudiante.Columns[1].HeaderText = "Nombre";
                dgvestudiante.Columns[2].HeaderText = "Apellido";
                dgvestudiante.Columns[3].Visible = false;
                dgvestudiante.Columns[4].Visible = false;
                dgvestudiante.Columns[5].Visible = false;
                dgvestudiante.Columns[6].Visible = false;
                dgvestudiante.Columns[7].Visible = false;
                dgvestudiante.Columns[8].Visible = false;
                dgvestudiante.Columns[9].Visible = false;
                dgvestudiante.Columns[10].Visible = false;
                dgvestudiante.Columns[11].Visible = false;
                dgvestudiante.Columns[12].Visible = false;
                dgvestudiante.Columns[13].Visible = false;
                dgvestudiante.Columns[14].Visible = false;
                dgvestudiante.Columns[15].Visible = false;



            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                dgwdeudores.DataSource = db.consulta_DataGridView("select * from personal where Nombre_personal ='" + txbedeudores.Text + "';");
                dgwdeudores.Columns[0].Visible = false;
                dgwdeudores.Columns[1].HeaderText = "Nombre";
                dgwdeudores.Columns[2].HeaderText = "Apellido";
                dgwdeudores.Columns[3].Visible = false;
                dgwdeudores.Columns[4].Visible = false;
                dgwdeudores.Columns[5].Visible = false;
                dgwdeudores.Columns[6].Visible = false;
                dgwdeudores.Columns[7].Visible = false;
                dgwdeudores.Columns[8].Visible = false;
                dgwdeudores.Columns[9].Visible = false;
                dgwdeudores.Columns[10].Visible = false;
                dgwdeudores.Columns[11].Visible = false;
                dgwdeudores.Columns[12].Visible = false;
                dgwdeudores.Columns[13].Visible = false;
                dgwdeudores.Columns[14].Visible = false;
                dgwdeudores.Columns[15].Visible = false;
               


            }
            catch { }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (busqueda1 == true)
            {
                string query = "select idPersonal from personal where Nombre_personal ='" + txbedeudores.Text + "'";
                System.Collections.ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> dict in array)
                {
                    personal = dict["idPersonal"];
                    MessageBox.Show(personal);

                }
                string deudor;
                deudor = personal;
                dgvedeudores.DataSource = db.consulta_DataGridView("select * from deudoresp where id_deudoresp =" + deudor);
                dgvedeudores.Columns[0].HeaderText = "ID Deuda";
                dgvedeudores.Columns[1].Visible = false;
                dgvedeudores.Columns[2].HeaderText = "Deuda";
            }
            if (busqueda2 == true)
            {
                string reporte;
                reporte = dtpfecha.Value.Date.ToString("yyyy-MM-dd");
                //MessageBox.Show(reporte);
                dgvreporte.DataSource = db.consulta_DataGridView("select * from pagop where fecha ='" + reporte + "';");

            }
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

        private void btnSalirAlumno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmpagop
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmpagop";
            this.Load += new System.EventHandler(this.frmpagop_Load_1);
            this.ResumeLayout(false);

        }

        private void frmpagop_Load_1(object sender, EventArgs e)
        {

        }
    }
}
