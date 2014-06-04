namespace SSI
{
    partial class frmcredenciales
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
            this.btnsalidacurso = new System.Windows.Forms.Button();
            this.btncredencialalumno = new System.Windows.Forms.Button();
            this.btncredencialpersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalidacurso
            // 
            this.btnsalidacurso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalidacurso.ForeColor = System.Drawing.Color.Black;
            this.btnsalidacurso.Location = new System.Drawing.Point(418, 315);
            this.btnsalidacurso.Name = "btnsalidacurso";
            this.btnsalidacurso.Size = new System.Drawing.Size(95, 48);
            this.btnsalidacurso.TabIndex = 15;
            this.btnsalidacurso.Text = "Salida";
            this.btnsalidacurso.UseVisualStyleBackColor = true;
            this.btnsalidacurso.Click += new System.EventHandler(this.btnsalidacurso_Click);
            // 
            // btncredencialalumno
            // 
            this.btncredencialalumno.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredencialalumno.ForeColor = System.Drawing.Color.Black;
            this.btncredencialalumno.Location = new System.Drawing.Point(96, 109);
            this.btncredencialalumno.Name = "btncredencialalumno";
            this.btncredencialalumno.Size = new System.Drawing.Size(322, 48);
            this.btncredencialalumno.TabIndex = 16;
            this.btncredencialalumno.Text = "Alumno";
            this.btncredencialalumno.UseVisualStyleBackColor = true;
            this.btncredencialalumno.Click += new System.EventHandler(this.btncredencialalumno_Click);
            // 
            // btncredencialpersonal
            // 
            this.btncredencialpersonal.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredencialpersonal.ForeColor = System.Drawing.Color.Black;
            this.btncredencialpersonal.Location = new System.Drawing.Point(96, 172);
            this.btncredencialpersonal.Name = "btncredencialpersonal";
            this.btncredencialpersonal.Size = new System.Drawing.Size(322, 48);
            this.btncredencialpersonal.TabIndex = 17;
            this.btncredencialpersonal.Text = "Personal";
            this.btncredencialpersonal.UseVisualStyleBackColor = true;
            this.btncredencialpersonal.Click += new System.EventHandler(this.btncredencialpersonal_Click);
            // 
            // frmcredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 375);
            this.ControlBox = false;
            this.Controls.Add(this.btncredencialpersonal);
            this.Controls.Add(this.btncredencialalumno);
            this.Controls.Add(this.btnsalidacurso);
            this.Name = "frmcredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalidacurso;
        private System.Windows.Forms.Button btncredencialalumno;
        private System.Windows.Forms.Button btncredencialpersonal;
    }
}