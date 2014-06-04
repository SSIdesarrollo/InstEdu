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
using System.Data.Odbc;

namespace SSI
{
    public partial class frmtipopago : Form
    {
        public frmtipopago()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        bool editar = false;
        string id;
        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (txbtipopago.ReadOnly == false)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("Descripcion", txbtipopago.Text);

                    if (editar)
                    {
                        db.actualizar("Tipo_pago", dict, "id_tipopago=" + id);
                        txbtipopago.Text = "";
                        txbtipopago.ReadOnly = true;
                        editar = false;

                    }
                    else
                    {

                        if (txbtipopago.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //MessageBox.Show("Error debe llenar todos los campos");

                        }
                        else
                        {
                            string numero = this.dgvtipopago.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara = null;
                            bool ingresa = true;

                            for (int x = 0; x < i; x++)
                            {

                                compara = dgvtipopago.Rows[x].Cells[1].Value.ToString();
                                if (compara.Equals(txbtipopago.Text))
                                {
                                    MessageBox.Show("El Pago " + txbtipopago.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txbtipopago.Text = "";
                                    ingresa = false;
                                }


                            }


                            if (ingresa)
                            {
                                db.insertar("Tipo_pago", dict);
                                txbtipopago.Text = "";
                                txbtipopago.ReadOnly = false;

                            }


                        }
                        dgvtipopago.DataSource = db.consulta_DataGridView("select *from Tipo_pago");
                        dgvtipopago.Columns[0].HeaderText= "ID Pago";
                        dgvtipopago.Columns[1].HeaderText = "Pago";
                       
                    }
                }
                  }
                 }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txbtipopago.ReadOnly == false)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("Descripcion", txbtipopago.Text);

                if (editar)
                {
                    db.actualizar("Tipo_pago", dict, "id_tipopago=" + id);
                    txbtipopago.Text = "";
                    txbtipopago.ReadOnly = true;
                    editar = false;

                }
                else
                {

                    if (txbtipopago.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //MessageBox.Show("Error debe llenar todos los campos");

                    }
                    /*
                else
                {
                    string numero = this.dgvtipopago.Rows.Count.ToString();
                    int i = Convert.ToInt32(numero);
                    string compara = null;
                    bool ingresa = true;

                    for (int x = 0; x < i; x++)
                    {

                        compara = dgvtipopago.Rows[x].Cells[1].Value.ToString();
                        if (compara.Equals(txbtipopago.Text))
                        {
                            MessageBox.Show("El Pago " + txbtipopago.Text + " ya existe", "Error en ingreso de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txbtipopago.Text = "";
                            ingresa = false;
                        }
                */
                    bool ingresa = true;
                    if (ingresa)
                    {
                        db.insertar("Tipo_pago", dict);
                        txbtipopago.Text = "";
                        txbtipopago.ReadOnly = false;

                    }


                }
                dgvtipopago.DataSource = db.consulta_DataGridView("select *from Tipo_pago");
                dgvtipopago.Columns[0].HeaderText = "ID Pago";
                dgvtipopago.Columns[1].HeaderText = "Pago";

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int i = dgvtipopago.CurrentRow.Index;
            id = dgvtipopago.Rows[i].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Desea eliminar el dato", "Eliminacion de datos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string condicion = "id_tipopago=" + id;
                db.eliminar("tipo_pago", condicion);
                dgvtipopago.DataSource = db.consulta_DataGridView("select *from tipo_pago");
                dgvtipopago.Columns[0].HeaderText = "ID Pago";
                dgvtipopago.Columns[1].HeaderText = "Pago";

            }
            else if (dialogResult == DialogResult.No)
            {

            }
            txbtipopago.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txbtipopago.Text = "";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
            dgvtipopago.ReadOnly = false;
            int i = dgvtipopago.CurrentRow.Index;
            id = dgvtipopago.Rows[i].Cells[0].Value.ToString();
            txbtipopago.Text = dgvtipopago.Rows[i].Cells[1].Value.ToString();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txbtipopago.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de busqueda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dgvtipopago.DataSource = db.consulta_DataGridView("SELECT Descripcion FROM tipo_pago WHERE Descripcion LIKE '" + txbtipopago.Text + "%'");
               // txbtipopago.Text = "";
               // txbtipopago.ReadOnly = true;

            }
        }

                    //actualizar();

               

                }



            }

    
//}
