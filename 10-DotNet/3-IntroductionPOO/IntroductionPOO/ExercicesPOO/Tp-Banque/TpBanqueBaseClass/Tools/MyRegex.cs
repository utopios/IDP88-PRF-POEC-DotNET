using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpBanqueBaseClass.Tools
{
    internal class MyRegex
    {
        /*
        * Pattern Regex
        *  ^ = commence
        *  $ = fin
        *  \d = nombre
        *  \w = Letter, Digit, Underscrore
        *  \s = White-Space(tabs, spaces)
        *  \D = Tout sauf les \d
        *  \W = Tout sauf des \w
        *  \S = Tout sauf les \s
        *  | = OU
        *  * = 0 ou plus
        *  + = au moins une fois
        *  ? = 0 ou 1 fois
        *  {1} = nb répétition
        *  {2,4}= 2 à 4 fois
        *  . = tout sauf Return
        */

        public static bool IsName(string name)
        {
            // Anthony Di Persio Mickaël
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-_]*$";

            return Regex.IsMatch(name, pattern);
        }

        public static bool IsPhone(string phone)
        {
            // +33 6 12 34 56 78 || +33612345678 || 0612345678 || 06.12.34.56.78 || 33-6-12-34-56-78 || 33612345678
            string pattern = @"^([0|\+33|33]+)([\.\-\s])?([1-9]{1})(([\.\-\s])?[0-9]{2}){4}$";
            return Regex.IsMatch(phone, pattern);
        }

        public static bool IsEmail(string email)
        {   // mon.nom@mon.domaine.ext
            string pattern = @"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-]+)([\.])?([a-zA-Z0-9\-]+)?([\.]){1}([a-zA-Z]{2,13})$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
