using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dsSlalomSki;

namespace ds01SlalomSkiWf
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CourseSlalom cs = new CourseSlalom(dsSlalomSki.Program.lesCompetiteurs());
            cs.TraitementDossardsSlalom();

            Application.Run(new FResultatSlalom(cs.LesParticipants));
        }
    }
}
