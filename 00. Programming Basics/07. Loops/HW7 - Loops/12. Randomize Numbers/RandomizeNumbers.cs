using System;
using System.Collections.Generic;

class RandomizeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        int[] result = Randomize(numbers).ToArray();

        foreach (int number in result)
        {
            Console.Write("{0,3} ", number);
        }
        Console.WriteLine();
    }

    public static List<int> Randomize(int[] numbers)
    {
        List<int> randomized = new List<int>();
        List<int> original = new List<int>(numbers);
        Random r = new Random();
        while (original.Count > 0)
        {
            int index = r.Next(original.Count);
            randomized.Add(original[index]);
            original.RemoveAt(index);
        }

        return randomized;
    }
}
