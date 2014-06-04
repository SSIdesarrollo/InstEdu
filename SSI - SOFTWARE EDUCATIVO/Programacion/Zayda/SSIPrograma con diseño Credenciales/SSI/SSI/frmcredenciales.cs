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
    public partial class frmcredenciales : Form
    {
        public frmcredenciales()
        {
            InitializeComponent();
        }

        private void btnsalidacurso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncredencialalumno_Click(object sender, EventArgs e)
        {
            frmcarnealumno w = new frmcarnealumno();
            w.Show();
            this.Close();
        }

        private void btncredencialpersonal_Click(object sender, EventArgs e)
        {
            frmcarnepersonal x = new frmcarnepersonal();
            x.Show();
            this.Close();
        }
    }
}
