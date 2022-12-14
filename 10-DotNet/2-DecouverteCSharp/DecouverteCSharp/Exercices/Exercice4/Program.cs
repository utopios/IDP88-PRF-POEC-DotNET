
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Veuillez saisir votre âge : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bonjour " + prenom + " " + nom + ", vous avez " + age + " ans\n");
            Console.Write("Appuyez sur Enter pour fermer le programme...");
            Console.Read();