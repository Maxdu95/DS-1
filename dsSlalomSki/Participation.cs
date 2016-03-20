using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dsSlalomSki
{
    public class Participation    {
        private Competiteur leCompetiteur;
        private int numeroDossard; // numéro de dossard attribué pour une course
        private int classement;    // classement obtenu en fin de course
        
        public Participation(Competiteur unCompetiteur) {
            this.leCompetiteur = unCompetiteur;
            this.classement = 0;
            this.numeroDossard = 0;
        }

        public int GetNumeroDossard { get { return this.numeroDossard; } }
        public Competiteur GetLeCompetiteur { get { return this.leCompetiteur; } }
        public int GetClassement { get { return this.classement; } }

        public int SetClassement { set { this.classement = value; } }
        public int SetNumeroDossard { set { this.numeroDossard = value; } }

        public override string ToString() {
            return string.Format("{0,-30}\t{1:00}\t{2:00}",this.leCompetiteur.GetNom,this.numeroDossard,this.classement);
        }
     }
}
