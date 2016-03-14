using System;
using System.Numerics;

class CathalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger cathalan = 1;

        if (n==0)
        {
            Console.WriteLine(cathalan);
        }
        else
        {
            cathalan = fact(2 * n) / (fact(n + 1) * fact(n));
            Console.WriteLine(cathalan);

        }


    }

    static BigInteger fact(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * fact(n - 1);
        }
    }
}
