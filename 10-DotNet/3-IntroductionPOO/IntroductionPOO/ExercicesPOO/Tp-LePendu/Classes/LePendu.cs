using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_LePendu.Classes
{
    internal class LePendu
    {
        #region Attributs
        private GenerateurMots generateur;
        private string motATrouver;
        private int nbreEssais;
        private string masque;

        #endregion

        #region Constructeur
        public LePendu()
        {
            Generateur = new GenerateurMots();
            MotATrouver = Generateur.Generer();
            GenererMasque();
            NbreEssais = 10;
        }
        #endregion

        #region Propriétés
        public string MotATrouver { get => motATrouver; set => motATrouver = value; }
        public int NbreEssais { get => nbreEssais; set => nbreEssais = value; }
        public string Masque { get => masque; set => masque = value; }
        public GenerateurMots Generateur { get => generateur; set => generateur = value; }
        #endregion

        #region Methodes
        public bool TestChar(char c)
        {
            bool found = false;
            string masqueTmp = "";
            for (int i = 0; i < motATrouver.Length; i++)
            {
                if (motATrouver[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else                
                    masqueTmp += masque[i];
            }
            masque = masqueTmp;

            if (!found)            
                nbreEssais--;          

            return found;
        }

        public bool TestWin()
        {
            //if (MotATrouver == Masque && NbreEssais > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return MotATrouver == Masque && NbreEssais > 0;
        }

        public void GenererMasque()
        {
            masque = "";
            for (int i = 0; i < motATrouver.Length; i++)            
                masque += "*";            
        }
        #endregion
    }
}
