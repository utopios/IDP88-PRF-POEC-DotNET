using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpClassSalarie.Classes;

namespace Tp_ClasseSalarieHeritage.Classes
{
    internal class Commercial : Salarie
    {
        #region Attributs
        private decimal chiffreAffaire;
        private int commission;
        #endregion

        #region Constructeur
        public Commercial() : base()
        {

        }
        public Commercial(string matricule, string categorie, string service, string nom, decimal salaire, decimal chiffreAffaire, int commission) : base(matricule, categorie, service, nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }
        #endregion

        #region Propriétés
        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public int Commission { get => commission; set => commission = value; }
        #endregion

        #region Methodes
        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
            decimal salaireReel = Salaire + chiffreAffaire * commission / 100;
            Console.WriteLine($"Le salaire avec commission de {Nom} est de {salaireReel}€");
        }

        public void AfficherCommercial()
        {
            Console.WriteLine($"Je suis un commercial");
        }

        public override string ToString()
        {
            return "Je suis un commercial";
        }
        #endregion
    }
}
