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
            rolls = new List<Roll>();
        }

        public List<Roll> Rolls { get => rolls; set => rolls = value; }
        public int Score
        {
            get
            {
                score = 0;
                Rolls.ForEach(s =>
                {
                    score += s.Pins;
                });
                return score;
            }
        }

        public bool MakeRoll2()
        {
            int max = 10;
            if (!_lastFrame)
            {
               
                if (rolls.Count >= 2)
                {
                    return false;
                }
                if (rolls.Count > 0)
                {
                    int firstRollPins = Rolls[0].Pins;
                    if (firstRollPins == 10)
                    {
                        return false;
                    }
                    max = 10 - firstRollPins;

                }
                int p = _generateur.RandomPin(max);
                Roll r = new Roll(p);
                Rolls.Add(r);
                return true;
            }
            else
            {
                if(rolls.Count <= 2 && (rolls[0].Pins == 10 || (rolls[0].Pins + rolls[1].Pins == 10))) {
                    int firstRollPins = Rolls[0].Pins;
                    if(rolls.Count <= 1)
                    {
                        max = (firstRollPins == 10) ? 10 : 10 - firstRollPins;
                    }
                    else
                    {
                        max = (Rolls[1].Pins == 10 || rolls[0].Pins + rolls[1].Pins == 10) ? 10 : 10 - Rolls[1].Pins;
                    }
                    int p = _generateur.RandomPin(max);
                    Roll r = new Roll(p);
                    Rolls.Add(r);
                    return true;
                }
                return false;
            }
        }


        public bool MakeRoll()
        {
            int max = 10;
            if (!_lastFrame)
            {
                if(Rolls.Count == 0 || (Rolls.Count < 2 && rolls[0].Pins < 10))
                {
                    max = Rolls.Count == 0 ? 10 : 10 - Rolls[0].Pins;                    
                    Rolls.Add(new Roll(_generateur.RandomPin(max)));
                    return true;
                }
                return false;
            }
            else
            {
                if (rolls.Count <= 2 && (rolls[0].Pins == 10 || (rolls[0].Pins + rolls[1].Pins == 10)))
                {
                    max = (Rolls.Count == 2 && Rolls[0].Pins + Rolls[1].Pins != 10) ? 10 - Rolls[1].Pins : 10;
                    Rolls.Add(new Roll(_generateur.RandomPin(max)));
                    return true;
                }
                return false;
            }
        }
    }
}
