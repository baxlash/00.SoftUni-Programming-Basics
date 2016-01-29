using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        double anotherNumber = double.Parse(Console.ReadLine());

        if (number > anotherNumber)
        {
            Console.WriteLine("{0} {1}", anotherNumber, number);
        }
        else
        {
            Console.WriteLine("{0} {1}", number, anotherNumber);
        }
    }
}
