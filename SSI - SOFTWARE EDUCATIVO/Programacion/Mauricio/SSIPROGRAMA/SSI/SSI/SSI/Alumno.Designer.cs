namespace SSI
{
    partial class frmAlumno
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
            this.lblnombrealumno = new System.Windows.Forms.Label();
            this.lblapellidoalumno = new System.Windows.Forms.Label();
            this.txbnombrealumno = new System.Windows.Forms.TextBox();
            this.txbapellidoalumno = new System.Windows.Forms.TextBox();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.lblslash1 = new System.Windows.Forms.Label();
            this.lblslash2 = new System.Windows.Forms.Label();
            this.btnSalirAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcarne = new System.Windows.Forms.Label();
            this.txbrama = new System.Windows.Forms.TextBox();
            this.txbaño = new System.Windows.Forms.TextBox();
            this.txbcarnet = new System.Windows.Forms.TextBox();
            this.cmbdia = new System.Windows.Forms.ComboBox();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.lblalumnorama = new System.Windows.Forms.Label();
            this.cmbalumnorama = new System.Windows.Forms.ComboBox();
            this.lblalumnociclo = new System.Windows.Forms.Label();
            this.lbljornada = new System.Windows.Forms.Label();
            this.cmbalumnociclo = new System.Windows.Forms.ComboBox();
            this.txbdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txbcorreoelectronico = new System.Windows.Forms.TextBox();
            this.lblcorreoelectronico = new System.Windows.Forms.Label();
            this.txtalumnoaño = new System.Windows.Forms.TextBox();
            this.lblcontactosemergencia = new System.Windows.Forms.Label();
            this.lbltelefono1 = new System.Windows.Forms.Label();
            this.txbtelefono1 = new System.Windows.Forms.TextBox();
            this.txbcelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txbtelefono2 = new System.Windows.Forms.TextBox();
            this.lbltelefono2 = new System.Windows.Forms.Label();
            this.txbnombre1 = new System.Windows.Forms.TextBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.txbnombre2 = new System.Windows.Forms.TextBox();
            this.lblnombre2 = new System.Windows.Forms.Label();
            this.txbtelefono3 = new System.Windows.Forms.TextBox();
            this.lbltelefono3 = new System.Windows.Forms.Label();
            this.cmbjornada = new System.Windows.Forms.ComboBox();
            this.lblnumcarne = new System.Windows.Forms.Label();
            this.lblcarnerama = new System.Windows.Forms.Label();
            this.lblcarneaño = new System.Windows.Forms.Label();
            this.lblcarnealumno = new System.Windows.Forms.Label();
            this.lblguion1 = new System.Windows.Forms.Label();
            this.lblguion2 = new System.Windows.Forms.Label();
            this.dgalumno = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalumno)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Image = global::SSI.Properties.Resources._new;
            this.btnnuevo.Location = new System.Drawing.Point(22, 24);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(52, 52);
            this.btnnuevo.TabIndex = 2;
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
            this.btneditar.TabIndex = 4;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Image = global::SSI.Properties.Resources.save;
            this.btnguardar.Location = new System.Drawing.Point(138, 24);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(52, 52);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Image = global::SSI.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(254, 24);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(52, 52);
            this.btnbuscar.TabIndex = 3;
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
            this.btneliminar.TabIndex = 1;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // lblnombrealumno
            // 
            this.lblnombrealumno.AutoSize = true;
            this.lblnombrealumno.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrealumno.Location = new System.Drawing.Point(22, 165);
            this.lblnombrealumno.Name = "lblnombrealumno";
            this.lblnombrealumno.Size = new System.Drawing.Size(87, 21);
            this.lblnombrealumno.TabIndex = 6;
            this.lblnombrealumno.Text = "Nombres:";
            this.lblnombrealumno.Visible = false;
            // 
            // lblapellidoalumno
            // 
            this.lblapellidoalumno.AutoSize = true;
            this.lblapellidoalumno.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoalumno.Location = new System.Drawing.Point(22, 196);
            this.lblapellidoalumno.Name = "lblapellidoalumno";
            this.lblapellidoalumno.Size = new System.Drawing.Size(87, 21);
            this.lblapellidoalumno.TabIndex = 7;
            this.lblapellidoalumno.Text = "Apellidos:";
            this.lblapellidoalumno.Visible = false;
            // 
            // txbnombrealumno
            // 
            this.txbnombrealumno.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombrealumno.Location = new System.Drawing.Point(115, 165);
            this.txbnombrealumno.Name = "txbnombrealumno";
            this.txbnombrealumno.Size = new System.Drawing.Size(548, 25);
            this.txbnombrealumno.TabIndex = 8;
            this.txbnombrealumno.Visible = false;
            // 
            // txbapellidoalumno
            // 
            this.txbapellidoalumno.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbapellidoalumno.Location = new System.Drawing.Point(115, 196);
            this.txbapellidoalumno.Name = "txbapellidoalumno";
            this.txbapellidoalumno.Size = new System.Drawing.Size(548, 25);
            this.txbapellidoalumno.TabIndex = 9;
            this.txbapellidoalumno.Visible = false;
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechanacimiento.Location = new System.Drawing.Point(22, 234);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(188, 21);
            this.lblfechanacimiento.TabIndex = 10;
            this.lblfechanacimiento.Text = "Fecha De Nacimiento:";
            this.lblfechanacimiento.Visible = false;
            // 
            // lblslash1
            // 
            this.lblslash1.AutoSize = true;
            this.lblslash1.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslash1.Location = new System.Drawing.Point(294, 223);
            this.lblslash1.Name = "lblslash1";
            this.lblslash1.Size = new System.Drawing.Size(29, 41);
            this.lblslash1.TabIndex = 14;
            this.lblslash1.Text = "/";
            this.lblslash1.Visible = false;
            // 
            // lblslash2
            // 
            this.lblslash2.AutoSize = true;
            this.lblslash2.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslash2.Location = new System.Drawing.Point(500, 223);
            this.lblslash2.Name = "lblslash2";
            this.lblslash2.Size = new System.Drawing.Size(29, 41);
            this.lblslash2.TabIndex = 15;
            this.lblslash2.Text = "/";
            this.lblslash2.Visible = false;
            // 
            // btnSalirAlumno
            // 
            this.btnSalirAlumno.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlumno.Location = new System.Drawing.Point(670, 521);
            this.btnSalirAlumno.Name = "btnSalirAlumno";
            this.btnSalirAlumno.Size = new System.Drawing.Size(100, 40);
            this.btnSalirAlumno.TabIndex = 17;
            this.btnSalirAlumno.Text = "Salir";
            this.btnSalirAlumno.UseVisualStyleBackColor = true;
            this.btnSalirAlumno.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSI.Properties.Resources.InstEdu_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(603, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblcarne
            // 
            this.lblcarne.AutoSize = true;
            this.lblcarne.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarne.Location = new System.Drawing.Point(22, 128);
            this.lblcarne.Name = "lblcarne";
            this.lblcarne.Size = new System.Drawing.Size(119, 21);
            this.lblcarne.TabIndex = 20;
            this.lblcarne.Text = "N# de Carné:";
            this.lblcarne.Visible = false;
            // 
            // txbrama
            // 
            this.txbrama.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbrama.Location = new System.Drawing.Point(158, 127);
            this.txbrama.Name = "txbrama";
            this.txbrama.Size = new System.Drawing.Size(61, 25);
            this.txbrama.TabIndex = 21;
            this.txbrama.Visible = false;
            // 
            // txbaño
            // 
            this.txbaño.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbaño.Location = new System.Drawing.Point(229, 127);
            this.txbaño.Name = "txbaño";
            this.txbaño.Size = new System.Drawing.Size(61, 25);
            this.txbaño.TabIndex = 22;
            this.txbaño.Visible = false;
            // 
            // txbcarnet
            // 
            this.txbcarnet.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcarnet.Location = new System.Drawing.Point(301, 127);
            this.txbcarnet.Name = "txbcarnet";
            this.txbcarnet.Size = new System.Drawing.Size(61, 25);
            this.txbcarnet.TabIndex = 23;
            this.txbcarnet.Visible = false;
            // 
            // cmbdia
            // 
            this.cmbdia.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdia.FormattingEnabled = true;
            this.cmbdia.Items.AddRange(new object[] {
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
            "31"});
            this.cmbdia.Location = new System.Drawing.Point(227, 231);
            this.cmbdia.Name = "cmbdia";
            this.cmbdia.Size = new System.Drawing.Size(63, 26);
            this.cmbdia.TabIndex = 25;
            this.cmbdia.Visible = false;
            // 
            // cmbmes
            // 
            this.cmbmes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo ",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbmes.Location = new System.Drawing.Point(329, 231);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(166, 26);
            this.cmbmes.TabIndex = 26;
            this.cmbmes.Visible = false;
            // 
            // lblalumnorama
            // 
            this.lblalumnorama.AutoSize = true;
            this.lblalumnorama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalumnorama.Location = new System.Drawing.Point(22, 363);
            this.lblalumnorama.Name = "lblalumnorama";
            this.lblalumnorama.Size = new System.Drawing.Size(64, 21);
            this.lblalumnorama.TabIndex = 28;
            this.lblalumnorama.Text = "Rama:";
            this.lblalumnorama.Visible = false;
            // 
            // cmbalumnorama
            // 
            this.cmbalumnorama.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbalumnorama.FormattingEnabled = true;
            this.cmbalumnorama.Location = new System.Drawing.Point(115, 362);
            this.cmbalumnorama.Name = "cmbalumnorama";
            this.cmbalumnorama.Size = new System.Drawing.Size(121, 26);
            this.cmbalumnorama.TabIndex = 29;
            this.cmbalumnorama.Visible = false;
            this.cmbalumnorama.SelectedIndexChanged += new System.EventHandler(this.cmbalumnorama_SelectedIndexChanged);
            // 
            // lblalumnociclo
            // 
            this.lblalumnociclo.AutoSize = true;
            this.lblalumnociclo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalumnociclo.Location = new System.Drawing.Point(22, 398);
            this.lblalumnociclo.Name = "lblalumnociclo";
            this.lblalumnociclo.Size = new System.Drawing.Size(52, 21);
            this.lblalumnociclo.TabIndex = 30;
            this.lblalumnociclo.Text = "Ciclo:";
            this.lblalumnociclo.Visible = false;
            // 
            // lbljornada
            // 
            this.lbljornada.AutoSize = true;
            this.lbljornada.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljornada.Location = new System.Drawing.Point(22, 430);
            this.lbljornada.Name = "lbljornada";
            this.lbljornada.Size = new System.Drawing.Size(79, 21);
            this.lbljornada.TabIndex = 31;
            this.lbljornada.Text = "Jornada:";
            this.lbljornada.Visible = false;
            // 
            // cmbalumnociclo
            // 
            this.cmbalumnociclo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbalumnociclo.FormattingEnabled = true;
            this.cmbalumnociclo.Location = new System.Drawing.Point(115, 395);
            this.cmbalumnociclo.Name = "cmbalumnociclo";
            this.cmbalumnociclo.Size = new System.Drawing.Size(121, 26);
            this.cmbalumnociclo.TabIndex = 32;
            this.cmbalumnociclo.Visible = false;
            // 
            // txbdireccion
            // 
            this.txbdireccion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbdireccion.Location = new System.Drawing.Point(115, 297);
            this.txbdireccion.Name = "txbdireccion";
            this.txbdireccion.Size = new System.Drawing.Size(548, 25);
            this.txbdireccion.TabIndex = 34;
            this.txbdireccion.Visible = false;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(22, 297);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(87, 21);
            this.lbldireccion.TabIndex = 33;
            this.lbldireccion.Text = "Dirección:";
            this.lbldireccion.Visible = false;
            // 
            // txbcorreoelectronico
            // 
            this.txbcorreoelectronico.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcorreoelectronico.Location = new System.Drawing.Point(115, 329);
            this.txbcorreoelectronico.Name = "txbcorreoelectronico";
            this.txbcorreoelectronico.Size = new System.Drawing.Size(548, 25);
            this.txbcorreoelectronico.TabIndex = 36;
            this.txbcorreoelectronico.Visible = false;
            // 
            // lblcorreoelectronico
            // 
            this.lblcorreoelectronico.AutoSize = true;
            this.lblcorreoelectronico.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreoelectronico.Location = new System.Drawing.Point(22, 329);
            this.lblcorreoelectronico.Name = "lblcorreoelectronico";
            this.lblcorreoelectronico.Size = new System.Drawing.Size(67, 21);
            this.lblcorreoelectronico.TabIndex = 35;
            this.lblcorreoelectronico.Text = "E-mail:";
            this.lblcorreoelectronico.Visible = false;
            // 
            // txtalumnoaño
            // 
            this.txtalumnoaño.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalumnoaño.Location = new System.Drawing.Point(535, 233);
            this.txtalumnoaño.Name = "txtalumnoaño";
            this.txtalumnoaño.Size = new System.Drawing.Size(63, 25);
            this.txtalumnoaño.TabIndex = 37;
            this.txtalumnoaño.Visible = false;
            this.txtalumnoaño.TextChanged += new System.EventHandler(this.txtalumnoaño_TextChanged);
            this.txtalumnoaño.VisibleChanged += new System.EventHandler(this.txtalumnoaño_VisibleChanged);
            // 
            // lblcontactosemergencia
            // 
            this.lblcontactosemergencia.AutoSize = true;
            this.lblcontactosemergencia.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactosemergencia.Location = new System.Drawing.Point(22, 463);
            this.lblcontactosemergencia.Name = "lblcontactosemergencia";
            this.lblcontactosemergencia.Size = new System.Drawing.Size(215, 21);
            this.lblcontactosemergencia.TabIndex = 38;
            this.lblcontactosemergencia.Text = "Contactos De Emergencia";
            this.lblcontactosemergencia.Visible = false;
            // 
            // lbltelefono1
            // 
            this.lbltelefono1.AutoSize = true;
            this.lbltelefono1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono1.Location = new System.Drawing.Point(22, 265);
            this.lbltelefono1.Name = "lbltelefono1";
            this.lbltelefono1.Size = new System.Drawing.Size(83, 21);
            this.lbltelefono1.TabIndex = 39;
            this.lbltelefono1.Text = "Teléfono:";
            this.lbltelefono1.Visible = false;
            // 
            // txbtelefono1
            // 
            this.txbtelefono1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefono1.Location = new System.Drawing.Point(115, 265);
            this.txbtelefono1.Name = "txbtelefono1";
            this.txbtelefono1.Size = new System.Drawing.Size(195, 25);
            this.txbtelefono1.TabIndex = 40;
            this.txbtelefono1.Visible = false;
            // 
            // txbcelular
            // 
            this.txbcelular.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcelular.Location = new System.Drawing.Point(468, 264);
            this.txbcelular.Name = "txbcelular";
            this.txbcelular.Size = new System.Drawing.Size(195, 25);
            this.txbcelular.TabIndex = 42;
            this.txbcelular.Visible = false;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.Location = new System.Drawing.Point(392, 264);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(70, 21);
            this.lblcelular.TabIndex = 41;
            this.lblcelular.Text = "Celular:";
            this.lblcelular.Visible = false;
            // 
            // txbtelefono2
            // 
            this.txbtelefono2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefono2.Location = new System.Drawing.Point(467, 496);
            this.txbtelefono2.Name = "txbtelefono2";
            this.txbtelefono2.Size = new System.Drawing.Size(191, 25);
            this.txbtelefono2.TabIndex = 44;
            this.txbtelefono2.Visible = false;
            // 
            // lbltelefono2
            // 
            this.lbltelefono2.AutoSize = true;
            this.lbltelefono2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono2.Location = new System.Drawing.Point(378, 498);
            this.lbltelefono2.Name = "lbltelefono2";
            this.lbltelefono2.Size = new System.Drawing.Size(83, 21);
            this.lbltelefono2.TabIndex = 43;
            this.lbltelefono2.Text = "Teléfono:";
            this.lbltelefono2.Visible = false;
            // 
            // txbnombre1
            // 
            this.txbnombre1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombre1.Location = new System.Drawing.Point(115, 497);
            this.txbnombre1.Name = "txbnombre1";
            this.txbnombre1.Size = new System.Drawing.Size(254, 25);
            this.txbnombre1.TabIndex = 46;
            this.txbnombre1.Visible = false;
            // 
            // lblnombre1
            // 
            this.lblnombre1.AutoSize = true;
            this.lblnombre1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.Location = new System.Drawing.Point(22, 497);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(81, 21);
            this.lblnombre1.TabIndex = 45;
            this.lblnombre1.Text = "Nombre:";
            this.lblnombre1.Visible = false;
            this.lblnombre1.Click += new System.EventHandler(this.lblnombre1_Click);
            // 
            // txbnombre2
            // 
            this.txbnombre2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnombre2.Location = new System.Drawing.Point(115, 531);
            this.txbnombre2.Name = "txbnombre2";
            this.txbnombre2.Size = new System.Drawing.Size(254, 25);
            this.txbnombre2.TabIndex = 48;
            this.txbnombre2.Visible = false;
            // 
            // lblnombre2
            // 
            this.lblnombre2.AutoSize = true;
            this.lblnombre2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre2.Location = new System.Drawing.Point(22, 531);
            this.lblnombre2.Name = "lblnombre2";
            this.lblnombre2.Size = new System.Drawing.Size(81, 21);
            this.lblnombre2.TabIndex = 47;
            this.lblnombre2.Text = "Nombre:";
            this.lblnombre2.Visible = false;
            // 
            // txbtelefono3
            // 
            this.txbtelefono3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtelefono3.Location = new System.Drawing.Point(467, 530);
            this.txbtelefono3.Name = "txbtelefono3";
            this.txbtelefono3.Size = new System.Drawing.Size(191, 25);
            this.txbtelefono3.TabIndex = 52;
            this.txbtelefono3.Visible = false;
            // 
            // lbltelefono3
            // 
            this.lbltelefono3.AutoSize = true;
            this.lbltelefono3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono3.Location = new System.Drawing.Point(378, 532);
            this.lbltelefono3.Name = "lbltelefono3";
            this.lbltelefono3.Size = new System.Drawing.Size(83, 21);
            this.lbltelefono3.TabIndex = 51;
            this.lbltelefono3.Text = "Teléfono:";
            this.lbltelefono3.Visible = false;
            // 
            // cmbjornada
            // 
            this.cmbjornada.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjornada.FormattingEnabled = true;
            this.cmbjornada.Items.AddRange(new object[] {
            "Matunina",
            "Vespertina",
            "Sabatina"});
            this.cmbjornada.Location = new System.Drawing.Point(115, 428);
            this.cmbjornada.Name = "cmbjornada";
            this.cmbjornada.Size = new System.Drawing.Size(121, 26);
            this.cmbjornada.TabIndex = 53;
            this.cmbjornada.Visible = false;
            // 
            // lblnumcarne
            // 
            this.lblnumcarne.AutoSize = true;
            this.lblnumcarne.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcarne.Location = new System.Drawing.Point(443, 376);
            this.lblnumcarne.Name = "lblnumcarne";
            this.lblnumcarne.Size = new System.Drawing.Size(161, 21);
            this.lblnumcarne.TabIndex = 54;
            this.lblnumcarne.Text = "Número De Carnet";
            this.lblnumcarne.Visible = false;
            // 
            // lblcarnerama
            // 
            this.lblcarnerama.AutoSize = true;
            this.lblcarnerama.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarnerama.Location = new System.Drawing.Point(393, 396);
            this.lblcarnerama.Name = "lblcarnerama";
            this.lblcarnerama.Size = new System.Drawing.Size(62, 41);
            this.lblcarnerama.TabIndex = 55;
            this.lblcarnerama.Text = "00";
            this.lblcarnerama.Visible = false;
            this.lblcarnerama.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcarneaño
            // 
            this.lblcarneaño.AutoSize = true;
            this.lblcarneaño.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarneaño.Location = new System.Drawing.Point(495, 396);
            this.lblcarneaño.Name = "lblcarneaño";
            this.lblcarneaño.Size = new System.Drawing.Size(62, 41);
            this.lblcarneaño.TabIndex = 56;
            this.lblcarneaño.Text = "00";
            this.lblcarneaño.Visible = false;
            this.lblcarneaño.Click += new System.EventHandler(this.lblcarneaño_Click);
            // 
            // lblcarnealumno
            // 
            this.lblcarnealumno.AutoSize = true;
            this.lblcarnealumno.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarnealumno.Location = new System.Drawing.Point(596, 395);
            this.lblcarnealumno.Name = "lblcarnealumno";
            this.lblcarnealumno.Size = new System.Drawing.Size(62, 41);
            this.lblcarnealumno.TabIndex = 57;
            this.lblcarnealumno.Text = "00";
            this.lblcarnealumno.Visible = false;
            this.lblcarnealumno.Click += new System.EventHandler(this.lblcarnealumno_Click);
            // 
            // lblguion1
            // 
            this.lblguion1.AutoSize = true;
            this.lblguion1.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguion1.Location = new System.Drawing.Point(460, 397);
            this.lblguion1.Name = "lblguion1";
            this.lblguion1.Size = new System.Drawing.Size(32, 41);
            this.lblguion1.TabIndex = 58;
            this.lblguion1.Text = "-";
            this.lblguion1.Visible = false;
            // 
            // lblguion2
            // 
            this.lblguion2.AutoSize = true;
            this.lblguion2.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguion2.Location = new System.Drawing.Point(563, 397);
            this.lblguion2.Name = "lblguion2";
            this.lblguion2.Size = new System.Drawing.Size(32, 41);
            this.lblguion2.TabIndex = 59;
            this.lblguion2.Text = "-";
            this.lblguion2.Visible = false;
            // 
            // dgalumno
            // 
            this.dgalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgalumno.Location = new System.Drawing.Point(12, 165);
            this.dgalumno.Name = "dgalumno";
            this.dgalumno.Size = new System.Drawing.Size(758, 28);
            this.dgalumno.TabIndex = 60;
            this.dgalumno.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(384, 117);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 40);
            this.btnConsultar.TabIndex = 95;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Visible = false;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 583);
            this.ControlBox = false;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgalumno);
            this.Controls.Add(this.lblguion2);
            this.Controls.Add(this.lblguion1);
            this.Controls.Add(this.lblcarnealumno);
            this.Controls.Add(this.lblcarneaño);
            this.Controls.Add(this.lblcarnerama);
            this.Controls.Add(this.lblnumcarne);
            this.Controls.Add(this.cmbjornada);
            this.Controls.Add(this.txbtelefono3);
            this.Controls.Add(this.lbltelefono3);
            this.Controls.Add(this.txbnombre2);
            this.Controls.Add(this.lblnombre2);
            this.Controls.Add(this.txbnombre1);
            this.Controls.Add(this.lblnombre1);
            this.Controls.Add(this.txbtelefono2);
            this.Controls.Add(this.lbltelefono2);
            this.Controls.Add(this.txbcelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.txbtelefono1);
            this.Controls.Add(this.lbltelefono1);
            this.Controls.Add(this.lblcontactosemergencia);
            this.Controls.Add(this.txtalumnoaño);
            this.Controls.Add(this.txbcorreoelectronico);
            this.Controls.Add(this.lblcorreoelectronico);
            this.Controls.Add(this.txbdireccion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.cmbalumnociclo);
            this.Controls.Add(this.lbljornada);
            this.Controls.Add(this.lblalumnociclo);
            this.Controls.Add(this.cmbalumnorama);
            this.Controls.Add(this.lblalumnorama);
            this.Controls.Add(this.cmbmes);
            this.Controls.Add(this.cmbdia);
            this.Controls.Add(this.txbcarnet);
            this.Controls.Add(this.txbaño);
            this.Controls.Add(this.txbrama);
            this.Controls.Add(this.lblcarne);
            this.Controls.Add(this.btnSalirAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblslash2);
            this.Controls.Add(this.lblslash1);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.txbapellidoalumno);
            this.Controls.Add(this.txbnombrealumno);
            this.Controls.Add(this.lblapellidoalumno);
            this.Controls.Add(this.lblnombrealumno);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(220, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnombrealumno;
        private System.Windows.Forms.Label lblapellidoalumno;
        private System.Windows.Forms.TextBox txbnombrealumno;
        private System.Windows.Forms.TextBox txbapellidoalumno;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.Label lblslash1;
        private System.Windows.Forms.Label lblslash2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirAlumno;
        private System.Windows.Forms.Label lblcarne;
        private System.Windows.Forms.TextBox txbrama;
        private System.Windows.Forms.TextBox txbaño;
        private System.Windows.Forms.TextBox txbcarnet;
        private System.Windows.Forms.ComboBox cmbdia;
        private System.Windows.Forms.ComboBox cmbmes;
        private System.Windows.Forms.Label lblalumnorama;
        private System.Windows.Forms.ComboBox cmbalumnorama;
        private System.Windows.Forms.Label lblalumnociclo;
        private System.Windows.Forms.Label lbljornada;
        private System.Windows.Forms.ComboBox cmbalumnociclo;
        private System.Windows.Forms.TextBox txbdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txbcorreoelectronico;
        private System.Windows.Forms.Label lblcorreoelectronico;
        private System.Windows.Forms.TextBox txtalumnoaño;
        private System.Windows.Forms.Label lblcontactosemergencia;
        private System.Windows.Forms.Label lbltelefono1;
        private System.Windows.Forms.TextBox txbtelefono1;
        private System.Windows.Forms.TextBox txbcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txbtelefono2;
        private System.Windows.Forms.Label lbltelefono2;
        private System.Windows.Forms.TextBox txbnombre1;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.TextBox txbnombre2;
        private System.Windows.Forms.Label lblnombre2;
        private System.Windows.Forms.TextBox txbtelefono3;
        private System.Windows.Forms.Label lbltelefono3;
        private System.Windows.Forms.ComboBox cmbjornada;
        private System.Windows.Forms.Label lblnumcarne;
        private System.Windows.Forms.Label lblcarnerama;
        private System.Windows.Forms.Label lblcarneaño;
        private System.Windows.Forms.Label lblcarnealumno;
        private System.Windows.Forms.Label lblguion1;
        private System.Windows.Forms.Label lblguion2;
        private System.Windows.Forms.DataGridView dgalumno;
        private System.Windows.Forms.Button btnConsultar;


    }
}