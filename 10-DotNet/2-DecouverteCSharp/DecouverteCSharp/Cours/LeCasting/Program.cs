using System;

namespace LeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting implicite [Slide 33]
            // Caster un short en int
            short @short = 200;
            int @int = @short;
            Console.WriteLine(@int);
            #endregion

            #region Casting Explicite [Slide 34]
            // Caster deux variables numériques
            int @int1 = 200;
            short @short1 = (short)@int1;
            Console.WriteLine(@int1);
            #endregion

        }
    }
}
