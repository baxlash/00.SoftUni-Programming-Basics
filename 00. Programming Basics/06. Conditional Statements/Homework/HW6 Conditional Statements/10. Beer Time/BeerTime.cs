using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time (hh:mm tt): ");
        string input = Console.ReadLine();

        DateTime time = DateTime.Parse(input);
        DateTime start = DateTime.Parse("01:00 PM");
        DateTime end = start.AddHours(14);


        if (time > start && time<end)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}
