using System;

class Rectangles
{
	public static void Main ()
	{
		Console.Write ("Enter the width of the rectangle: ");
		double width = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the height of the rectangle: ");
		double height = double.Parse (Console.ReadLine ());

		Console.WriteLine ("The perimeter of the rectagle is {0:F2}.", 2*(width+height));
		Console.WriteLine ("The area of the rectagle is {0:F2}.", width*height);
	}
}
