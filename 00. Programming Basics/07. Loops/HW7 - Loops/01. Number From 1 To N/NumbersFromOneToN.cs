using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
