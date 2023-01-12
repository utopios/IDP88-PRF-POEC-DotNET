using System;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    class Adresse : IAdresse
    {
        public void AdresseInformation()
        {
            Console.WriteLine("J'affiche l'adresse...");
        }
    }
}
