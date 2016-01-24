using System;

class Trapezoid
{
	public static void Main ()
	{
		Console.Write ("Enter the lenght of the upper side: ");
		double upper = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the length of the lower side: ");
		double lower = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the length of the height: ");
		double height = double.Parse (Console.ReadLine ());

		double area = ((upper + lower) / 2) * height;

		Console.WriteLine ("The area of the trapezoid is {0:F2}", area);
	}
}
