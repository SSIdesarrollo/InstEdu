namespace SSI
{
    partial class frmasignacioncursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblapellidoalumnoc = new System.Windows.Forms.Label();
            this.lblnombrealumnoc = new System.Windows.Forms.Label();
            this.lblalumnoramac = new System.Windows.Forms.Label();
            this.lblalumnorama = new System.Windows.Forms.Label();
            this.txbapellidoalumno = new System.Windows.Forms.TextBox();
            this.txbnombrealumno = new System.Windows.Forms.TextBox();
            this.lblapellidoalumno = new System.Windows.Forms.Label();
            this.lblnombrealumno = new System.Windows.Forms.Label();
            this.txbcarne = new System.Windows.Forms.TextBox();
            this.lblcarne = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.cmbrama1 = new System.Windows.Forms.ComboBox();
            this.cmbcurso = new System.Windows.Forms.ComboBox();
            this.cmbciclo = new System.Windows.Forms.ComboBox();
            this.cmbasignacion = new System.Windows.Forms.ComboBox();
            this.lblrama1 = new System.Windows.Forms.Label();
            this.lblcurso = new System.Windows.Forms.Label();
            this.lblciclo = new System.Windows.Forms.Label();
            this.lblasignacion = new System.Windows.Forms.Label();
            this.lblnotafinal = new System.Windows.Forms.Label();
            this.cmbnotafinal = new System.Windows.Forms.ComboBox();
            this.dgasignacioncurso = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgasignacioncurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 141;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Image = global::SSI.Properties.Resources._new;
            this.btnnuevo.Location = new System.Drawing.Point(22, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(52, 52);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.Image = global::SSI.Properties.Resources.edit2;
            this.btneditar.Location = new System.Drawing.Point(80, 24);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(52, 52);
            this.btneditar.TabIndex = 1;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Image = global::SSI.Properties.Resources.save;
            this.btnguardar.Location = new System.Drawing.Point(138, 24);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(52, 52);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::SSI.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(254, 24);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(52, 52);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Image = global::SSI.Properties.Resources.error;
            this.btneliminar.Location = new System.Drawing.Point(196, 24);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(52, 52);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSI.Properties.Resources.InstEdu_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(692, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // lblapellidoalumnoc
            // 
            this.lblapellidoalumnoc.AutoSize = true;
            this.lblapellidoalumnoc.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoalumnoc.Location = new System.Drawing.Point(201, 196);
            this.lblapellidoalumnoc.Name = "lblapellidoalumnoc";
            this.lblapellidoalumnoc.Size = new System.Drawing.Size(0, 21);
            this.lblapellidoalumnoc.TabIndex = 152;
            // 
            // lblnombrealumnoc
            // 
            this.lblnombrealumnoc.AutoSize = true;
            this.lblnombrealumnoc.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrealumnoc.Location = new System.Drawing.Point(201, 165);
            this.lblnombrealumnoc.Name = "lblnombrealumnoc";
            this.lblnombrealumnoc.Size = new System.Drawing.Size(0, 21);
            this.lblnombrealumnoc.TabIndex = 151;
            // 
            // lblalumnoramac
            // 
            this.lblalumnoramac.AutoSize = true;
            this.lblalumnoramac.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalumnoramac.Location = new System.Drawing.Point(196, 228);
            this.lblalumnoramac.Name = "lblalumnoramac";
            this.lblalumnoramac.Size = new System.Drawing.Size(0, 21);
            this.lblalumnoramac.TabIndex = 150;
            this.lblalumnoramac.Visible = false;
            // 
            // lblalumnorama
            // 
            this.lblalumnorama.AutoSize = true;
            this.lblalumnorama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalumnorama.Location = new System.Drawing.Point(103, 228);
            this.lblalumnorama.Name = "lblalumnorama";
            this.lblalumnorama.Size = new System.Drawing.Size(64, 21);
            this.lblalumnorama.TabIndex = 149;
            this.lblalumnorama.Text = "Rama:";
            this.lblalumnorama.Visible = false;
            // 
            // txbapellidoalumno
            // 
            this.txbapellidoalumno.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbapellidoalumno.Location = new System.Drawing.Point(196, 196);
            this.txbapellidoalumno.Name = "txbapellidoalumno";
            this.txbapellidoalumno.Size = new System.Drawing.Size(548, 25);
            this.txbapellidoalumno.TabIndex = 148;
            this.txbapellidoalumno.Visible = false;
            // 
            // txbnombrealumno
            // 
            this.txbnombrealumno.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombrealumno.Location = new System.Drawing.Point(196, 165);
            this.txbnombrealumno.Name = "txbnombrealumno";
            this.txbnombrealumno.Size = new System.Drawing.Size(548, 25);
            this.txbnombrealumno.TabIndex = 147;
            this.txbnombrealumno.Visible = false;
            // 
            // lblapellidoalumno
            // 
            this.lblapellidoalumno.AutoSize = true;
            this.lblapellidoalumno.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoalumno.Location = new System.Drawing.Point(103, 196);
            this.lblapellidoalumno.Name = "lblapellidoalumno";
            this.lblapellidoalumno.Size = new System.Drawing.Size(87, 21);
            this.lblapellidoalumno.TabIndex = 146;
            this.lblapellidoalumno.Text = "Apellidos:";
            this.lblapellidoalumno.Visible = false;
            // 
            // lblnombrealumno
            // 
            this.lblnombrealumno.AutoSize = true;
            this.lblnombrealumno.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrealumno.Location = new System.Drawing.Point(103, 165);
            this.lblnombrealumno.Name = "lblnombrealumno";
            this.lblnombrealumno.Size = new System.Drawing.Size(87, 21);
            this.lblnombrealumno.TabIndex = 145;
            this.lblnombrealumno.Text = "Nombres:";
            this.lblnombrealumno.Visible = false;
            // 
            // txbcarne
            // 
            this.txbcarne.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcarne.Location = new System.Drawing.Point(162, 125);
            this.txbcarne.Name = "txbcarne";
            this.txbcarne.Size = new System.Drawing.Size(180, 25);
            this.txbcarne.TabIndex = 143;
            // 
            // lblcarne
            // 
            this.lblcarne.AutoSize = true;
            this.lblcarne.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarne.Location = new System.Drawing.Point(26, 126);
            this.lblcarne.Name = "lblcarne";
            this.lblcarne.Size = new System.Drawing.Size(119, 21);
            this.lblcarne.TabIndex = 144;
            this.lblcarne.Text = "N# de Carné:";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(776, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 48);
            this.button8.TabIndex = 153;
            this.button8.Text = "Salida";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cmbrama1
            // 
            this.cmbrama1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrama1.FormattingEnabled = true;
            this.cmbrama1.Location = new System.Drawing.Point(115, 261);
            this.cmbrama1.Name = "cmbrama1";
            this.cmbrama1.Size = new System.Drawing.Size(121, 26);
            this.cmbrama1.TabIndex = 154;
            this.cmbrama1.Visible = false;
            // 
            // cmbcurso
            // 
            this.cmbcurso.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcurso.FormattingEnabled = true;
            this.cmbcurso.Location = new System.Drawing.Point(115, 293);
            this.cmbcurso.Name = "cmbcurso";
            this.cmbcurso.Size = new System.Drawing.Size(121, 26);
            this.cmbcurso.TabIndex = 155;
            this.cmbcurso.Visible = false;
            // 
            // cmbciclo
            // 
            this.cmbciclo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbciclo.FormattingEnabled = true;
            this.cmbciclo.Location = new System.Drawing.Point(115, 325);
            this.cmbciclo.Name = "cmbciclo";
            this.cmbciclo.Size = new System.Drawing.Size(121, 26);
            this.cmbciclo.TabIndex = 156;
            this.cmbciclo.Visible = false;
            // 
            // cmbasignacion
            // 
            this.cmbasignacion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbasignacion.FormattingEnabled = true;
            this.cmbasignacion.Location = new System.Drawing.Point(115, 357);
            this.cmbasignacion.Name = "cmbasignacion";
            this.cmbasignacion.Size = new System.Drawing.Size(121, 26);
            this.cmbasignacion.TabIndex = 157;
            this.cmbasignacion.Visible = false;
            // 
            // lblrama1
            // 
            this.lblrama1.AutoSize = true;
            this.lblrama1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrama1.Location = new System.Drawing.Point(12, 266);
            this.lblrama1.Name = "lblrama1";
            this.lblrama1.Size = new System.Drawing.Size(64, 21);
            this.lblrama1.TabIndex = 158;
            this.lblrama1.Text = "Rama:";
            this.lblrama1.Visible = false;
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.Location = new System.Drawing.Point(12, 298);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(58, 21);
            this.lblcurso.TabIndex = 159;
            this.lblcurso.Text = "Curso:";
            this.lblcurso.Visible = false;
            // 
            // lblciclo
            // 
            this.lblciclo.AutoSize = true;
            this.lblciclo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciclo.Location = new System.Drawing.Point(12, 330);
            this.lblciclo.Name = "lblciclo";
            this.lblciclo.Size = new System.Drawing.Size(52, 21);
            this.lblciclo.TabIndex = 160;
            this.lblciclo.Text = "Ciclo:";
            this.lblciclo.Visible = false;
            // 
            // lblasignacion
            // 
            this.lblasignacion.AutoSize = true;
            this.lblasignacion.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasignacion.Location = new System.Drawing.Point(12, 362);
            this.lblasignacion.Name = "lblasignacion";
            this.lblasignacion.Size = new System.Drawing.Size(101, 21);
            this.lblasignacion.TabIndex = 161;
            this.lblasignacion.Text = "Asignación:";
            this.lblasignacion.Visible = false;
            // 
            // lblnotafinal
            // 
            this.lblnotafinal.AutoSize = true;
            this.lblnotafinal.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotafinal.Location = new System.Drawing.Point(12, 393);
            this.lblnotafinal.Name = "lblnotafinal";
            this.lblnotafinal.Size = new System.Drawing.Size(101, 21);
            this.lblnotafinal.TabIndex = 162;
            this.lblnotafinal.Text = "Nota Final:";
            this.lblnotafinal.Visible = false;
            // 
            // cmbnotafinal
            // 
            this.cmbnotafinal.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnotafinal.FormattingEnabled = true;
            this.cmbnotafinal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbnotafinal.Location = new System.Drawing.Point(115, 393);
            this.cmbnotafinal.Name = "cmbnotafinal";
            this.cmbnotafinal.Size = new System.Drawing.Size(121, 26);
            this.cmbnotafinal.TabIndex = 163;
            this.cmbnotafinal.Visible = false;
            // 
            // dgasignacioncurso
            // 
            this.dgasignacioncurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgasignacioncurso.Location = new System.Drawing.Point(255, 261);
            this.dgasignacioncurso.Name = "dgasignacioncurso";
            this.dgasignacioncurso.Size = new System.Drawing.Size(463, 197);
            this.dgasignacioncurso.TabIndex = 164;
            this.dgasignacioncurso.Visible = false;
            // 
            // frmasignacioncursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 524);
            this.ControlBox = false;
            this.Controls.Add(this.dgasignacioncurso);
            this.Controls.Add(this.cmbnotafinal);
            this.Controls.Add(this.lblnotafinal);
            this.Controls.Add(this.lblasignacion);
            this.Controls.Add(this.lblciclo);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.lblrama1);
            this.Controls.Add(this.cmbasignacion);
            this.Controls.Add(this.cmbciclo);
            this.Controls.Add(this.cmbcurso);
            this.Controls.Add(this.cmbrama1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblapellidoalumnoc);
            this.Controls.Add(this.lblnombrealumnoc);
            this.Controls.Add(this.lblalumnoramac);
            this.Controls.Add(this.lblalumnorama);
            this.Controls.Add(this.txbapellidoalumno);
            this.Controls.Add(this.txbnombrealumno);
            this.Controls.Add(this.lblapellidoalumno);
            this.Controls.Add(this.lblnombrealumno);
            this.Controls.Add(this.txbcarne);
            this.Controls.Add(this.lblcarne);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmasignacioncursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación De Cursos";
            this.Load += new System.EventHandler(this.frmasignacioncursos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgasignacioncurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblapellidoalumnoc;
        private System.Windows.Forms.Label lblnombrealumnoc;
        private System.Windows.Forms.Label lblalumnoramac;
        private System.Windows.Forms.Label lblalumnorama;
        private System.Windows.Forms.TextBox txbapellidoalumno;
        private System.Windows.Forms.TextBox txbnombrealumno;
        private System.Windows.Forms.Label lblapellidoalumno;
        private System.Windows.Forms.Label lblnombrealumno;
        private System.Windows.Forms.TextBox txbcarne;
        private System.Windows.Forms.Label lblcarne;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cmbrama1;
        private System.Windows.Forms.ComboBox cmbcurso;
        private System.Windows.Forms.ComboBox cmbciclo;
        private System.Windows.Forms.ComboBox cmbasignacion;
        private System.Windows.Forms.Label lblrama1;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.Label lblciclo;
        private System.Windows.Forms.Label lblasignacion;
        private System.Windows.Forms.Label lblnotafinal;
        private System.Windows.Forms.ComboBox cmbnotafinal;
        private System.Windows.Forms.DataGridView dgasignacioncurso;
    }
}