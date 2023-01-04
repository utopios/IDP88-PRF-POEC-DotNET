

using LesEvents.Class;

int limite = new Random().Next(10);
Counter c = new(limite);
Console.WriteLine($"La limite est fixée a {limite}.");
c.ActionNotificationLimiteAtteinte += NotificationLimiteAtteinte1;
c.ActionNotificationLimiteAtteinte += NotificationLimiteAtteinte1;
c.ActionNotificationLimiteAtteinte -= NotificationLimiteAtteinte1;
c.ActionNotificationLimiteAtteinte += NotificationLimiteAtteinte2;

Console.WriteLine("Presser la touche 'a' pour incrémenter le compteur.");

while (Console.ReadKey(true).KeyChar == 'a')
{
    Console.WriteLine("J'ajoute 1 au compteur...");
    c.Add(1);
}

void NotificationLimiteAtteinte1(object sender, EventArgs e)
{
    Console.WriteLine("Ma première action déclenchée par l'event!");
}


void NotificationLimiteAtteinte2(object sender, EventArgs e)
{
    Console.WriteLine("La limite est atteinte!");
    Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
    Console.Read();
}



