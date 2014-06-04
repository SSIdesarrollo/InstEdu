namespace SSI
{
    partial class frmrama
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
            this.lblnombrederama = new System.Windows.Forms.Label();
            this.txbrama = new System.Windows.Forms.TextBox();
            this.btnsalidarama = new System.Windows.Forms.Button();
            this.dgrama = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrama)).BeginInit();
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
            this.panel1.TabIndex = 7;
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
            // lblnombrederama
            // 
            this.lblnombrederama.AutoSize = true;
            this.lblnombrederama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrederama.Location = new System.Drawing.Point(86, 133);
            this.lblnombrederama.Name = "lblnombrederama";
            this.lblnombrederama.Size = new System.Drawing.Size(130, 21);
            this.lblnombrederama.TabIndex = 11;
            this.lblnombrederama.Text = "Nombre Rama";
            this.lblnombrederama.Visible = false;
            // 
            // txbrama
            // 
            this.txbrama.Location = new System.Drawing.Point(222, 133);
            this.txbrama.Name = "txbrama";
            this.txbrama.Size = new System.Drawing.Size(171, 20);
            this.txbrama.TabIndex = 9;
            this.txbrama.Visible = false;
            // 
            // btnsalidarama
            // 
            this.btnsalidarama.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalidarama.ForeColor = System.Drawing.Color.Black;
            this.btnsalidarama.Location = new System.Drawing.Point(418, 315);
            this.btnsalidarama.Name = "btnsalidarama";
            this.btnsalidarama.Size = new System.Drawing.Size(95, 48);
            this.btnsalidarama.TabIndex = 12;
            this.btnsalidarama.Text = "Salida";
            this.btnsalidarama.UseVisualStyleBackColor = true;
            this.btnsalidarama.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgrama
            // 
            this.dgrama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrama.Location = new System.Drawing.Point(12, 159);
            this.dgrama.Name = "dgrama";
            this.dgrama.Size = new System.Drawing.Size(501, 150);
            this.dgrama.TabIndex = 13;
            this.dgrama.Visible = false;
            // 
            // frmrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 375);
            this.ControlBox = false;
            this.Controls.Add(this.dgrama);
            this.Controls.Add(this.btnsalidarama);
            this.Controls.Add(this.lblnombrederama);
            this.Controls.Add(this.txbrama);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(220, 0);
            this.Name = "frmrama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rama";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnombrederama;
        private System.Windows.Forms.TextBox txbrama;
        private System.Windows.Forms.Button btnsalidarama;
        private System.Windows.Forms.DataGridView dgrama;
    }
}