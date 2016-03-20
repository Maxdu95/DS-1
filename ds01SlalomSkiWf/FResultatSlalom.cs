using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dsSlalomSki;

namespace ds01SlalomSkiWf
{
    public partial class FResultatSlalom : Form     {
        List<Participation> lesParticipants;

        public FResultatSlalom(List<Participation> lesParticipants)         {
            InitializeComponent();
            this.lesParticipants = new List<Participation>();
            lbParticipants.Items.Add("Nom\t\t\tDossard\tClassement");
            int i = 1;
            foreach (Participation p in lesParticipants) {
                lbParticipants.Items.Add(string.Format("{0:00}-{1}",i, p));
                this.lesParticipants.Add(p);
                i++;
            }
            this.btnSaisirClassement.Click += new EventHandler(btnSaisirClassement_Click);
        }

        void btnSaisirClassement_Click(object sender, EventArgs e)
        {
            // Question 5
            // instancie et affiche une nouvelle fenêtre de saisie des participants
        }

        // Question 6 
    }
}
