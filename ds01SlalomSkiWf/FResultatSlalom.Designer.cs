namespace ds01SlalomSkiWf
{
    partial class FResultatSlalom
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbParticipants = new System.Windows.Forms.ListBox();
            this.btnSaisirClassement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbParticipants
            // 
            this.lbParticipants.FormattingEnabled = true;
            this.lbParticipants.ItemHeight = 16;
            this.lbParticipants.Location = new System.Drawing.Point(12, 12);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(394, 404);
            this.lbParticipants.TabIndex = 0;
            // 
            // btnSaisirClassement
            // 
            this.btnSaisirClassement.Location = new System.Drawing.Point(138, 422);
            this.btnSaisirClassement.Name = "btnSaisirClassement";
            this.btnSaisirClassement.Size = new System.Drawing.Size(133, 56);
            this.btnSaisirClassement.TabIndex = 1;
            this.btnSaisirClassement.Text = "Saisir Classement";
            this.btnSaisirClassement.UseVisualStyleBackColor = true;
            // 
            // FResultatSlalom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 485);
            this.Controls.Add(this.btnSaisirClassement);
            this.Controls.Add(this.lbParticipants);
            this.Name = "FResultatSlalom";
            this.Text = "Résultat slalom kitzbühel  12/02/2015";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbParticipants;
        private System.Windows.Forms.Button btnSaisirClassement;
    }
}

