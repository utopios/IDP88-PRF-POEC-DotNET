// See https://aka.ms/new-console-template for more information

//Initialisation des tableaux et variables
string[] participants = { "Luffy", "Naruto", "Izuku", "Ichigo", "Allen", "Jolyne", "Guts", "Nagisa", "Maka", "Edward" };
string[] gagnants = new string[10];
string[] restants = participants;
int menuSelect, numGagnant;


//La boucle do while englobe toute l'application, avec sa condition de sortie comme moyen de fermer
do
{

    //Affichage du menu et récupération du choix de l'utilisateur dans une variable qui va servir pour le switch case venant juste après.
    Console.WriteLine("\n Que souhaitez-vous faire ?");
    Console.WriteLine("\t 1) Tirer un participant");
    Console.WriteLine("\t 2) Afficher la liste de ceux qui sont passés");
    Console.WriteLine("\t 3) Afficher la liste de ceux qui restent ");
    Console.WriteLine("\t 0) Quitter ");
    menuSelect = Convert.ToInt32(Console.ReadLine());

    switch (menuSelect)
    {

        //Cas pour tirer un participant au sort. C'est ici que nous allons avoir la mise à jour des 2 tableaux gagnants et restant en simultané
        case 1:

            //Nous tirons ici un numéro au sort correspondant à un index du tableau des participants dans une boucle do while.
            //Pour sortir, il faut que le numéro tiré ne se trouve déjà pas dans le tableau des gagnants, sinon un nouveau numéro est tiré.
            do
            {
                numGagnant = new Random().Next(0, 10);
                Console.WriteLine(numGagnant);
            } while (Array.IndexOf(gagnants, participants[numGagnant]) != -1);

            //Affichage du gagnant avec un clear pour faire propre.
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"And the winner is {participants[numGagnant]} ! \n");
            Console.ForegroundColor = ConsoleColor.White;

            //Ici, nous insérons le nouveau gagnants dans le tableau des gagnants, un break est fait pour éviter d'itérer sur les cellules encore vide.
            for (int i = 0; i < gagnants.Length; i++)
            {
                if (gagnants[i] == null)
                {
                    gagnants[i] = participants[numGagnant];
                    break;
                }
            }
            
            //Mise à jour du tableau de ceux qui restent,
            //nous passons par un tableau temporaire qui reçoit toutes les valeurs du tableau restants excepté celui qui vient d'être tiré
            //puis la valeur du tableau temporaire est réaffecté au tableau restants
            string[] tmp = new string[10];
            for (int i = 0; i < tmp.Length; i++)
            {
                if (participants[numGagnant] != restants[i]) { 
                tmp[i] = restants[i];
                }
            }
            restants = tmp;


            //Une fois que tout le monde est passé, donc que le tableau gagnant est rempli, nous remettons ce dernier à zéro
            //Le tableau restants reprenant la valeur du tableau participants.
            if (Array.IndexOf(gagnants, null) == -1)
            {
               Array.Fill(gagnants, null, 0, gagnants.Length);
                restants = participants;
            }
            break;

            //Affichage de ceux qui sont déjà passées
        case 2:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Liste des personnes qui sont passées \n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < gagnants.Length; i++)
            {

                //Ici, le break permet d'éviter d'itérer sur des cellules vides d'une part et de les afficher en console d'autre part.
                Console.WriteLine(gagnants[i]);
                if (gagnants[i+1] == null)
                {
                    break;
                }
                     for(int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }

            };
            break;

            //Affichage de ceux qui doivent encore passer.
        case 3:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Liste des personnes qui restent \n");
            Console.ForegroundColor = ConsoleColor.White;

            int k = 1;

            //Une condition est mis dans la boucle pour ne pas afficher les cellules vides.
            for (int i = 0; i < restants.Length; i++)
            {
                if(restants[i] != null) {
                Console.WriteLine(restants[i]);

                    for (int j = 0; j < k; j++)
                    {
                        Console.Write(" ");
                    }
                    k++;
                }

            };
            break;

        case 0: 
            Console.WriteLine("A bientôt !");
            break;

    }
} while (menuSelect != 0);
Environment.Exit(0);

