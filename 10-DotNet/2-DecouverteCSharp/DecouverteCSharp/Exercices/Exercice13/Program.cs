
Console.WriteLine("--- Quelle est la nature du triangle ABC ? --- \n");

#region Récupération des saisies utilisateur

Console.Write("Entrez la longeur du segment AB : ");
double longeurAB = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment BC : ");
double longeurBC = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment CA : ");
double longeurAC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");
#endregion

#region If... Else Imbriquées

//if (longeurAB == longeurBC && longeurAB == longeurAC)
//    Console.WriteLine("Le triangle est équilatéral.\n");
//else
//{
//    if (longeurAB == longeurAC)
//        Console.WriteLine("Le triangle est isocèle en A.\n");
//    else
//    {
//        if (longeurAB == longeurBC)
//            Console.WriteLine("Le triangle est isocèle en B.\n");
//        else
//        {
//            if (longeurBC == longeurAC)
//                Console.WriteLine("Le triangle est isocèle en C.\n");
//            else
//                Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.\n");
//        }
//    }
//}

#endregion

#region If... Else If ... Else

if (longeurAB == longeurBC && longeurAB == longeurAC)
    Console.WriteLine("Le triangle est équilatéral.\n");
else if (longeurAB == longeurAC)
    Console.WriteLine("Le triangle est isocèle en A.\n");
else if (longeurAB == longeurBC)
    Console.WriteLine("Le triangle est isocèle en B.\n");
else if (longeurBC == longeurAC)
    Console.WriteLine("Le triangle est isocèle en C.\n");
else
    Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.\n");

#endregion


Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();