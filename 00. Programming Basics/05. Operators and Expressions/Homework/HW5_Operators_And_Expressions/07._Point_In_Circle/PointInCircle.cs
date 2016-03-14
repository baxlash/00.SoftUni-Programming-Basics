using System;

class PointInCircle
{
	public static void Main ()
	{
		Console.Write ("Enter X coord: ");
		int x = int.Parse (Console.ReadLine ());
		Console.Write ("Enter Y coord: ");
		int y = int.Parse (Console.ReadLine ());

		bool isInCircle = x * x + y * y <= 2 * 2;

		Console.WriteLine (isInCircle);
	}
}
