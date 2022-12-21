using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_ClasseChaise.Classes
{
    internal class Chaise
    {
        #region Attibuts
        private int nbPieds;
        private string couleur;
        private string materiaux;
        #endregion

        #region Constructeur
        public Chaise() 
        { 
        }

        public Chaise(int nbPieds, string couleur, string materiaux)
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }
        #endregion

        #region Props
        public int NbPieds { get => nbPieds; set => nbPieds = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }

        #endregion

        #region Methods
        public void Afficher()
        {
            Console.WriteLine("------------------- Affichage d'un nouvel objet -------------------");
            Console.WriteLine($"\nJe suis une chaise, avec {nbPieds} pieds en {materiaux} et de couleur {couleur}.\n");
            Console.WriteLine("-------------------------------------------------------------------");
        }
        #endregion
    }
}
