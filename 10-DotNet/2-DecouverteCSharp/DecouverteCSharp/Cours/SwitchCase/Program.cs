
#region SwitchCase Simple avec String en condition
//string civilite = "Mr";
//string civilite = "Mme";
string civilite = "Mlle";

switch (civilite)
{
	case "Mr":
		Console.WriteLine("Bonjour Monsieur");
		break;	
	case "Mme":
		Console.WriteLine("Bonjour Madame");
		break;	
	case "Mlle":
		Console.WriteLine("Bonjour Mademoiselle");
		break;
	default:
        Console.WriteLine("Bonjour Undefined");
        break;
}
#endregion

#region SwitchCase Simple avec int en condition
int choix = 5;

switch (choix)
{
    case 1:
        Console.WriteLine("Choix 1");
        break;
    case 2:
        Console.WriteLine("Choix 2");
        break;
    case 3:
        Console.WriteLine("Choix 3");
        break;
    default:
        Console.WriteLine("Erreur de choix...");
        break;
}
#endregion

#region SwitchCase avec comparaison de valeur double
int zero = 0;
double compte = 00;

switch (compte)
{
    case double n  when n > zero:
        Console.WriteLine("Votre compte est créditeur");
        break;
    case double n when n == zero:
        Console.WriteLine("Le montant de vote compte est nul");
        break;
    //case double n when n < zero:
    //    Console.WriteLine("Votre compte est débiteur");
    //    break;
    default:
        Console.WriteLine("Votre compte est débiteur");
        break;
}

#endregion

#region SwitchCase avec comparaison et range de valeur int 

int age = 10;

switch (age)
{
    case int n when n > 0 && n <= 12:
        Console.WriteLine("Votre êtes un enfant");
        break;
    case int n when n > 12 && n < 18:
        Console.WriteLine("Vous êtes un ado");
        break;
    case int n when n >= 18:
        Console.WriteLine("Vous êtes un adulte");
        break;
    default:
        Console.WriteLine("Vous êtes quoi?");
        break;
}
#endregion





Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();