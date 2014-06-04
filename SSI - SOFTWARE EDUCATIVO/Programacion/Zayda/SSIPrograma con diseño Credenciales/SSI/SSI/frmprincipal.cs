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

            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

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
            p.MdiParent = this;
            p.Show();*/


            /*frmPersonal frm = new frmPersonal();
            frm.MdiParent = this;
            frm.Show();*/
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            frmpago pago = new frmpago();
            pago.MdiParent = this;
            pago.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAdministrativo frm = new frmAdministrativo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
