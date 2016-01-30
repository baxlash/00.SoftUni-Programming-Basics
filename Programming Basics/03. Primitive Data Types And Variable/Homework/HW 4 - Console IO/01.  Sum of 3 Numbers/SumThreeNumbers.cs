using System;

class SumThreeNumbers
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        double thirdNumber;

        Console.Write("Enter first number: ");
        firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter thirdnumber: ");
        thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of three numbers is {0:F2}", firstNumber+secondNumber+thirdNumber);

    }
}
