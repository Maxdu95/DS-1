using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dsSlalomSki
{
    public class CourseSlalom     {
        private string nomCompetion;
        private DateTime dateCompetition;
        private List<Participation> lesParticipants;

        private void classerLesParticipants() {
            // ordonne la collection des participants
            // dans l'ordre du classement Wcsl puis Fis
            // le code ne vous est pas fourni
        }

        public CourseSlalom(List<Competiteur> competiteursParticipants) {
            this.nomCompetion = "";
            this.dateCompetition = DateTime.Now;
            this.lesParticipants = new List<Participation>();
            foreach (Competiteur c in competiteursParticipants)
            {
                lesParticipants.Add(new Participation(c));
            }
        }

        private void attribuerDossardsSlalom(int borneInférieure, int borneSupérieure) {
            List<int>lesDossardADistribuer=new List<int>();
            for (int i=borneInférieure;i<=borneSupérieure;i++){
                lesDossardADistribuer.Add(i);
            }
            int trouve=0;
            int inf= borneSupérieure;
            int sup = borneSupérieure;
            Random r = new Random();
            int hasard;
            for(int i = inf;i<=sup;i++){
                int position = r.Next(0,lesDossardADistribuer.Count);
                lesParticipants[i].SetNumeroDossard=lesDossardADistribuer[position];
                lesDossardADistribuer.RemoveAt(position);
            }

        }

        public void TraitementDossardsSlalom()
        {
            this.classerLesParticipants();
            this.attribuerDossardsSlalom(1, 7);
            this.attribuerDossardsSlalom(8, 15);
            for (int i = 16; i < lesParticipants.Count(); i++)
            {
                lesParticipants[i].SetNumeroDossard = i;
            }
        }

        public override string ToString()
        {
            string s = "";
            int i = 1;
            foreach (Participation p in this.lesParticipants) {
                s = s + string.Format(" {2:00} - {1:00} - {0}\n", p.GetLeCompetiteur.GetNom, p.GetNumeroDossard, i);
                i++;
            }
            return s;
        }

        public List<Participation> LesParticipants { get { return this.lesParticipants; } }
    }
}
