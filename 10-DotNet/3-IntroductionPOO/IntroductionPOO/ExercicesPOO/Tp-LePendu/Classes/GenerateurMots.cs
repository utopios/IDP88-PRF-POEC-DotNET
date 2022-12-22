using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_LePendu.Classes
{
    internal class GenerateurMots
    {
        private string[] mots = new string[] { "amazon", "google", "facebook", "microsoft", "macintosh", "instagram" };


        public string Generer()
        {
            Random rnd = new();
            int rndIndex= rnd.Next(mots.Length);
            return mots[rndIndex];
        }
    }
}
