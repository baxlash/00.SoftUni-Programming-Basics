using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];
        int min = 0;
        int max = 0;
        int sum = 0;
        double average = 0;

        for (int i = 0; i < count; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                min = numbers[i];
                max = numbers[i + 1];
            }
            else
            {
                min = numbers[i + 1];
                max = numbers[i];
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }
        average = sum / numbers.Length;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0}", average);

    }
}
