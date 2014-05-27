namespace SSI
{
    partial class frmpensum
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
            this.txbdescripcion = new System.Windows.Forms.TextBox();
            this.txbaño = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbldescripcio = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.btnsalidapensum = new System.Windows.Forms.Button();
            this.dgpensum = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpensum)).BeginInit();
            this.SuspendLayout();
            // 
            // txbdescripcion
            // 
            this.txbdescripcion.Location = new System.Drawing.Point(165, 126);
            this.txbdescripcion.Name = "txbdescripcion";
            this.txbdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txbdescripcion.TabIndex = 1;
            this.txbdescripcion.Visible = false;
            // 
            // txbaño
            // 
            this.txbaño.Location = new System.Drawing.Point(354, 126);
            this.txbaño.Name = "txbaño";
            this.txbaño.Size = new System.Drawing.Size(100, 20);
            this.txbaño.TabIndex = 2;
            this.txbaño.Visible = false;
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
            // lbldescripcio
            // 
            this.lbldescripcio.AutoSize = true;
            this.lbldescripcio.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcio.Location = new System.Drawing.Point(60, 126);
            this.lbldescripcio.Name = "lbldescripcio";
            this.lbldescripcio.Size = new System.Drawing.Size(99, 21);
            this.lbldescripcio.TabIndex = 7;
            this.lbldescripcio.Text = "Descripción";
            this.lbldescripcio.Visible = false;
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(305, 125);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(43, 21);
            this.lblaño.TabIndex = 8;
            this.lblaño.Text = "Año";
            this.lblaño.Visible = false;
            // 
            // btnsalidapensum
            // 
            this.btnsalidapensum.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalidapensum.ForeColor = System.Drawing.Color.Black;
            this.btnsalidapensum.Location = new System.Drawing.Point(418, 315);
            this.btnsalidapensum.Name = "btnsalidapensum";
            this.btnsalidapensum.Size = new System.Drawing.Size(95, 48);
            this.btnsalidapensum.TabIndex = 9;
            this.btnsalidapensum.Text = "Salida";
            this.btnsalidapensum.UseVisualStyleBackColor = true;
            this.btnsalidapensum.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgpensum
            // 
            this.dgpensum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpensum.Location = new System.Drawing.Point(12, 152);
            this.dgpensum.Name = "dgpensum";
            this.dgpensum.Size = new System.Drawing.Size(501, 157);
            this.dgpensum.TabIndex = 10;
            this.dgpensum.Visible = false;
            // 
            // frmpensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 375);
            this.ControlBox = false;
            this.Controls.Add(this.dgpensum);
            this.Controls.Add(this.btnsalidapensum);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.lbldescripcio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbaño);
            this.Controls.Add(this.txbdescripcion);
            this.Location = new System.Drawing.Point(220, 0);
            this.Name = "frmpensum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pensum";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgpensum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbdescripcion;
        private System.Windows.Forms.TextBox txbaño;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbldescripcio;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Button btnsalidapensum;
        private System.Windows.Forms.DataGridView dgpensum;
    }
}