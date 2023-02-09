// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Démo Multithreading
//Avec Thread
//Thread t1 = new Thread(() =>
//{
//    for(int i=1; i < 100000; i++)
//    {
//        Console.Write("A");
//    } 
//});


//Thread t2 = new Thread(() =>
//{
//    for (int i = 1; i < 100000; i++)
//    {
//        Console.Write("B");
//    }
//});

//t1.Start();
//t2.Start();

//Avec des Task

//Task t1 = Task.Factory.StartNew(() =>
//{
//    for (int i = 1; i < 1000; i++)
//    {
//        Console.Write("A");
//    }
//});

//Task<string> t2 = Task<string>.Factory.StartNew(() =>
//{
//    for (int i = 1; i < 1000; i++)
//    {
//        Console.Write("B");
//    }
//    return "J'ai terminé";
//});

//t1.Wait();
//t2.Wait();
//Console.WriteLine(t2.Result);


//Avec async await

Task<string> GetFromTaskAsync()
{
    return Task<string>.Factory.StartNew(() =>
    {
        for (int i = 1; i < 1000; i++)
        {
            Console.Write("B");
        }
        return "J'ai terminé";
    });
}

async void TestTask()
{
    string result = await GetFromTaskAsync();
    Console.WriteLine(result);
}

TestTask();
Console.ReadLine();