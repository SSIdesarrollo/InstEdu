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
    public partial class frmmcobranza : Form
    {
        public frmmcobranza()
        {
            InitializeComponent();
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            frmpagoe frm = new frmpagoe();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmpagop frm = new frmpagop();
            frm.Show();

        }

        private void btnSalirAlumno_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
