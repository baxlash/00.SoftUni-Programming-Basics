using System;
using System.Numerics;

class Calculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            result += fact(i) / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}",result);
    }

    static int fact(int n)
    {
        if (n==1)
        {
            return 1;
        }
        else
        {
            return n * fact(n - 1);
        }
    }


}
