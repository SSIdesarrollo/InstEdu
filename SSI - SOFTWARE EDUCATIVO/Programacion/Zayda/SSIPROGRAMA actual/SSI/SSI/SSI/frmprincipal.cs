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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
            
            frmAlumno frmAccounts = new frmAlumno();
            frmAccounts.DesktopLocation = new Point(100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd"));
            frmAlumno frm = new frmAlumno();
            frm.MdiParent = this;
            frm.Show();

            //Alumno.Location = new Point(100, 100);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            /*pensum p = new pensum();
            p.Show();*/
            
            frmpersonal frm = new frmpersonal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            frmpago pago = new frmpago();
            pago.MdiParent = this;
            pago.Show();

        }
    }
}
