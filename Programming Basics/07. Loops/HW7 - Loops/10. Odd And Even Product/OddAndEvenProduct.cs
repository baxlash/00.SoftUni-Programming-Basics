using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string of numbers separated by space: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        int[] nmbrs = new int[numbers.Length];

        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            nmbrs[i] = int.Parse(numbers[i]);
            if (i%2==0)
            {
                oddProduct *= nmbrs[i];
            }
            else
            {
                evenProduct *= nmbrs[i];
            }
        }
        if (oddProduct==evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}
