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
            // Developper un méthode permmettant de comparer le caractere saisi par l'utilisateur avec le mot a touver

            return true;
        }

        public bool TestWin()
        {
            // Verifier si le motATouver a été trouvé
            return true;
        }

        public void GenererMasque()
        {
            // Générer un masque depuis le mot à trouver et l'assigne à la props Masque
        }
        #endregion
    }
}
