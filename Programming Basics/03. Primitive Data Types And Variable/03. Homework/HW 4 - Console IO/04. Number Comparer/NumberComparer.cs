using System;

class NumberComparer
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;

        Console.Write("First Number: ");
        firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Greater is: " + Math.Max(firstNumber,secondNumber));
    }
}
