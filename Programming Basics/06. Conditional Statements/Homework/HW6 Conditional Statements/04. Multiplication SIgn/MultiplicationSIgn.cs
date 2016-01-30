using System;

class MultiplicationSIgn
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double[] numbers = { firstNumber, secondNumber, thirdNumber };
        bool isNegative = false;
        bool isZero = false;

        foreach (double number in numbers)
        {
            if (number == 0)
            {
                isZero = true;
                break;
            }
            else if (number < 0)
            {
                isNegative = !isNegative;
            }
        }

        if (isZero)
        {

            Console.WriteLine("0");
        }
        else if (isNegative)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}
