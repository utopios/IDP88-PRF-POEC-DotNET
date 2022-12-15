
Console.OutputEncoding = System.Text.Encoding.UTF8;

#region Déclaration des variables globale à la classe
int salaire, age, anciennete;
double indemnite = 0;
#endregion

#region Récupération saisies utilisateur
Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? --- \n");

Console.Write("Merci de saisir le dernier salaire (en €uros): ");
salaire = Convert.ToInt32(Console.ReadLine());

Console.Write("Merci de saisir votre âge : ");
age = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
anciennete = Convert.ToInt32(Console.ReadLine());

#endregion

#region Indemnité liée à l'ancienneté
Console.WriteLine(" ");

if (anciennete >= 1 && anciennete <= 10)
    indemnite += anciennete * salaire / 2;

if (anciennete > 10)
{
    indemnite += 10 * salaire / 2;
    indemnite += (anciennete - 10) * salaire;
}
#endregion

#region Indemnité liée à l'age du salarié
if (anciennete >= 1 && age > 45)
{
    if (age >= 50)
        indemnite += 5 * salaire;
    else
        indemnite += 2 * salaire;
}
#endregion

#region Avec un ternaire (sugar syntaxe)
/* Sugar Syntaxe 
if (age > 45)
    indemnite += (age < 50) ? 2 * salaire : 5 * salaire;
*/
#endregion

#region Affichage de résultats
Console.WriteLine("Votre indemnité est de : " + indemnite + " € \n");
#endregion


Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();