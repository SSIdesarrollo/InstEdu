namespace SSI
{
    partial class frmpago
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
            this.btntipo_pago = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpersonal = new System.Windows.Forms.ComboBox();
            this.cmbestudiante = new System.Windows.Forms.ComboBox();
            this.cmbpago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntipo_pago
            // 
            this.btntipo_pago.Location = new System.Drawing.Point(628, 22);
            this.btntipo_pago.Name = "btntipo_pago";
            this.btntipo_pago.Size = new System.Drawing.Size(107, 23);
            this.btntipo_pago.TabIndex = 0;
            this.btntipo_pago.Text = "Tipo de Cambio";
            this.btntipo_pago.UseVisualStyleBackColor = true;
            this.btntipo_pago.Click += new System.EventHandler(this.btntipo_pago_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(43, 107);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 358);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbpago);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(32, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(656, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(32, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(656, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deudores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(32, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(656, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(106, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbpersonal);
            this.groupBox1.Controls.Add(this.cmbestudiante);
            this.groupBox1.Location = new System.Drawing.Point(66, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiante";
            // 
            // cmbpersonal
            // 
            this.cmbpersonal.FormattingEnabled = true;
            this.cmbpersonal.Location = new System.Drawing.Point(290, 59);
            this.cmbpersonal.Name = "cmbpersonal";
            this.cmbpersonal.Size = new System.Drawing.Size(121, 29);
            this.cmbpersonal.TabIndex = 1;
            // 
            // cmbestudiante
            // 
            this.cmbestudiante.FormattingEnabled = true;
            this.cmbestudiante.Location = new System.Drawing.Point(59, 59);
            this.cmbestudiante.Name = "cmbestudiante";
            this.cmbestudiante.Size = new System.Drawing.Size(121, 29);
            this.cmbestudiante.TabIndex = 0;
            // 
            // cmbpago
            // 
            this.cmbpago.FormattingEnabled = true;
            this.cmbpago.Location = new System.Drawing.Point(249, 175);
            this.cmbpago.Name = "cmbpago";
            this.cmbpago.Size = new System.Drawing.Size(121, 29);
            this.cmbpago.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pago";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 28);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto";
            // 
            // frmpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btntipo_pago);
            this.Name = "frmpago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.frmpago_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntipo_pago;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpersonal;
        private System.Windows.Forms.ComboBox cmbestudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpago;
    }
}