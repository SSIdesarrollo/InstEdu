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

namespace SSI
{
    public partial class frmdeudasp : Form
    {
        public frmdeudasp()
        {
            InitializeComponentdeudasp();
        }
        DBConnect db = new DBConnect("proyecto");


        private void frmdeudasp_Load(object sender, EventArgs e)
        {
            cmbddp.DataSource = db.consulta_ComboBox("select id_tipopagop, Descripcion from tipo_pagop;");
            cmbddp.DisplayMember = "Descripcion";
            cmbddp.ValueMember = "id_tipopagop";

            cmbdep.DataSource = db.consulta_ComboBox("select idPersonal, Nombre_personal from personal;");
            cmbdep.DisplayMember = "Nombre_personal";
            cmbdep.ValueMember = "idPersonal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "deudoresp";
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Nombre", cmbdep.SelectedValue.ToString());
            dict.Add("Deuda", cmbddp.SelectedValue.ToString());


            db.insertar(tabla, dict);
            MessageBox.Show("La deuda se la ingresado correctamente");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdeudasp
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmdeudasp";
            this.Load += new System.EventHandler(this.frmdeudasp_Load_1);
            this.ResumeLayout(false);

        }

        private void frmdeudasp_Load_1(object sender, EventArgs e)
        {

        }
    }
}
