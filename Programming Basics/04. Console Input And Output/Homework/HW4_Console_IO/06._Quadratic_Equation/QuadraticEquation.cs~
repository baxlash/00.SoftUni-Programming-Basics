using System;

class QuadraticEquation
{
	public static void Main (string[] args)
	{
		double a;
		double b;
		double c;
		double x1;
		double x2;
		double discriminant;

		Console.Write ("Enter a: ");
		a = double.Parse (Console.ReadLine ());
		Console.Write ("Enter b: ");
		b = double.Parse (Console.ReadLine ());
		Console.Write ("Enter c: ");
		c = double.Parse (Console.ReadLine ());

		discriminant = Math.Pow (b, 2) - 4 * a * c;

		x1 = (-b + Math.Sqrt (discriminant)) / 2 * a;
		x2 = (-b - Math.Sqrt (discriminant)) / 2 * a;

		if (discriminant > 0) {
			Console.WriteLine ("The quadratic equation has two roots: {0} and {1}.", x1, x2);
		} else if (discriminant == 0) {
			Console.WriteLine ("The quadratic equation has one root: {0}.", x1);
		} else {
			Console.WriteLine ("The quadratic equation has no roots.");
		}
	}
}
