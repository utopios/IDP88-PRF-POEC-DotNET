
using CoursAdoNET.Class;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;

#region Cours AdoNET
// Connection à la dase de Données
string connectionString = @"Data Source=(LocalDB)\IDP88;Integrated Security=True";

// création d'un objet de type SqlConnection
SqlConnection connection = new SqlConnection(connectionString);

// Pour Executer une requête SQL, on utilise l'objet Command
// Préparation de la commande SQL
//string request = "INSERT INTO PERSON (nom, prenom, email, telephone) VALUES ('Test1','Testy','test@testy.fr','+33 6 41 52 41 52')";
//string request = "INSERT INTO PERSON (nom, prenom, email, telephone) OUTPUT INSERTED.ID VALUES ('Test2','Testy','test2@testy.fr','+33 6 41 52 41 99')";
//string request = "SELECT Top 5 * FROM person";


// Préparation de l'objet commanbde avec les params
//SqlCommand command = new SqlCommand(request, connection);

// ouverture de la connection
//connection.Open();

// 1ere méthode d'éxecution de la commande : ExecuteNonQuery() => Retourne le nombre de ligne(s) affecté(s) par la commande
//int nbLigne = command.ExecuteNonQuery();
// 2eme méthode d'éxecution de la commande : ExecuteScalar() => Retourne le champs indiqué dans la request
//int Id = (int)command.ExecuteScalar();   
// 3eme méthode d'éxecution d'une commande : ExecuteReader() => Retourne l'ensemble des résultats correspondant
//SqlDataReader reader = command.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine($"ID : {reader.GetInt32(0)}, Nom : {reader.GetString(1)} Prenom : {reader.GetString(2)} - Email : {reader.GetString(3)} - Téléphone : {reader.GetString(4)}");
//}


//// Liberation de l'objet command
//command.Dispose();
//// Fermeture de la connection
//connection.Close();

////Console.WriteLine(Id);




#endregion

#region SQL PARAMETERS

// Récupération saisies utilisateur
Console.Write("Veuillez saisir le Nom : ");
string nom = Console.ReadLine();
Console.Write("Veuillez saisir le Prénom : ");
string prenom = Console.ReadLine();
Console.Write("Veuillez saisir l'email : ");
string email = Console.ReadLine();
Console.Write("Veuillez saisir le téléphone : ");
string telephone = Console.ReadLine();

//// Rédaction de notre requete
string request = "INSERT INTO PERSON (nom, prenom, email, telephone) VALUES ( @Nom, @Prenom, @Email, @Telephone )";
//// Création d'une instance de SqlCommand
SqlCommand command= new SqlCommand(request, connection);

//// Ajout des params à notre request
command.Parameters.Add(new SqlParameter("@Nom", nom));
command.Parameters.Add(new SqlParameter("@Prenom", prenom));
command.Parameters.Add(new SqlParameter("@Email", email));
command.Parameters.Add(new SqlParameter("@Telephone", telephone));

//// Execution de la commande
//connection.Open();
//int nbLigne = command.ExecuteNonQuery();
//command.Dispose();
//connection.Close();

//Console.WriteLine("Nombre de lignes affectées par la commande : "+nbLigne);
#endregion

#region MD5 Hash
// Récupération saisies utilisateur
Console.Write("Veuillez saisir le Login : ");
string login = Console.ReadLine();
Console.Write("Veuillez saisir le Password : ");
string password = Console.ReadLine();

Utilisateur u = new(login, password);

(bool, int) result = u.Add();

if (result.Item1)
{
    u.Id = result.Item2;
    Console.WriteLine("L'id d'insertion de l'utilisateur est : " + u.Id);
}



#endregion




Console.WriteLine("Appuyez sur ENTER pour fermer la console");
Console.Read();
