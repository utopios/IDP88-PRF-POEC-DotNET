using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Jeu
    {
        private IDe _de;

        public Jeu(IDe de)
        {
            _de = de;
        }

        public bool Jouer()
        {
            return _de.Lancer() == 20;
        }
    }
}
