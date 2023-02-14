using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class RechercheVille
    {
        private List<string> villes;

        public List<string> Villes { get => villes; set => villes = value; }

        public RechercheVille() {         
            Villes= new List<string>();
        }

        public List<string> Rechercher(string mot)
        {
            
            if(mot.Length < 2)
            {
                if (mot == "*")
                {
                    return Villes;
                }
                throw new NotFoundException();
            }
            else
            {
                return Villes.Where(x => x.ToLower().Contains(mot.ToLower())).ToList();
            }
        }
    }
}
