using System;

class ImpressTheGirlfriend
{
    public static void Main(string[] args)
    {
        long rubles = long.Parse(Console.ReadLine());
        long dollars = long.Parse(Console.ReadLine());
        long euros = long.Parse(Console.ReadLine());
        long levaB = long.Parse(Console.ReadLine());
        long levaM = long.Parse(Console.ReadLine());

        decimal rublesToLevaRate = 0.035m;
        decimal dollarsToLevaRate = 1.5m;
        decimal eurosToLevaRate = 1.95m;

        decimal rublesToLeva = rubles * rublesToLevaRate;
        decimal dollarsToLeva = dollars * dollarsToLevaRate;
        decimal eurosToLeva = euros * eurosToLevaRate;

        Console.WriteLine("{0:F2}", Math.Ceiling(Math.Max(rublesToLeva, Math.Max(dollarsToLeva, Math.Max(eurosToLeva, Math.Max(levaB / 2, levaM))))));

    }
}