namespace SSI
{
    partial class frmpagopr
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
            this.btndeuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.tccobranza = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvestudiante = new System.Windows.Forms.DataGridView();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbmonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbestudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvdeudores = new System.Windows.Forms.DataGridView();
            this.gbestudiante = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbestudiante2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvreporte = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpreportes = new System.Windows.Forms.DateTimePicker();
            this.btntipo_pago = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tccobranza.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiante)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudores)).BeginInit();
            this.gbestudiante.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeuda
            // 
            this.btndeuda.BackColor = System.Drawing.SystemColors.GrayText;
            this.btndeuda.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeuda.Location = new System.Drawing.Point(572, 36);
            this.btndeuda.Name = "btndeuda";
            this.btndeuda.Size = new System.Drawing.Size(143, 33);
            this.btndeuda.TabIndex = 11;
            this.btndeuda.Text = "Agregar Deuda";
            this.btndeuda.UseVisualStyleBackColor = false;
            this.btndeuda.Click += new System.EventHandler(this.btndeuda_Click);
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
            this.panel1.Location = new System.Drawing.Point(86, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 10;
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
            // 
            // tccobranza
            // 
            this.tccobranza.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tccobranza.Controls.Add(this.tabPage1);
            this.tccobranza.Controls.Add(this.tabPage2);
            this.tccobranza.Controls.Add(this.tabPage3);
            this.tccobranza.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tccobranza.Location = new System.Drawing.Point(23, 117);
            this.tccobranza.Multiline = true;
            this.tccobranza.Name = "tccobranza";
            this.tccobranza.SelectedIndex = 0;
            this.tccobranza.Size = new System.Drawing.Size(692, 354);
            this.tccobranza.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dgvestudiante);
            this.tabPage1.Controls.Add(this.dtpfecha);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txbmonto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbpago);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(32, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvestudiante
            // 
            this.dgvestudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestudiante.Location = new System.Drawing.Point(356, 116);
            this.dgvestudiante.Name = "dgvestudiante";
            this.dgvestudiante.Size = new System.Drawing.Size(294, 176);
            this.dgvestudiante.TabIndex = 9;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(135, 149);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(203, 28);
            this.dtpfecha.TabIndex = 8;
            this.dtpfecha.Value = new System.DateTime(2014, 5, 21, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto";
            // 
            // txbmonto
            // 
            this.txbmonto.Location = new System.Drawing.Point(135, 251);
            this.txbmonto.Name = "txbmonto";
            this.txbmonto.Size = new System.Drawing.Size(203, 28);
            this.txbmonto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pago";
            // 
            // cmbpago
            // 
            this.cmbpago.FormattingEnabled = true;
            this.cmbpago.Location = new System.Drawing.Point(135, 204);
            this.cmbpago.Name = "cmbpago";
            this.cmbpago.Size = new System.Drawing.Size(203, 29);
            this.cmbpago.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbestudiante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvdeudores);
            this.tabPage2.Controls.Add(this.gbestudiante);
            this.tabPage2.Location = new System.Drawing.Point(32, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deudores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdeudores
            // 
            this.dgvdeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeudores.Location = new System.Drawing.Point(72, 158);
            this.dgvdeudores.Name = "dgvdeudores";
            this.dgvdeudores.Size = new System.Drawing.Size(500, 159);
            this.dgvdeudores.TabIndex = 3;
            // 
            // gbestudiante
            // 
            this.gbestudiante.Controls.Add(this.label6);
            this.gbestudiante.Controls.Add(this.cmbestudiante2);
            this.gbestudiante.Location = new System.Drawing.Point(72, 31);
            this.gbestudiante.Name = "gbestudiante";
            this.gbestudiante.Size = new System.Drawing.Size(219, 111);
            this.gbestudiante.TabIndex = 2;
            this.gbestudiante.TabStop = false;
            this.gbestudiante.Text = "Seleccione";
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
            // cmbestudiante2
            // 
            this.cmbestudiante2.FormattingEnabled = true;
            this.cmbestudiante2.Location = new System.Drawing.Point(59, 59);
            this.cmbestudiante2.Name = "cmbestudiante2";
            this.cmbestudiante2.Size = new System.Drawing.Size(121, 29);
            this.cmbestudiante2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvreporte);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dtpreportes);
            this.tabPage3.Location = new System.Drawing.Point(32, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvreporte
            // 
            this.dgvreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreporte.Location = new System.Drawing.Point(3, 82);
            this.dgvreporte.Name = "dgvreporte";
            this.dgvreporte.Size = new System.Drawing.Size(653, 268);
            this.dgvreporte.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Seleccione la Fecha";
            // 
            // dtpreportes
            // 
            this.dtpreportes.Location = new System.Drawing.Point(270, 30);
            this.dtpreportes.Name = "dtpreportes";
            this.dtpreportes.Size = new System.Drawing.Size(200, 28);
            this.dtpreportes.TabIndex = 0;
            this.dtpreportes.Value = new System.DateTime(2014, 5, 21, 0, 0, 0, 0);
            // 
            // btntipo_pago
            // 
            this.btntipo_pago.BackColor = System.Drawing.SystemColors.GrayText;
            this.btntipo_pago.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipo_pago.Location = new System.Drawing.Point(572, 75);
            this.btntipo_pago.Name = "btntipo_pago";
            this.btntipo_pago.Size = new System.Drawing.Size(143, 32);
            this.btntipo_pago.TabIndex = 8;
            this.btntipo_pago.Text = "Tipo de Pago";
            this.btntipo_pago.UseVisualStyleBackColor = false;
            this.btntipo_pago.Click += new System.EventHandler(this.btntipo_pago_Click);
            // 
            // frmpagop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 485);
            this.Controls.Add(this.btndeuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tccobranza);
            this.Controls.Add(this.btntipo_pago);
            this.Name = "frmpagop";
            this.Text = "Menu Personal";
            this.Load += new System.EventHandler(this.frmpagop_Load);
            this.panel1.ResumeLayout(false);
            this.tccobranza.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeudores)).EndInit();
            this.gbestudiante.ResumeLayout(false);
            this.gbestudiante.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TabControl tccobranza;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvdeudores;
        private System.Windows.Forms.GroupBox gbestudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbestudiante2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvreporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpreportes;
        private System.Windows.Forms.Button btntipo_pago;
    }
}