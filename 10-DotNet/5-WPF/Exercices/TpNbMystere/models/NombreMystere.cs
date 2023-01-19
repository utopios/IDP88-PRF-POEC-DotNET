using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpNbMystere.models
{
    internal class NombreMystere
    {
        private Random aleatoire;
        private int nbMystere;
        private int nbCoups;
        private bool gagne;

        public NombreMystere()
        {
            Start();
        }

        public Random Aleatoire { get => aleatoire; set => aleatoire = value; }
        public int NbMystere { get => nbMystere; set => nbMystere = value; }
        public int NbCoups { get => nbCoups; set => nbCoups = value; }
        public bool Gagne { get => gagne; set => gagne = value; }

        public void Start()
        {
            aleatoire = new Random();
            NbMystere = aleatoire.Next(1, 51);
            NbCoups = 0;
            Gagne = false;
        }

        public string TestNumber(int number)
        {
            string response = "";
            nbCoups++;
            switch (number)
            {
                case int tmp when tmp <NbMystere:
                    response = $"C'est plus que {number}...";
                    break;
                case int tmp when tmp > NbMystere:
                    response = $"C'est moins que {number}...";
                    break;
                case int tmp when tmp == NbMystere:
                    gagne = true;
                    response = $"Bravo!!!Vous avez trouvé en {nbCoups}.";
                    break;
                default:
                    break;
            }
            return response;
        }

    }
}
