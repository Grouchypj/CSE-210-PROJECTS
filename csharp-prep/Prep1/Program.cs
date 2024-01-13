using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name?" );
        String first = Console.ReadLine();

        Console.Write("what is your las name?" );
        string last = Console.ReadLine();

        Console.WriteLine($"your name is {last},{first} {last}.");
    }
}