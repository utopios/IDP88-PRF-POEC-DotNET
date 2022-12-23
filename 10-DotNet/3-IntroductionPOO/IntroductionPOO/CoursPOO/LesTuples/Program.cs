using LesTuples.Classes;

// Les Tuples sont arrivés en C#7

#region Déclaration d'un Tuple
(double, int) T1 = (4.5, 3);

Console.WriteLine($"Tuple avec en item 1 : {T1.Item1} et en item 2 : {T1.Item2}");
#endregion

#region Déclaration d'un Tuple as Variable
(double Sum, int Count) T2 = (4.5, 3);

Console.WriteLine($"Tuple avec en item 1 : {T2.Sum} et en item 2 : {T2.Count}");
#endregion


#region Appel de fonction Tuple
MyTuple t1 = new();

var result = t1.GetTuple();

Console.WriteLine(result.Item1);
Console.WriteLine(result.Item2);

var result2 = t1.GetTriple();

Console.WriteLine(result2.Item1);
Console.WriteLine(result2.Item2);
Console.WriteLine(result2.Item3);
#endregion

Console.WriteLine("\nAppuyez sur enter pour fermer le programme");
Console.Read();
