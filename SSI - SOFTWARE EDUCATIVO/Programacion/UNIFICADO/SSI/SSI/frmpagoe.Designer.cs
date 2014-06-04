namespace SSI
{
    partial class frmpagoe
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
            this.button2 = new System.Windows.Forms.Button();
            this.dgvestudiante = new System.Windows.Forms.DataGridView();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbmonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdeudores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txbestudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.Label();
            this.pago = new System.Windows.Forms.Label();
            this.btndeuda = new System.Windows.Forms.Button();
            this.btntipo_pago = new System.Windows.Forms.Button();
            this.btndeudores = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.gestudiantes = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txbedeudores = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwdeudores = new System.Windows.Forms.DataGridView();
            this.btndestudiantes = new System.Windows.Forms.Button();
            this.dgvedeudores = new System.Windows.Forms.DataGridView();
            this.dgvreporte = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpreportes = new System.Windows.Forms.DateTimePicker();
            this.btnSalirAlumno = new System.Windows.Forms.Button();
            this.dgvdeudas = new System.Windows.Forms.DataGridView();
            this.btnpagar = new System.Windows.Forms.Button();
            this.idsolvente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiante)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudores)).BeginInit();
            this.gestudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwdeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvedeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudas)).BeginInit();
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
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(391, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvestudiante
            // 
            this.dgvestudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestudiante.Location = new System.Drawing.Point(391, 224);
            this.dgvestudiante.Name = "dgvestudiante";
            this.dgvestudiante.Size = new System.Drawing.Size(294, 176);
            this.dgvestudiante.TabIndex = 19;
            this.dgvestudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestudiante_CellContentClick);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(170, 257);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(203, 20);
            this.dtpfecha.TabIndex = 18;
            this.dtpfecha.Value = new System.DateTime(2014, 5, 21, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-60, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-60, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto";
            // 
            // txbmonto
            // 
            this.txbmonto.Location = new System.Drawing.Point(170, 359);
            this.txbmonto.Name = "txbmonto";
            this.txbmonto.Size = new System.Drawing.Size(203, 20);
            this.txbmonto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-60, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pago";
            // 
            // cmbpago
            // 
            this.cmbpago.FormattingEnabled = true;
            this.cmbpago.Location = new System.Drawing.Point(170, 312);
            this.cmbpago.Name = "cmbpago";
            this.cmbpago.Size = new System.Drawing.Size(203, 21);
            this.cmbpago.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdeudores);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbestudiante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // dgvdeudores
            // 
            this.dgvdeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeudores.Location = new System.Drawing.Point(0, 127);
            this.dgvdeudores.Name = "dgvdeudores";
            this.dgvdeudores.Size = new System.Drawing.Size(500, 159);
            this.dgvdeudores.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SSI.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(455, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbestudiante
            // 
            this.txbestudiante.BackColor = System.Drawing.SystemColors.Window;
            this.txbestudiante.Location = new System.Drawing.Point(125, 48);
            this.txbestudiante.Name = "txbestudiante";
            this.txbestudiante.Size = new System.Drawing.Size(324, 28);
            this.txbestudiante.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(72, 257);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(58, 21);
            this.fecha.TabIndex = 23;
            this.fecha.Text = "Fecha";
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(72, 359);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(62, 21);
            this.monto.TabIndex = 22;
            this.monto.Text = "Monto";
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago.Location = new System.Drawing.Point(72, 305);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(53, 21);
            this.pago.TabIndex = 21;
            this.pago.Text = "Pago";
            // 
            // btndeuda
            // 
            this.btndeuda.BackColor = System.Drawing.SystemColors.GrayText;
            this.btndeuda.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeuda.Location = new System.Drawing.Point(372, 12);
            this.btndeuda.Name = "btndeuda";
            this.btndeuda.Size = new System.Drawing.Size(143, 33);
            this.btndeuda.TabIndex = 25;
            this.btndeuda.Text = "Agregar Deuda";
            this.btndeuda.UseVisualStyleBackColor = false;
            this.btndeuda.Click += new System.EventHandler(this.btndeuda_Click);
            // 
            // btntipo_pago
            // 
            this.btntipo_pago.BackColor = System.Drawing.SystemColors.GrayText;
            this.btntipo_pago.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipo_pago.Location = new System.Drawing.Point(372, 51);
            this.btntipo_pago.Name = "btntipo_pago";
            this.btntipo_pago.Size = new System.Drawing.Size(143, 32);
            this.btntipo_pago.TabIndex = 24;
            this.btntipo_pago.Text = "Tipo de Pago";
            this.btntipo_pago.UseVisualStyleBackColor = false;
            this.btntipo_pago.Click += new System.EventHandler(this.btntipo_pago_Click);
            // 
            // btndeudores
            // 
            this.btndeudores.BackColor = System.Drawing.SystemColors.GrayText;
            this.btndeudores.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeudores.Location = new System.Drawing.Point(557, 12);
            this.btndeudores.Name = "btndeudores";
            this.btndeudores.Size = new System.Drawing.Size(141, 33);
            this.btndeudores.TabIndex = 26;
            this.btndeudores.Text = "Solventes";
            this.btndeudores.UseVisualStyleBackColor = false;
            this.btndeudores.Visible = false;
            this.btndeudores.Click += new System.EventHandler(this.btndeudores_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnreportes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.Location = new System.Drawing.Point(557, 51);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(141, 32);
            this.btnreportes.TabIndex = 27;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // gestudiantes
            // 
            this.gestudiantes.Controls.Add(this.button3);
            this.gestudiantes.Controls.Add(this.txbedeudores);
            this.gestudiantes.Controls.Add(this.label6);
            this.gestudiantes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestudiantes.Location = new System.Drawing.Point(126, 118);
            this.gestudiantes.Name = "gestudiantes";
            this.gestudiantes.Size = new System.Drawing.Size(361, 111);
            this.gestudiantes.TabIndex = 28;
            this.gestudiantes.TabStop = false;
            this.gestudiantes.Text = "Seleccione";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SSI.Properties.Resources.lupa;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(266, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 28);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbedeudores
            // 
            this.txbedeudores.Location = new System.Drawing.Point(67, 56);
            this.txbedeudores.Name = "txbedeudores";
            this.txbedeudores.Size = new System.Drawing.Size(193, 28);
            this.txbedeudores.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Personal";
            // 
            // dgwdeudores
            // 
            this.dgwdeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwdeudores.Location = new System.Drawing.Point(484, 234);
            this.dgwdeudores.Name = "dgwdeudores";
            this.dgwdeudores.Size = new System.Drawing.Size(273, 176);
            this.dgwdeudores.TabIndex = 28;
            this.dgwdeudores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwdeudores_CellContentClick);
            // 
            // btndestudiantes
            // 
            this.btndestudiantes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndestudiantes.Location = new System.Drawing.Point(507, 416);
            this.btndestudiantes.Name = "btndestudiantes";
            this.btndestudiantes.Size = new System.Drawing.Size(183, 27);
            this.btndestudiantes.TabIndex = 29;
            this.btndestudiantes.Text = "Seleccionar";
            this.btndestudiantes.UseVisualStyleBackColor = true;
            this.btndestudiantes.Click += new System.EventHandler(this.btndestudiantes_Click);
            // 
            // dgvedeudores
            // 
            this.dgvedeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvedeudores.Location = new System.Drawing.Point(66, 224);
            this.dgvedeudores.Name = "dgvedeudores";
            this.dgvedeudores.Size = new System.Drawing.Size(353, 176);
            this.dgvedeudores.TabIndex = 30;
            this.dgvedeudores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvedeudores_CellContentClick);
            // 
            // dgvreporte
            // 
            this.dgvreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreporte.Location = new System.Drawing.Point(-32, 449);
            this.dgvreporte.Name = "dgvreporte";
            this.dgvreporte.Size = new System.Drawing.Size(722, 268);
            this.dgvreporte.TabIndex = 33;
            this.dgvreporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreporte_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Seleccione la Fecha";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtpreportes
            // 
            this.dtpreportes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpreportes.Location = new System.Drawing.Point(557, 89);
            this.dtpreportes.Name = "dtpreportes";
            this.dtpreportes.Size = new System.Drawing.Size(200, 28);
            this.dtpreportes.TabIndex = 31;
            this.dtpreportes.Value = new System.DateTime(2014, 5, 21, 0, 0, 0, 0);
            this.dtpreportes.ValueChanged += new System.EventHandler(this.dtpreportes_ValueChanged);
            // 
            // btnSalirAlumno
            // 
            this.btnSalirAlumno.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlumno.Location = new System.Drawing.Point(683, 531);
            this.btnSalirAlumno.Name = "btnSalirAlumno";
            this.btnSalirAlumno.Size = new System.Drawing.Size(100, 40);
            this.btnSalirAlumno.TabIndex = 34;
            this.btnSalirAlumno.Text = "Salir";
            this.btnSalirAlumno.UseVisualStyleBackColor = true;
            this.btnSalirAlumno.Click += new System.EventHandler(this.btnSalirAlumno_Click);
            // 
            // dgvdeudas
            // 
            this.dgvdeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeudas.Location = new System.Drawing.Point(706, 234);
            this.dgvdeudas.Name = "dgvdeudas";
            this.dgvdeudas.Size = new System.Drawing.Size(240, 150);
            this.dgvdeudas.TabIndex = 35;
            this.dgvdeudas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeudas_CellContentClick);
            // 
            // btnpagar
            // 
            this.btnpagar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.Location = new System.Drawing.Point(871, 198);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(75, 31);
            this.btnpagar.TabIndex = 36;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // idsolvente
            // 
            this.idsolvente.AutoSize = true;
            this.idsolvente.Location = new System.Drawing.Point(850, 115);
            this.idsolvente.Name = "idsolvente";
            this.idsolvente.Size = new System.Drawing.Size(0, 13);
            this.idsolvente.TabIndex = 39;
            // 
            // frmpagoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 624);
            this.ControlBox = false;
            this.Controls.Add(this.idsolvente);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.dgvdeudas);
            this.Controls.Add(this.btnSalirAlumno);
            this.Controls.Add(this.dgvreporte);
            this.Controls.Add(this.dgvedeudores);
            this.Controls.Add(this.btndestudiantes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgwdeudores);
            this.Controls.Add(this.dtpreportes);
            this.Controls.Add(this.gestudiantes);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btndeudores);
            this.Controls.Add(this.btndeuda);
            this.Controls.Add(this.btntipo_pago);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvestudiante);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbmonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbpago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(220, 0);
            this.Name = "frmpagoe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu Estudiante";
            this.Load += new System.EventHandler(this.frmpagoe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudores)).EndInit();
            this.gestudiantes.ResumeLayout(false);
            this.gestudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwdeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvedeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudas)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvestudiante;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbmonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbestudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label pago;
        private System.Windows.Forms.Button btndeuda;
        private System.Windows.Forms.Button btntipo_pago;
        private System.Windows.Forms.Button btndeudores;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.DataGridView dgvdeudores;
        private System.Windows.Forms.GroupBox gestudiantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbedeudores;
        private System.Windows.Forms.DataGridView dgwdeudores;
        private System.Windows.Forms.Button btndestudiantes;
        private System.Windows.Forms.DataGridView dgvedeudores;
        private System.Windows.Forms.DataGridView dgvreporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpreportes;
        private System.Windows.Forms.Button btnSalirAlumno;
        private System.Windows.Forms.DataGridView dgvdeudas;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Label idsolvente;
    }
}