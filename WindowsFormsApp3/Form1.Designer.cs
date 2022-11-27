
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPatientLogIn = new System.Windows.Forms.Button();
            this.btnDoctorLogIn = new System.Windows.Forms.Button();
            this.lblChooseLogIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHeading.Font = new System.Drawing.Font("Lucida Bright", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHeading.Location = new System.Drawing.Point(105, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(845, 55);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Cybernate Physician System (CPS)";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdmin.Location = new System.Drawing.Point(428, 411);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(172, 67);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPatientLogIn
            // 
            this.btnPatientLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPatientLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPatientLogIn.Location = new System.Drawing.Point(115, 411);
            this.btnPatientLogIn.Name = "btnPatientLogIn";
            this.btnPatientLogIn.Size = new System.Drawing.Size(167, 67);
            this.btnPatientLogIn.TabIndex = 2;
            this.btnPatientLogIn.Text = "Patient Login";
            this.btnPatientLogIn.UseVisualStyleBackColor = false;
            this.btnPatientLogIn.Click += new System.EventHandler(this.btnPatientLogIn_Click);
            // 
            // btnDoctorLogIn
            // 
            this.btnDoctorLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoctorLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDoctorLogIn.Location = new System.Drawing.Point(744, 411);
            this.btnDoctorLogIn.Name = "btnDoctorLogIn";
            this.btnDoctorLogIn.Size = new System.Drawing.Size(173, 67);
            this.btnDoctorLogIn.TabIndex = 3;
            this.btnDoctorLogIn.Text = "Doctor Login";
            this.btnDoctorLogIn.UseVisualStyleBackColor = false;
            this.btnDoctorLogIn.Click += new System.EventHandler(this.btnDoctorLogIn_Click);
            // 
            // lblChooseLogIn
            // 
            this.lblChooseLogIn.AutoSize = true;
            this.lblChooseLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblChooseLogIn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblChooseLogIn.Location = new System.Drawing.Point(396, 238);
            this.lblChooseLogIn.Name = "lblChooseLogIn";
            this.lblChooseLogIn.Size = new System.Drawing.Size(248, 36);
            this.lblChooseLogIn.TabIndex = 4;
            this.lblChooseLogIn.Text = "Choose your login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.live_medical_screening_application_on_260nw_1388677202;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 542);
            this.Controls.Add(this.lblChooseLogIn);
            this.Controls.Add(this.btnDoctorLogIn);
            this.Controls.Add(this.btnPatientLogIn);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPatientLogIn;
        private System.Windows.Forms.Button btnDoctorLogIn;
        private System.Windows.Forms.Label lblChooseLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

