using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ds01SlalomSkiWf;

namespace dsSlalomSki
{
    public partial class FSaisieClassement : Form
    {
        Participation participation;
        FResultatSlalom fResultatSlalom;

        // Question 6 on récupère la fenètre f 
        public FSaisieClassement(Participation p )        {
            InitializeComponent();
            // Question 6
            this.participation = p;
            tbNomCompetiteur.Text = p.GetLeCompetiteur.GetNom;
            tbDossard.Text = p.GetNumeroDossard.ToString();
            tbClassement.Text = p.GetClassement.ToString();
            btnValiderClassement.Click += new EventHandler(btnValiderClassement_Click);
        }

        void btnValiderClassement_Click(object sender, EventArgs e)        {
            // Question 6
            // L 'objet Participation est modifié
            // les modifications apportées dans cette fenêtre doivent apparaitre et être pris 
            // en compte dans la fenetre FResultatSlalom
        }
    }
}
