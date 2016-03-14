using System;

class OddOrEven
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		bool result = number % 2 != 0;

		Console.WriteLine ("Is the number {0} odd? - {1}", number, result);

	}
}
