using System;

namespace LeBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration d'une variable de type Objet i et Boxing de i dans o
            int i = 123;
            // Boxing
            object o = i;
            #endregion

            #region Unboxing de o dans i
            o = 456;
            // Unboxing
            i = (int)o;
            Console.WriteLine(i);
            #endregion
        }
    }
}
