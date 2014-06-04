namespace SSI
{
    partial class frmPersonal
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
            this.btnSalirAlumno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnnuevopersonal = new System.Windows.Forms.Button();
            this.btneditarpersonal = new System.Windows.Forms.Button();
            this.btnguardarpersonal = new System.Windows.Forms.Button();
            this.btnbuscarpersonal = new System.Windows.Forms.Button();
            this.btneliminarpersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirAlumno
            // 
            this.btnSalirAlumno.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlumno.Location = new System.Drawing.Point(659, 526);
            this.btnSalirAlumno.Name = "btnSalirAlumno";
            this.btnSalirAlumno.Size = new System.Drawing.Size(100, 40);
            this.btnSalirAlumno.TabIndex = 37;
            this.btnSalirAlumno.Text = "Salir";
            this.btnSalirAlumno.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnnuevopersonal);
            this.panel1.Controls.Add(this.btneditarpersonal);
            this.panel1.Controls.Add(this.btnguardarpersonal);
            this.panel1.Controls.Add(this.btnbuscarpersonal);
            this.panel1.Controls.Add(this.btneliminarpersonal);
            this.panel1.Location = new System.Drawing.Point(1, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSI.Properties.Resources.InstEdu_sin_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(592, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnnuevopersonal
            // 
            this.btnnuevopersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevopersonal.Image = global::SSI.Properties.Resources._new;
            this.btnnuevopersonal.Location = new System.Drawing.Point(22, 24);
            this.btnnuevopersonal.Name = "btnnuevopersonal";
            this.btnnuevopersonal.Size = new System.Drawing.Size(52, 52);
            this.btnnuevopersonal.TabIndex = 2;
            this.btnnuevopersonal.UseVisualStyleBackColor = true;
            // 
            // btneditarpersonal
            // 
            this.btneditarpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditarpersonal.Image = global::SSI.Properties.Resources.edit2;
            this.btneditarpersonal.Location = new System.Drawing.Point(80, 24);
            this.btneditarpersonal.Name = "btneditarpersonal";
            this.btneditarpersonal.Size = new System.Drawing.Size(52, 52);
            this.btneditarpersonal.TabIndex = 4;
            this.btneditarpersonal.UseVisualStyleBackColor = true;
            // 
            // btnguardarpersonal
            // 
            this.btnguardarpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardarpersonal.Image = global::SSI.Properties.Resources.save;
            this.btnguardarpersonal.Location = new System.Drawing.Point(138, 24);
            this.btnguardarpersonal.Name = "btnguardarpersonal";
            this.btnguardarpersonal.Size = new System.Drawing.Size(52, 52);
            this.btnguardarpersonal.TabIndex = 0;
            this.btnguardarpersonal.UseVisualStyleBackColor = true;
            // 
            // btnbuscarpersonal
            // 
            this.btnbuscarpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarpersonal.Image = global::SSI.Properties.Resources.search;
            this.btnbuscarpersonal.Location = new System.Drawing.Point(254, 24);
            this.btnbuscarpersonal.Name = "btnbuscarpersonal";
            this.btnbuscarpersonal.Size = new System.Drawing.Size(52, 52);
            this.btnbuscarpersonal.TabIndex = 3;
            this.btnbuscarpersonal.UseVisualStyleBackColor = true;
            // 
            // btneliminarpersonal
            // 
            this.btneliminarpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarpersonal.Image = global::SSI.Properties.Resources.error;
            this.btneliminarpersonal.Location = new System.Drawing.Point(196, 24);
            this.btneliminarpersonal.Name = "btneliminarpersonal";
            this.btneliminarpersonal.Size = new System.Drawing.Size(52, 52);
            this.btneliminarpersonal.TabIndex = 1;
            this.btneliminarpersonal.UseVisualStyleBackColor = true;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 583);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalirAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(220, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirAlumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnuevopersonal;
        private System.Windows.Forms.Button btneditarpersonal;
        private System.Windows.Forms.Button btnguardarpersonal;
        private System.Windows.Forms.Button btnbuscarpersonal;
        private System.Windows.Forms.Button btneliminarpersonal;
    }
}