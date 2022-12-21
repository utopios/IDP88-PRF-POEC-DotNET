using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpClassSalarie.Classes;

namespace TpClassSalarie
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal somme = 0;

            #region Salarié N°1
            Salarie s1 = new Salarie();
            s1.Nom = "Toto";
            s1.Categorie = "C001";
            s1.Matricule = "M001";
            s1.Service = "S001";
            s1.Salaire = 2000;
            #endregion

            #region Salarié N°2
            Salarie s2 = new Salarie();
            s2.Nom = "Titi";
            s2.Categorie = "C002";
            s2.Matricule = "M002";
            s2.Service = "S002";
            s2.Salaire = 2300;
            #endregion

            #region Salarié N°3
            Salarie s3 = new Salarie("M003", "C003", "S003", "Tata", 3000);
            #endregion

            #region Affichage du nombre d'instances
            Salarie.DisplayCounter();
            #endregion

            #region Remise à 0 du compteur d'instances
            Salarie.ResetCounter();
            #endregion

            #region Salarié N°4
            Salarie s4 = new Salarie("M004", "C004", "S004", "Tete", 3500);
            #endregion

            #region Création collection Salarié
            Salarie[] Salaries = new Salarie[] { s1, s2, s3, s4 };
            #endregion

            #region Display des Salaires
            foreach (Salarie s in Salaries)
            {
                s.AfficherSalaire();
                somme += s.Salaire;
            }
            #endregion

            #region Affichage des salaires
            Console.WriteLine("Le montant total des salaires mensuels est de " + somme + "€");
            Salarie.AfficherSommeSalaire();
            #endregion

            #region Affichage du nouveau compteur

            Salarie.DisplayCounter();

            #endregion

            #region Appel Volontaire au Garbage Collector (ramasse miettes)
            GC.Collect();
            #endregion



            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
