using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}\nb = {1}", a, b);

        int swap = a;
        a = b;
        b = swap;

        Console.WriteLine("\nAfter:");
        Console.WriteLine("a = {0}\nb = {1}", a, b);

    }
}
