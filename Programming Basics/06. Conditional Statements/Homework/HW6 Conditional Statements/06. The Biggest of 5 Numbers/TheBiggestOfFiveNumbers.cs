using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double[] numbers = { firstNumber, secondNumber, thirdNumber, fourthNumber,fifthNumber };
        double biggest = double.MinValue;


        for (int i = 0; i < numbers.Length; i++)
        {
            if (biggest < numbers[i])
            {
                biggest = numbers[i];
            }
            
        }

        Console.WriteLine(biggest);
    }
}
