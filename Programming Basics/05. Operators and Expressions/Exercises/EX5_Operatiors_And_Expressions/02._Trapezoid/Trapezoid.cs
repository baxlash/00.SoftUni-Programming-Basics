using System;

class Trapezoid
{
	public static void Main ()
	{
		Console.Write ("a = ");
		double a = double.Parse (Console.ReadLine ());
		Console.Write ("b = ");
		double b = double.Parse (Console.ReadLine ());
		Console.Write ("h = ");
		double h = double.Parse (Console.ReadLine ());

		double area = ((a + b) / 2) * h;

		Console.WriteLine ("The are of the trapezoid with sides {0} and {1} and height {2} is {3}", a, b, h, area);
	}
}
