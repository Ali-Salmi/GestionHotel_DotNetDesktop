
namespace GestionHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hotelspanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ChambrePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChambreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Hotelspanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1538, 193);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(478, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion d\'une chaîne Hôtelière";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Hotelspanel
            // 
            this.Hotelspanel.AutoScroll = true;
            this.Hotelspanel.Controls.Add(this.panel3);
            this.Hotelspanel.Location = new System.Drawing.Point(13, 200);
            this.Hotelspanel.Name = "Hotelspanel";
            this.Hotelspanel.Size = new System.Drawing.Size(773, 689);
            this.Hotelspanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 125);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste des Hôtels";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChambrePanel
            // 
            this.ChambrePanel.AutoScroll = true;
            this.ChambrePanel.Location = new System.Drawing.Point(816, 328);
            this.ChambrePanel.Name = "ChambrePanel";
            this.ChambrePanel.Size = new System.Drawing.Size(710, 561);
            this.ChambrePanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.ChambreLabel);
            this.panel4.Location = new System.Drawing.Point(816, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 125);
            this.panel4.TabIndex = 0;
            // 
            // ChambreLabel
            // 
            this.ChambreLabel.AutoSize = true;
            this.ChambreLabel.Font = new System.Drawing.Font("Simplified Arabic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChambreLabel.Location = new System.Drawing.Point(272, 30);
            this.ChambreLabel.Name = "ChambreLabel";
            this.ChambreLabel.Size = new System.Drawing.Size(191, 62);
            this.ChambreLabel.TabIndex = 3;
            this.ChambreLabel.Text = "Chambres";
            this.ChambreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 901);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ChambrePanel);
            this.Controls.Add(this.Hotelspanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Hotelspanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Hotelspanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel ChambrePanel;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label ChambreLabel;
    }
}

