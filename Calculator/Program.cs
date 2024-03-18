using System;

Console.WriteLine("Enter the operation (+/-):");
char userOperator= char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int Firstnum= Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int Secondnum= Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
    Addition(Firstnum, Secondnum);
        break;
    case '-':
        Substraction(Firstnum, Secondnum);
        break;
        default:
        Console.WriteLine("Invalid operator.");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}