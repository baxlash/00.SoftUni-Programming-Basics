using System;

class Matrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n,n];
        

        for (int i = 0; i < n; i++)
        {
            int incr = i + 1;
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = incr     ;
                Console.Write("{0,3}", matrix[i, j]);
                incr++;
            }
            Console.WriteLine();
        }
    }
}