namespace SSI
{
    partial class frmplanificacionhorario
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
            this.button8 = new System.Windows.Forms.Button();
            this.lblcurso = new System.Windows.Forms.Label();
            this.cmbcurso = new System.Windows.Forms.ComboBox();
            this.lblciclo = new System.Windows.Forms.Label();
            this.cmbalumnociclo = new System.Windows.Forms.ComboBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblfin = new System.Windows.Forms.Label();
            this.cmbinicio = new System.Windows.Forms.ComboBox();
            this.cmbfin = new System.Windows.Forms.ComboBox();
            this.cmbdia = new System.Windows.Forms.ComboBox();
            this.lbldia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgplanificacionhorario = new System.Windows.Forms.DataGridView();
            this.cmbrama = new System.Windows.Forms.ComboBox();
            this.lblrama = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.cmbaño = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgplanificacionhorario)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(776, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 48);
            this.button8.TabIndex = 8;
            this.button8.Text = "Salida";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.Location = new System.Drawing.Point(49, 157);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(58, 21);
            this.lblcurso.TabIndex = 130;
            this.lblcurso.Text = "Curso:";
            this.lblcurso.Visible = false;
            this.lblcurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbcurso
            // 
            this.cmbcurso.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcurso.FormattingEnabled = true;
            this.cmbcurso.Location = new System.Drawing.Point(111, 156);
            this.cmbcurso.Name = "cmbcurso";
            this.cmbcurso.Size = new System.Drawing.Size(121, 26);
            this.cmbcurso.TabIndex = 131;
            this.cmbcurso.Visible = false;
            // 
            // lblciclo
            // 
            this.lblciclo.AutoSize = true;
            this.lblciclo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciclo.Location = new System.Drawing.Point(483, 121);
            this.lblciclo.Name = "lblciclo";
            this.lblciclo.Size = new System.Drawing.Size(52, 21);
            this.lblciclo.TabIndex = 132;
            this.lblciclo.Text = "Ciclo:";
            this.lblciclo.Visible = false;
            // 
            // cmbalumnociclo
            // 
            this.cmbalumnociclo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbalumnociclo.FormattingEnabled = true;
            this.cmbalumnociclo.Location = new System.Drawing.Point(541, 120);
            this.cmbalumnociclo.Name = "cmbalumnociclo";
            this.cmbalumnociclo.Size = new System.Drawing.Size(121, 26);
            this.cmbalumnociclo.TabIndex = 133;
            this.cmbalumnociclo.Visible = false;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(238, 156);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(101, 21);
            this.lblinicio.TabIndex = 134;
            this.lblinicio.Text = "Hora Inicio:";
            this.lblinicio.Visible = false;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfin.Location = new System.Drawing.Point(429, 156);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(85, 21);
            this.lblfin.TabIndex = 135;
            this.lblfin.Text = "Hora Fin:";
            this.lblfin.Visible = false;
            // 
            // cmbinicio
            // 
            this.cmbinicio.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbinicio.FormattingEnabled = true;
            this.cmbinicio.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            ""});
            this.cmbinicio.Location = new System.Drawing.Point(343, 155);
            this.cmbinicio.Name = "cmbinicio";
            this.cmbinicio.Size = new System.Drawing.Size(82, 26);
            this.cmbinicio.TabIndex = 136;
            this.cmbinicio.Visible = false;
            // 
            // cmbfin
            // 
            this.cmbfin.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfin.FormattingEnabled = true;
            this.cmbfin.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "1:00"});
            this.cmbfin.Location = new System.Drawing.Point(517, 155);
            this.cmbfin.Name = "cmbfin";
            this.cmbfin.Size = new System.Drawing.Size(82, 26);
            this.cmbfin.TabIndex = 137;
            this.cmbfin.Visible = false;
            // 
            // cmbdia
            // 
            this.cmbdia.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdia.FormattingEnabled = true;
            this.cmbdia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes ",
            "Sabado"});
            this.cmbdia.Location = new System.Drawing.Point(651, 155);
            this.cmbdia.Name = "cmbdia";
            this.cmbdia.Size = new System.Drawing.Size(93, 26);
            this.cmbdia.TabIndex = 138;
            this.cmbdia.Visible = false;
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.Location = new System.Drawing.Point(604, 156);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(43, 21);
            this.lbldia.TabIndex = 139;
            this.lbldia.Text = "Dia:";
            this.lbldia.Visible = false;
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
            this.panel1.TabIndex = 140;
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
            this.pictureBox1.Location = new System.Drawing.Point(693, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // dgplanificacionhorario
            // 
            this.dgplanificacionhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgplanificacionhorario.Location = new System.Drawing.Point(12, 188);
            this.dgplanificacionhorario.Name = "dgplanificacionhorario";
            this.dgplanificacionhorario.Size = new System.Drawing.Size(859, 270);
            this.dgplanificacionhorario.TabIndex = 142;
            this.dgplanificacionhorario.Visible = false;
            // 
            // cmbrama
            // 
            this.cmbrama.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrama.FormattingEnabled = true;
            this.cmbrama.Location = new System.Drawing.Point(356, 120);
            this.cmbrama.Name = "cmbrama";
            this.cmbrama.Size = new System.Drawing.Size(121, 26);
            this.cmbrama.TabIndex = 143;
            this.cmbrama.Visible = false;
            // 
            // lblrama
            // 
            this.lblrama.AutoSize = true;
            this.lblrama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrama.Location = new System.Drawing.Point(288, 121);
            this.lblrama.Name = "lblrama";
            this.lblrama.Size = new System.Drawing.Size(64, 21);
            this.lblrama.TabIndex = 144;
            this.lblrama.Text = "Rama:";
            this.lblrama.Visible = false;
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(115, 120);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(43, 21);
            this.lblaño.TabIndex = 145;
            this.lblaño.Text = "Año";
            this.lblaño.Visible = false;
            // 
            // cmbaño
            // 
            this.cmbaño.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaño.FormattingEnabled = true;
            this.cmbaño.Location = new System.Drawing.Point(163, 119);
            this.cmbaño.Name = "cmbaño";
            this.cmbaño.Size = new System.Drawing.Size(121, 26);
            this.cmbaño.TabIndex = 146;
            this.cmbaño.Visible = false;
            // 
            // frmplanificacionhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 524);
            this.ControlBox = false;
            this.Controls.Add(this.cmbaño);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.lblrama);
            this.Controls.Add(this.cmbrama);
            this.Controls.Add(this.dgplanificacionhorario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.cmbdia);
            this.Controls.Add(this.cmbfin);
            this.Controls.Add(this.cmbinicio);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.cmbalumnociclo);
            this.Controls.Add(this.lblciclo);
            this.Controls.Add(this.cmbcurso);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.button8);
            this.Name = "frmplanificacionhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planificación De Cursos";
            this.Load += new System.EventHandler(this.frmasignaciondecursos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgplanificacionhorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.ComboBox cmbcurso;
        private System.Windows.Forms.Label lblciclo;
        private System.Windows.Forms.ComboBox cmbalumnociclo;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.ComboBox cmbinicio;
        private System.Windows.Forms.ComboBox cmbfin;
        private System.Windows.Forms.ComboBox cmbdia;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgplanificacionhorario;
        private System.Windows.Forms.ComboBox cmbrama;
        private System.Windows.Forms.Label lblrama;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.ComboBox cmbaño;
    }
}