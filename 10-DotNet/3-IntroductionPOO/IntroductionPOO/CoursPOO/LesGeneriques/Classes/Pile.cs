using System;
using System.Collections.Generic;
using System.Text;

namespace LesGeneriques.Classes
{
    class Pile<T>
    {
        T[] elements;
        int taille;
        int compteur = 0;
        

        public Pile(int t)
        {
            taille = t;
            elements = new T[taille];
        }

        public void Empiler(T element)
        {
            if (compteur < taille)
            {
                elements[compteur] = element;
                compteur++;
            }
            else
                Console.WriteLine("La pile est pleine.");
        }

        public void Depiler()
        {
            if (compteur > 0)
            {
                Console.WriteLine("Je dépile le dernier élément... ");
                elements[compteur - 1] = default(T);
                compteur--;
            }
        }

        public T Get(int index)
        {
            return elements[index];
        }
    }
}
