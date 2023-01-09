using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpListContactBaseClass.Tools
{
    internal class MyRegex
    {
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
