using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SSI
{
    public partial class pensum : Form
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public pensum()
        {
            InitializeComponent();
        }


        private void iniciarConexion()
        {
            try
            {
                cnn.ConnectionString = "server=127.0.0.1; database=proyecto; Uid=root; pwd=;";
                cnn.Open();
                //estado = "Conexion exitosa";
                // MessageBox.Show("Conexion Exitosa :)");
            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error de Conexion, :( ");
               // estado = "Error de conexion";
            }
        }

        private void cerrarConexion()
        {
            cnn.Close();
        }

        private void limpiar() 
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try {
                iniciarConexion();
                cmd.CommandText = "insert into pensum (Descripcion,ano) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cerrarConexion();
                limpiar();
                MessageBox.Show("Inserto");
            }

            catch (MySqlException) 
            {
                MessageBox.Show("la cague");
            }

        }
    }
}
