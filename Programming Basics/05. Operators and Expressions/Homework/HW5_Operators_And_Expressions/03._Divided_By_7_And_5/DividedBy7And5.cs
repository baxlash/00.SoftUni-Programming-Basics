using System;

class DividedBy7And5
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		bool result = number % 35 != 0;

		Console.WriteLine ("Could the number {0} be divided by 7 and 5? - {1}", number, result);

	}
}
