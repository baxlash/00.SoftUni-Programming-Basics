using System;

class GreaterCommonDivisor
{
    static void Main(string[] args)
    {
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());

        int result = GCD(a, b);

        Console.WriteLine("The GCD of {0} and {1} is {2}", a, b, result);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }
}
