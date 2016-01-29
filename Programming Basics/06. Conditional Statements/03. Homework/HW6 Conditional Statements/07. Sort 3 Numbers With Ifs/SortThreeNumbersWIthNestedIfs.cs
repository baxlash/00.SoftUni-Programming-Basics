using System;

class SortThreeNumbersWIthNestedIfs
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        string result = string.Empty;

        if (firstNumber < secondNumber)
        {
            if (secondNumber < thirdNumber)
            {
                result += thirdNumber + " " + secondNumber + " " + firstNumber;
            }
            else
            {
                result += secondNumber + " ";
                if (firstNumber < thirdNumber)
                {
                    result += thirdNumber + " " + firstNumber;
                }
                else
                {
                    result += firstNumber + " " + thirdNumber;
                }
            }
        }
        else
        {
            if (firstNumber < thirdNumber)
            {
                result += thirdNumber + " " + firstNumber + " " + secondNumber;
            }
            else
            {
                result += firstNumber + " ";
                if (secondNumber < thirdNumber)
                {
                    result += thirdNumber + " " + secondNumber;
                }
                else
                {
                    result += secondNumber + " " + thirdNumber;
                }
            }
        }

        Console.WriteLine(result);
    }
}