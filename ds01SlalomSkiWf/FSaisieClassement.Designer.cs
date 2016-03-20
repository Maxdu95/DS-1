namespace dsSlalomSki
{
    partial class FSaisieClassement
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
            this.lblNomCompetiteur = new System.Windows.Forms.Label();
            this.lblDossard = new System.Windows.Forms.Label();
            this.lblClassement = new System.Windows.Forms.Label();
            this.tbNomCompetiteur = new System.Windows.Forms.TextBox();
            this.tbDossard = new System.Windows.Forms.TextBox();
            this.tbClassement = new System.Windows.Forms.TextBox();
            this.btnValiderClassement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomCompetiteur
            // 
            this.lblNomCompetiteur.AutoSize = true;
            this.lblNomCompetiteur.Location = new System.Drawing.Point(31, 31);
            this.lblNomCompetiteur.Name = "lblNomCompetiteur";
            this.lblNomCompetiteur.Size = new System.Drawing.Size(113, 17);
            this.lblNomCompetiteur.TabIndex = 0;
            this.lblNomCompetiteur.Text = "nom compétiteur";
            // 
            // lblDossard
            // 
            this.lblDossard.AutoSize = true;
            this.lblDossard.Location = new System.Drawing.Point(34, 59);
            this.lblDossard.Name = "lblDossard";
            this.lblDossard.Size = new System.Drawing.Size(59, 17);
            this.lblDossard.TabIndex = 1;
            this.lblDossard.Text = "dossard";
            // 
            // lblClassement
            // 
            this.lblClassement.AutoSize = true;
            this.lblClassement.Location = new System.Drawing.Point(34, 87);
            this.lblClassement.Name = "lblClassement";
            this.lblClassement.Size = new System.Drawing.Size(79, 17);
            this.lblClassement.TabIndex = 2;
            this.lblClassement.Text = "classement";
            // 
            // tbNomCompetiteur
            // 
            this.tbNomCompetiteur.Location = new System.Drawing.Point(154, 31);
            this.tbNomCompetiteur.Name = "tbNomCompetiteur";
            this.tbNomCompetiteur.Size = new System.Drawing.Size(100, 22);
            this.tbNomCompetiteur.TabIndex = 3;
            // 
            // tbDossard
            // 
            this.tbDossard.Location = new System.Drawing.Point(154, 59);
            this.tbDossard.Name = "tbDossard";
            this.tbDossard.Size = new System.Drawing.Size(100, 22);
            this.tbDossard.TabIndex = 4;
            // 
            // tbClassement
            // 
            this.tbClassement.Location = new System.Drawing.Point(154, 87);
            this.tbClassement.Name = "tbClassement";
            this.tbClassement.Size = new System.Drawing.Size(100, 22);
            this.tbClassement.TabIndex = 5;
            // 
            // btnValiderClassement
            // 
            this.btnValiderClassement.Location = new System.Drawing.Point(126, 129);
            this.btnValiderClassement.Name = "btnValiderClassement";
            this.btnValiderClassement.Size = new System.Drawing.Size(75, 23);
            this.btnValiderClassement.TabIndex = 6;
            this.btnValiderClassement.Text = "Valider";
            this.btnValiderClassement.UseVisualStyleBackColor = true;
            // 
            // FSaisieClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 181);
            this.Controls.Add(this.btnValiderClassement);
            this.Controls.Add(this.tbClassement);
            this.Controls.Add(this.tbDossard);
            this.Controls.Add(this.tbNomCompetiteur);
            this.Controls.Add(this.lblClassement);
            this.Controls.Add(this.lblDossard);
            this.Controls.Add(this.lblNomCompetiteur);
            this.Name = "FSaisieClassement";
            this.Text = "Saisie du classement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCompetiteur;
        private System.Windows.Forms.Label lblDossard;
        private System.Windows.Forms.Label lblClassement;
        private System.Windows.Forms.TextBox tbNomCompetiteur;
        private System.Windows.Forms.TextBox tbDossard;
        private System.Windows.Forms.TextBox tbClassement;
        private System.Windows.Forms.Button btnValiderClassement;
    }
}