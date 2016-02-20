using System;

class TakeThePlaneDown
{
    static void Main(string[] args)
    {
        int hqX = int.Parse(Console.ReadLine());
        int hqY = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int numberOfPlanes = int.Parse(Console.ReadLine());

        while (numberOfPlanes > 0)
        {
            int planeX = int.Parse(Console.ReadLine());
            int planeY = int.Parse(Console.ReadLine());

            bool isInside = Math.Pow(planeX - hqX, 2) + Math.Pow(planeY - hqY, 2) < Math.Pow(radius, 2);

            if (isInside)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
            }
            numberOfPlanes--;
        }
    }
}
