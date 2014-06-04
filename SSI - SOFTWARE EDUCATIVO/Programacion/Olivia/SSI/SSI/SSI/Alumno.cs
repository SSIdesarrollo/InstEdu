using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SSI
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();    
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txbnombrealumno.Visible = true;
            txbapellidoalumno.Visible = true;
            cmbdia.Visible = true;
            cmbmes.Visible = true;
            cmbaño.Visible = true;
            lblnombrealumno.Visible = true;
            lblapellidoalumno.Visible = true;
            lblfechanacimiento.Visible = true;
            lblslash1.Visible = true;
            lblslash2.Visible = true;
            txbrama.Visible = false;
            txbaño.Visible = false;
            txbcarnet.Visible = false;
            lblcarne.Visible = false;
            btnConsultar.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txbrama.Visible = true;
            txbaño.Visible = true;
            txbcarnet.Visible = true;
            lblcarne.Visible = true;
            btnConsultar.Visible = true;
            txbnombrealumno.Visible = false;
            txbapellidoalumno.Visible = false;
            cmbdia.Visible = false;
            cmbmes.Visible = false;
            cmbaño.Visible = false;
            lblnombrealumno.Visible = false;
            lblapellidoalumno.Visible = false;
            lblfechanacimiento.Visible = false;
            lblslash1.Visible = false;
            lblslash2.Visible = false;
        }
    }
}
