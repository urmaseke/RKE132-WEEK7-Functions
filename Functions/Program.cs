Console.WriteLine("Are you coming or leaving? (in/out):");
    string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else if (userChoice == "out")
{
    PrintGoodBye();
}

static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

    static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}



