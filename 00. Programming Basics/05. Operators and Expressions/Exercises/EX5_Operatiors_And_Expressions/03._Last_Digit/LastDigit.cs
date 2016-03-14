using System;

class LastDigit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());

		int lasrDigit = number % 10;

		Console.WriteLine ("The lase digit of the number {0} is {1}.", number, lasrDigit);
	}
}
