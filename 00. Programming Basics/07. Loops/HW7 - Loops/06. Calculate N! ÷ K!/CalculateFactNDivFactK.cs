using System;

class CalculateFactNDivFactK
{
    static void Main(string[] args)
    {
        Console.Write("Enter value n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value k: ");
        int k = int.Parse(Console.ReadLine());

        if (k <= 1 || n <= k || n > 100)
        {
            Console.WriteLine("Input has to be 1 < k < n < 100");
        }
        else
        {
            int factN = 1;
            int factK = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i <= k)
                {
                    factK *= i;
                }
            }
            Console.WriteLine("{0}",factN/factK);
        }
    }
}
