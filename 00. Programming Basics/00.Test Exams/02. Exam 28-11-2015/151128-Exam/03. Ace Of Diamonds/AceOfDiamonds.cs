using System;

class AceOfDiamonds
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int innerWidth = width - 2;

        string edge = new string('*', width);

        Console.WriteLine(edge);

        for (int row = 0; row < innerWidth / 2; row++)
        {
            string outer = new string('-', innerWidth / 2 - row);
            string inner = new string('@', row * 2 + 1);
            Console.WriteLine("*{0}{1}{0}*", outer, inner);
        }
        string middle = new string('@', innerWidth);
        Console.WriteLine("*{0}*", middle);

        for (int row = innerWidth/2-1; row >= 0; row--)
        {
            string outer = new string('-', innerWidth / 2 - row);
            string inner = new string('@', row * 2 + 1);
            Console.WriteLine("*{0}{1}{0}*", outer, inner);
        }

        Console.WriteLine(edge);
    }
}
