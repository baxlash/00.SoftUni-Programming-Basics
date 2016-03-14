using System;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = zeroes(number);

        if (result==-1)
        {
            Console.WriteLine("The number has to be positive.");
        }
        else
        {
            Console.WriteLine("{0}! has {1} trailing zeroes.", number,result);
        }
    }

    static int zeroes(int number)
    {
        int count = 0;

        if (number<0)
        {
            return -1;
        }
        if (number==5)
        {
            return 1;
        }

        for (int j = 5; number / j >= 1; j *= 5)
        {
            count += number / j;
        }

        return count;
    }
}
