using System;

class ExtractThirdBit
{
	public static void Main ()
	{
		int position = 3;
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());

		int shiftedNumber = number >> position;
		int bit = shiftedNumber & 1;

		Console.WriteLine ("The third bit is {0}.", bit);
	}
}
