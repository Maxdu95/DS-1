using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dsSlalomSki
{
    public class Competiteur {
        int numeroCompetiteur;
        string nomCompetiteur;
        string prenomCompetiteur;
        int classementFis;
        int classementWcsl;

        public Competiteur(string nomCompetiteur){
            this.nomCompetiteur = nomCompetiteur;
        }

        public string GetNom { get { return this.nomCompetiteur; } }
    }
}
