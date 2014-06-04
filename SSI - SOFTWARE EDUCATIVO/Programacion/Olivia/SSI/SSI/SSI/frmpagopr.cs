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
    public partial class frmpagopr : Form
    {
        public frmpagopr()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("proyecto");


        bool editar = false;
        string id;
        string ide;
        string personal;
        private void frmpagop_Load(object sender, EventArgs e)
        {
            try
            {
                actualizar();
            }
            catch { }
        }
        private void actualizar()
        {

            //combobox pago
            cmbpago.DataSource = db.consulta_ComboBox("select id_tipopagop, Descripcion from tipo_pagop;");
            cmbpago.DisplayMember = "Descripcion";
            cmbpago.ValueMember = "id_tipopagop";
            //combobox estudiates 
            cmbestudiante2.DataSource = db.consulta_ComboBox("select idPersonal, Nombre_personal from personal;");
            cmbestudiante2.DisplayMember = "Nombre_personal";
            cmbestudiante2.ValueMember = "idPersonal";

            //reporte

            dgvreporte.DataSource = db.consulta_DataGridView("select * from pagop;");
            dgvreporte.Columns[0].HeaderText = "ID Pago";
            dgvreporte.Columns[1].HeaderText = "Fecha";
            dgvreporte.Columns[2].HeaderText = "Monto";
            dgvreporte.Columns[3].HeaderText = "ID Pago";
            dgvreporte.Columns[4].HeaderText = "ID Personal";
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


            if (tccobranza.SelectedIndex.ToString() == "0")
            {
                string tabla = "pagop";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                
                dict.Add("Fecha", dtpfecha.Value.Date.ToString("yyyy-MM-dd"));
                dict.Add("Monto", txbmonto.Text);
                dict.Add("Personal_idPersonal", personal);
                dict.Add("tipo_pagop_id_tipopagop", cmbpago.SelectedValue.ToString());



                db.insertar(tabla, dict);
                // txbfecha.Text = "";
                txbmonto.Text = "";
                txbestudiante.Text = "";

                actualizar();



            }
            if (tccobranza.SelectedIndex.ToString() == "1")
            {
                string deudor;
                deudor = cmbestudiante2.SelectedValue.ToString();


            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (tccobranza.SelectedIndex.ToString() == "1")
            {
                string deudor;
                deudor = cmbestudiante2.SelectedValue.ToString();
                dgvdeudores.DataSource = db.consulta_DataGridView("select * from deudoresp where Nombre =" + deudor);
                dgvdeudores.Columns[0].HeaderText = "ID Deuda";
                dgvdeudores.Columns[1].Visible = false;
                dgvdeudores.Columns[2].HeaderText = "Deuda";
                //MessageBox.Show("pagos");

            }
            if (tccobranza.SelectedIndex.ToString() == "2")
            {

                string reporte;
                reporte = dtpfecha.Value.Date.ToString("yyyy-MM-dd");
                //MessageBox.Show(reporte);
                dgvreporte.DataSource = db.consulta_DataGridView("select * from pagop where fecha ='" + reporte + "';");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tccobranza.SelectedIndex.ToString() == "0")
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

        private void btndeuda_Click(object sender, EventArgs e)
        {
            frmdeudasp frm = new frmdeudasp();
            frm.Show();

        }

        private void btntipo_pago_Click(object sender, EventArgs e)
        {
            frmtipopagop frm = new frmtipopagop();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
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
                dgvestudiante.Columns[8].Visible= false;
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
    }
}
