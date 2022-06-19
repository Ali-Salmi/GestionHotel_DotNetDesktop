
namespace GestionHotel.UC
{
    partial class ucChambre
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
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumeroLabel.Location = new System.Drawing.Point(52, 16);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(102, 49);
            this.NumeroLabel.TabIndex = 1;
            this.NumeroLabel.Text = "label1";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TelephoneLabel.Location = new System.Drawing.Point(52, 85);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(102, 49);
            this.TelephoneLabel.TabIndex = 2;
            this.TelephoneLabel.Text = "label1";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(52, 152);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(102, 49);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "label1";
            // 
            // btnReserver
            // 
            this.btnReserver.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReserver.Location = new System.Drawing.Point(529, 85);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(128, 43);
            this.btnReserver.TabIndex = 4;
            this.btnReserver.Text = "Réserver";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // ucChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.NumeroLabel);
            this.Name = "ucChambre";
            this.Size = new System.Drawing.Size(710, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label NumeroLabel;
        public System.Windows.Forms.Label TelephoneLabel;
        public System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button btnReserver;
    }
}
