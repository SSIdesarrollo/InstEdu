namespace SSI
{
    partial class frmciclo
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
            this.btnguardarciclo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalidaciclo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnguardarciclo);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 15;
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
            // btnguardarciclo
            // 
            this.btnguardarciclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardarciclo.Image = global::SSI.Properties.Resources.save;
            this.btnguardarciclo.Location = new System.Drawing.Point(138, 24);
            this.btnguardarciclo.Name = "btnguardarciclo";
            this.btnguardarciclo.Size = new System.Drawing.Size(52, 52);
            this.btnguardarciclo.TabIndex = 0;
            this.btnguardarciclo.UseVisualStyleBackColor = true;
            this.btnguardarciclo.Click += new System.EventHandler(this.btnguardar_Click);
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
            // btnsalidaciclo
            // 
            this.btnsalidaciclo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalidaciclo.ForeColor = System.Drawing.Color.Black;
            this.btnsalidaciclo.Location = new System.Drawing.Point(242, 187);
            this.btnsalidaciclo.Name = "btnsalidaciclo";
            this.btnsalidaciclo.Size = new System.Drawing.Size(95, 48);
            this.btnsalidaciclo.TabIndex = 18;
            this.btnsalidaciclo.Text = "Salida";
            this.btnsalidaciclo.UseVisualStyleBackColor = true;
            this.btnsalidaciclo.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ciclo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 16;
            // 
            // frmciclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalidaciclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmciclo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmciclo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardarciclo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalidaciclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}