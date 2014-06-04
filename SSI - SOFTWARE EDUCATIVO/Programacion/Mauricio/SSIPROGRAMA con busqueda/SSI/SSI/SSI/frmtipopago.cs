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
                      /*  else
                        {
                            string numero = this.dgvtipopago.Rows.Count.ToString();
                            int i = Convert.ToInt32(numero);
                            string compara=null;
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

                            }*/

                        bool ingresa = true;
                            if (ingresa)
                            {
                                db.insertar("Tipo_pago", dict);
                                txbtipopago.Text = "";
                                txbtipopago.ReadOnly = false;

                            }


                        }
                         dgvtipopago.DataSource = db.consulta_DataGridView("select *from Tipo_pago");
            }
            
           /* {
            * 
                MessageBox.Show("Debe precionar la opcion nuevo");
            }*/

        }

        

                    }

                    //actualizar();

               

                }



            }

    
//}
