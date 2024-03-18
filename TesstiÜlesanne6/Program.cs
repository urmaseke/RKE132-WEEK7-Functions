Console.WriteLine("Which to you want to convert (c/f):");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter value to convert:");
int Firstnum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case 'c':
        Celsius(Firstnum);
        break;
    case 'f':
        Fahrenhite(Firstnum);
        break;
    default:
        Console.WriteLine("Invalid operator.");
        break;
}

static void Celsius(int a)
{
    Console.WriteLine($"({a}*{9}) / {5}+{32}= {(a*9)/5+32}");
}

static void Fahrenhite(int a)
{
    Console.WriteLine($"({a} -{32})* {5}/{9} ={(a-32)*5/9}");
}

