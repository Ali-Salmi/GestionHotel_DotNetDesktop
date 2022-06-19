
namespace GestionHotel.UC
{
    partial class ucHotel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomLabel = new System.Windows.Forms.Label();
            this.AdresseLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.EtoileLabel = new System.Windows.Forms.Label();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomLabel.Location = new System.Drawing.Point(96, 20);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(102, 49);
            this.NomLabel.TabIndex = 0;
            this.NomLabel.Text = "label1";
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdresseLabel.Location = new System.Drawing.Point(96, 99);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(102, 49);
            this.AdresseLabel.TabIndex = 1;
            this.AdresseLabel.Text = "label1";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TelephoneLabel.Location = new System.Drawing.Point(377, 20);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(102, 49);
            this.TelephoneLabel.TabIndex = 2;
            this.TelephoneLabel.Text = "label1";
            // 
            // EtoileLabel
            // 
            this.EtoileLabel.AutoSize = true;
            this.EtoileLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EtoileLabel.Location = new System.Drawing.Point(377, 99);
            this.EtoileLabel.Name = "EtoileLabel";
            this.EtoileLabel.Size = new System.Drawing.Size(102, 49);
            this.EtoileLabel.TabIndex = 3;
            this.EtoileLabel.Text = "label1";
            // 
            // btnConsulter
            // 
            this.btnConsulter.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsulter.Location = new System.Drawing.Point(578, 64);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(136, 45);
            this.btnConsulter.TabIndex = 4;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.UseVisualStyleBackColor = true;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.EtoileLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.AdresseLabel);
            this.Controls.Add(this.NomLabel);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(773, 177);
            this.Load += new System.EventHandler(this.ucHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label NomLabel;
        public System.Windows.Forms.Label AdresseLabel;
        public System.Windows.Forms.Label TelephoneLabel;
        public System.Windows.Forms.Label EtoileLabel;
        private System.Windows.Forms.Button btnConsulter;
    }
}
