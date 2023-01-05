using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethode.Class
{
    static class Extention
    {
        // L'extention d'une class se fait avec le mot clé this avant le paramètre (qui représente le type)

        public static int Additionner(this int a, int b)
        {
            return a + b;
        }

        public static double Additionner(this double a, double b)
        {
            return a + b;
        }

        #region Extention Class List<T>


        public static void Shuffle<T>(this List<T> liste)
        {
            Random r = new Random();
            for (int i = 0; i < liste.Count; i++)
            {
                int index = r.Next(liste.Count);
                T tmp = liste[i];
                liste[i] = liste[index];
                liste[index] = tmp;
            }
        }
        #endregion
    }
}
