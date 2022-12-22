using System;
using Heritage.Classes;


namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instanciation d'un objet Fleur et utilisation des méthodes disponibles
            Fleur cosmos = new Fleur("Cosmos", "Cosmos Sulphureus");
            Console.WriteLine("Mon nom est {0}", cosmos.Nom);
            Afficher(cosmos);
            Console.WriteLine("");
            #endregion

            #region Instancication d'un objet Chat et utilisation des méthodes disponibles
            Chat felix = new Chat("Felix", "Persan");
            Console.WriteLine("Mon nom est {0}", felix.Nom);
            felix.Naissance();
            felix.Reproduction();
            felix.Alimentation();
            felix.Expression();
            felix.Oxigenation();
            felix.Mort();
            Console.WriteLine("");
            #endregion

            #region Instanciation d'un objet Chien et utilisation des méthodes disponibles
            Chien medor = new Chien("Medor", "Berger Allemand");
            Console.WriteLine("Mon nom est {0}", medor.Nom);
            Afficher(medor);
            Console.WriteLine("");
            #endregion

            #region Instanciation d'un objet Poisson et utilisation des méthodes disponibles
            Poisson nemo = new Poisson("Némo", "PoissonClown");
            Console.WriteLine("Mon nom est {0}", nemo.Nom);
            nemo.Naissance();
            nemo.Reproduction();
            nemo.Alimentation();
            nemo.Expression();
            nemo.Oxigenation();
            nemo.Mort();
            Console.WriteLine("");
            #endregion

            #region Instanciation d'un objet Vache et utilisation des méthodes disponibles
            Vache marguerite = new Vache("Marguerite", "Salers");
            Console.WriteLine("Mon nom est {0}", marguerite.Nom);
            marguerite.Naissance();
            marguerite.Reproduction();
            marguerite.Alimentation();
            marguerite.Expression();
            marguerite.Oxigenation();
            marguerite.Mort();
            Console.WriteLine("");
            #endregion


            EtreVivant laVache = new Vache("VacheMeuuh", "Normande");
            Afficher(laVache);

            EtreVivant caniche = new Chien("Snoopy", "caniche");
            caniche.Naissance();
            caniche.Expression();
            Chien Snoopy = (Chien)caniche;
            caniche.Mort();
            Snoopy.Aboyer();
            Console.WriteLine(Snoopy.BattementCoeur);

            #region Tableau d'EtreVivant
            EtreVivant[] tab = new EtreVivant[6];
            EtreVivant etre1 = new Vache("Milka", "Normande");
            EtreVivant etre2 = new Chien("Rex", "Caniche");
            EtreVivant etre3 = new Chat("Ronron", "Persan");
            EtreVivant etre4 = new Poisson("Bubulle", "Poisson Rouge");
            EtreVivant etre5 = new Fleur("Belle", "Soucis");
            EtreVivant etre6 = new Pangolin("Relou", "D'Asie");

            tab[0] = etre1;
            tab[1] = etre2;
            tab[2] = etre3;
            tab[3] = etre4;
            tab[4] = etre5;
            tab[5] = etre6;
            foreach(EtreVivant e in tab)
            {
                Afficher(e);
            }

            #endregion

            #region Boxing / Unboxing
            // Unboxing de EtreVivant => Chien
            Chien medor2 = (Chien)etre2;
            medor.Aboyer();

            // Convertion de type
            for (int i = 0; i < tab.Length; i++)
            {
                // 1er solution Boxing => Unboxing
                // avant la convertion on peut vérifier le type de l'objet
                if (tab[i].GetType() == typeof(Chien))
                {
                    Chien c = (Chien)tab[i];
                    Afficher(c);
                }

                // 2eme solution => Utiliser le mot clé "as" pour effectuer une conversion
                Pangolin p = tab[i] as Pangolin;
                if (p != null)
                    Afficher(p);

                // 3eme solution => En utilisant le mot clé "is" pour effectuer une vérification
                if (tab[i] is Poisson poisson)
                    Afficher(poisson);
            }

            #endregion

            //#region Verification pour Marguerite
            //if (marguerite.BattementCoeur)
            //    marguerite.Naissance();
            //else
            //    marguerite.Mort();
            //#endregion

            //#region Passer un objet en paramètre de méthodes
            //Afficher(marguerite);
            //Afficher(medor);
            //#endregion

            Console.WriteLine("Stop!");
            Console.Read();

        }
        public static void Afficher(Vache v)
        {
            Console.WriteLine("Mon nom est {0}", v.NomVache);
            v.Naissance();
            v.Reproduction();
            v.Alimentation();
            v.Expression();
            v.Oxigenation();
            v.Mort();
        }
        public static void Afficher(Chien c)
        {
            Console.WriteLine("Mon nom est {0}", c.NomChien);
            c.Naissance();
            c.Reproduction();
            c.Alimentation();
            c.Expression();
            c.Oxigenation();
            c.Mort();
        }
        public static void Afficher(Fleur f)
        {
            Console.WriteLine("Mon nom est {0}", f.NomFleur);
            f.Naissance();
            f.Reproduction();
            f.Alimentation();
            f.Expression();
            f.Oxigenation();
            f.Mort();
        }
        public static void Afficher(EtreVivant e)
        {
            Console.WriteLine("Mon nom est {0}", e.Nom);
            Console.WriteLine("Je suis de type {0}", e.Type);
            e.Naissance();
            e.Reproduction();
            e.Alimentation();
            e.Expression();
            e.Oxigenation();
            e.Mort();
            Console.WriteLine("--------------------------------");
        }        
    }
}
