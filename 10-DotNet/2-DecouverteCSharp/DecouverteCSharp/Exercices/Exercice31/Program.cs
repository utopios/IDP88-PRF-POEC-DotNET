
            #region Déclaration des variables
            double maxNote = 0;
            double minNote = 20;
            double moyNote = 0;
            double noteTmp;
            string choixMenu;
            int nbNote = 1;
            #endregion

            #region Interface Utilisateur
            do
            {
                Console.WriteLine("--- Gestion des notes avec menu --- \n");
                Console.WriteLine("1----Saisir les notes");
                Console.WriteLine("2----La plus grande note");
                Console.WriteLine("3----La plus petite note");
                Console.WriteLine("4----La moyenne des notes");
                Console.WriteLine("0----Quitter\n");
                Console.Write("Faites votre choix : ");
                choixMenu = Console.ReadLine();
                while (choixMenu != "1" && choixMenu != "2" && choixMenu != "3" && choixMenu != "4" && choixMenu != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Faites votre choix : ");
                    choixMenu = Console.ReadLine();
                }

                Console.Clear();
                switch (choixMenu)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("------ Saisir les notes ------");
                        Console.WriteLine("(999 pour stoper la saisie)\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            Console.Write("Merci de saisir la note " + nbNote + " (sur /20) : ");
                            noteTmp = 0;                            
                            if (int.TryParse(Console.ReadLine(), out int nb))
                            {
                                noteTmp = nb;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\tErreur de saisie, merci de saisir un chiffre/nombre! ");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }
                            if (noteTmp == 999)
                            {
                                nbNote = nbNote - 1;
                                break;
                            }
                            if (noteTmp > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }
                            moyNote += noteTmp;
                            if (noteTmp > maxNote)
                                maxNote = noteTmp;
                            if (noteTmp < minNote)
                                minNote = noteTmp;
                            nbNote++;
                        } while (noteTmp != 999);
                        Console.Clear();
                        break;
                    case "2":
                        if (nbNote > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("------ La plus grande note ------\n");
                            Console.WriteLine("La note la plus grande est : " + maxNote + "/20\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("------ La plus grande note ------\n");
                            Console.WriteLine("Veuillez saisir des notes avant... \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "3":
                        if (nbNote > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("------ La plus petite note ------\n");
                            Console.WriteLine("La note la plus petite est : " + minNote + "/20\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("------ La plus petite note ------\n");
                            Console.WriteLine("Veuillez saisir des notes avant... \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "4":
                        if (nbNote > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("------ La moyenne des notes ------\n");
                            moyNote = Math.Round(moyNote / nbNote, 1);
                            Console.WriteLine("La moyenne est de : " + moyNote + "/20\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("------ La moyenne des notes ------\n");
                            Console.WriteLine("Veuillez saisir des notes avant... \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "0":
                        //Fermer une console
                        Environment.Exit(0);
                        break;
                    
                }
            } while (choixMenu != "0");
            #endregion