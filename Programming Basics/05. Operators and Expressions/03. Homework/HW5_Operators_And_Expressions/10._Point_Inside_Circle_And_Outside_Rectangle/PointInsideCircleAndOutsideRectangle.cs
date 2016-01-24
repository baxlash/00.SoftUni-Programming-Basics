using System;

class PointInsideCircleAndOutsideRectangle
{
	public static void Main ()
	{
		Console.Write ("Enter X coord: ");
		double x = double.Parse (Console.ReadLine ());
		Console.Write ("Enter Y coord: ");
		double y = double.Parse (Console.ReadLine ());

		bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
		bool outsideRectangle = !((x < 5 && x > -1) && (y < 1 && y > -1));

		if (isInCircle && outsideRectangle)
			Console.WriteLine ("yes");
		else
			Console.WriteLine ("no");
	}
}
