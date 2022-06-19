
namespace GestionHotel
{
    partial class ReservationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.PaysTextBox = new System.Windows.Forms.TextBox();
            this.AdresseTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CodePostTextBox = new System.Windows.Forms.TextBox();
            this.VilleTextBox = new System.Windows.Forms.TextBox();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 193);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionHotel.Properties.Resources.Hotel;
            this.pictureBox1.Location = new System.Drawing.Point(34, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réserver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReserver);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.CodePostTextBox);
            this.panel2.Controls.Add(this.VilleTextBox);
            this.panel2.Controls.Add(this.PrenomTextBox);
            this.panel2.Controls.Add(this.TelephoneTextBox);
            this.panel2.Controls.Add(this.AdresseTextBox);
            this.panel2.Controls.Add(this.PaysTextBox);
            this.panel2.Controls.Add(this.NomTextBox);
            this.panel2.Location = new System.Drawing.Point(107, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 495);
            this.panel2.TabIndex = 2;
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(47, 61);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(238, 27);
            this.NomTextBox.TabIndex = 0;
            // 
            // PaysTextBox
            // 
            this.PaysTextBox.Location = new System.Drawing.Point(47, 160);
            this.PaysTextBox.Name = "PaysTextBox";
            this.PaysTextBox.Size = new System.Drawing.Size(238, 27);
            this.PaysTextBox.TabIndex = 1;
            // 
            // AdresseTextBox
            // 
            this.AdresseTextBox.Location = new System.Drawing.Point(47, 255);
            this.AdresseTextBox.Name = "AdresseTextBox";
            this.AdresseTextBox.Size = new System.Drawing.Size(238, 27);
            this.AdresseTextBox.TabIndex = 2;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(47, 357);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(238, 27);
            this.TelephoneTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(389, 357);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(242, 27);
            this.EmailTextBox.TabIndex = 7;
            // 
            // CodePostTextBox
            // 
            this.CodePostTextBox.Location = new System.Drawing.Point(389, 255);
            this.CodePostTextBox.Name = "CodePostTextBox";
            this.CodePostTextBox.Size = new System.Drawing.Size(242, 27);
            this.CodePostTextBox.TabIndex = 6;
            // 
            // VilleTextBox
            // 
            this.VilleTextBox.Location = new System.Drawing.Point(389, 160);
            this.VilleTextBox.Name = "VilleTextBox";
            this.VilleTextBox.Size = new System.Drawing.Size(242, 27);
            this.VilleTextBox.TabIndex = 5;
            // 
            // PrenomTextBox
            // 
            this.PrenomTextBox.Location = new System.Drawing.Point(389, 61);
            this.PrenomTextBox.Name = "PrenomTextBox";
            this.PrenomTextBox.Size = new System.Drawing.Size(242, 27);
            this.PrenomTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(389, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code postal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(389, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ville";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(389, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prénom";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pays";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(47, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adresse";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(47, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Telephone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReserver
            // 
            this.btnReserver.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReserver.Location = new System.Drawing.Point(251, 425);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(167, 50);
            this.btnReserver.TabIndex = 15;
            this.btnReserver.Text = "Reserver";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(891, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox CodePostTextBox;
        private System.Windows.Forms.TextBox VilleTextBox;
        private System.Windows.Forms.TextBox PrenomTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox AdresseTextBox;
        private System.Windows.Forms.TextBox PaysTextBox;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Button btnReserver;
    }
}