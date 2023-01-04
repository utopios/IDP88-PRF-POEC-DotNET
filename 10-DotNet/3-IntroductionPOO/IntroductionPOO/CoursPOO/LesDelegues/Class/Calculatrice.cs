using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LesDelegues.Class
{
    internal class Calculatrice
    {
        #region Ancienne syntaxe
        //public delegate double DelegateMethodeCalcule(double nb1 , double nb2 );

        //public void Calcule(double a , double b, DelegateMethodeCalcule methode)
        //{
        //    Console.WriteLine(methode(a, b));
        //} 

        //public delegate void DelegateVoid(string s);

        //public void HowToDisplay(string message, DelegateVoid methode)
        //{
        //    methode(message);
        //}
        #endregion

        #region Action / Func
        // Deux Type de délégués : Action & Func
        // ACTION => Délégué sans retour (voir)
        // FUNC => Délegué avec retour (int, string, bool...etc.)


        // Func<double, double,double> Les premiers doubles sont les params et le dernier le type de retour 
        public void Calcule(double a, double b, Func<double, double, double> methode)
        {
            Console.WriteLine(methode(a, b));
        }


        // Action<string> pour les type de paramètres... sans retour
        public void HowToDisplay(string message, Action<string> methode)
        {
            methode(message);
        }
        #endregion
    }
}
