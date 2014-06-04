namespace SSI
{
    partial class frmmcobranza
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.btnSalirAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Personal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnestudiantes.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiantes.Location = new System.Drawing.Point(25, 63);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(117, 33);
            this.btnestudiantes.TabIndex = 1;
            this.btnestudiantes.Text = "Estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = false;
            this.btnestudiantes.Click += new System.EventHandler(this.btnestudiantes_Click);
            // 
            // btnSalirAlumno
            // 
            this.btnSalirAlumno.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlumno.Location = new System.Drawing.Point(195, 139);
            this.btnSalirAlumno.Name = "btnSalirAlumno";
            this.btnSalirAlumno.Size = new System.Drawing.Size(76, 28);
            this.btnSalirAlumno.TabIndex = 18;
            this.btnSalirAlumno.Text = "Salir";
            this.btnSalirAlumno.UseVisualStyleBackColor = true;
            this.btnSalirAlumno.Click += new System.EventHandler(this.btnSalirAlumno_Click);
            // 
            // frmmcobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 179);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalirAlumno);
            this.Controls.Add(this.btnestudiantes);
            this.Controls.Add(this.button1);
            this.Name = "frmmcobranza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cobranza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Button btnSalirAlumno;
    }
}