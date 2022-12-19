
double[] notes = new double[0];
Console.WriteLine("***** Tableaux des notes *****");
Console.Write("Combiens de notes comportera le tableaux : ");
bool ok = false;
while (!ok)
{
    if (int.TryParse(Console.ReadLine(), out int nb))
    {
        notes = new double[nb];
        ok = true;
        Console.WriteLine("");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("Merci de saisir les " + notes.Length + " notes\n");

for (int i = 0; i < notes.Length; i++)
{
    Console.Write("\t-Note " + (i + 1) + " : ");
    bool valid = false;
    while (!valid)
    {
        if (double.TryParse(Console.ReadLine(), out double note))
        {
            notes[i] = note;
            valid = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tErreur, merci de saisir un chiffre/nombre pour la note " + (i + 1) + " : ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n--- Liste des notes ---");
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; i < notes.Length; i++)
    Console.WriteLine("La note " + (i + 1) + " est de : " + notes[i] + "/20");



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n--- La note max est : " + notes.Max() + "/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- La note min est : " + notes.Min() + "/20");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("--- La moyenne est de : " + notes.Average() + "/20\n");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();