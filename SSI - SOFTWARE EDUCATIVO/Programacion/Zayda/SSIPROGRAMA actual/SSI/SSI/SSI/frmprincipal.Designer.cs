namespace SSI
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlumno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCobranza = new System.Windows.Forms.Button();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlumno
            // 
            this.btnAlumno.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumno.Location = new System.Drawing.Point(32, 143);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(156, 32);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnCobranza);
            this.panel2.Controls.Add(this.btnRRHH);
            this.panel2.Controls.Add(this.btnPersonal);
            this.panel2.Controls.Add(this.btnAlumno);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 623);
            this.panel2.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(32, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "InstEdu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSI.Properties.Resources.logoo_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(32, 355);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(156, 32);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCobranza
            // 
            this.btnCobranza.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobranza.Location = new System.Drawing.Point(32, 302);
            this.btnCobranza.Name = "btnCobranza";
            this.btnCobranza.Size = new System.Drawing.Size(156, 32);
            this.btnCobranza.TabIndex = 4;
            this.btnCobranza.Text = "Cobranza";
            this.btnCobranza.UseVisualStyleBackColor = true;
            this.btnCobranza.Click += new System.EventHandler(this.btnCobranza_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.Location = new System.Drawing.Point(32, 249);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(156, 32);
            this.btnRRHH.TabIndex = 3;
            this.btnRRHH.Text = "Recursos Humanos";
            this.btnRRHH.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(32, 196);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(156, 32);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1036, 626);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Educativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCobranza;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

