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
    public partial class frmAdministrativo : Form
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();

            frmpensum p = new frmpensum();
            p.Show();

            /*pensum frm = new pensum();
            frm.MdiParent = this;
            frm.Show();
            */
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmrama p = new frmrama();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmtipopersonal p = new frmtipopersonal();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmcurso c = new frmcurso();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmciclo l = new frmciclo();
            l.Show();
        }

        private void btncredenciales_Click(object sender, EventArgs e)
        {
            frmcredenciales y = new frmcredenciales();
            y.Show();
        }
    }
}
