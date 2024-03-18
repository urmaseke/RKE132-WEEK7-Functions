Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyword(userInput);

static void PrintAnyword(string anyString)
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }    
}
