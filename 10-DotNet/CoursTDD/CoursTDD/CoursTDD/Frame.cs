using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Frame
    {
        private int score;
        private bool _lastFrame;
        private IGenerateur _generateur;
        private List<Roll> rolls;

        public Frame(IGenerateur generateur, bool lastFrame)
        {
            _lastFrame = lastFrame;
            _generateur = generateur;
        }

        public List<Roll> Rolls { get => rolls; set => rolls = value; }
        public int Score { get => score; }

        public bool MakeRoll()
        {
            throw new NotImplementedException();
        }
    }
}
