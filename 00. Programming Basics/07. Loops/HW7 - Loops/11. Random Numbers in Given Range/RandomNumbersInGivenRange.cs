using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for max: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();


        if (min>max)
        {
            Console.WriteLine("invalid input");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                int randomNumber = rnd.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }

    }
}
