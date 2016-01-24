using System;


class CiclePerimeterArea
{
    static void Main()
    {
        double pi = Math.PI;
        double radius;

        Console.Write("Radius: ");
        radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0:F2}", 2 * pi * radius);
        Console.WriteLine("Area: {0:F2}", Math.Pow(radius,2)*pi);
    }
}
