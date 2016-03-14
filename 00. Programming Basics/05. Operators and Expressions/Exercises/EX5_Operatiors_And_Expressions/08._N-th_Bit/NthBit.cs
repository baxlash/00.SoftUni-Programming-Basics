using System;

class NthBit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		Console.Write ("Enter which bit do you want to discover: ");
		int bit = int.Parse (Console.ReadLine ());
		int shiftedNumber = number >> bit;
		int bitAtPosition = shiftedNumber & 1;
		Console.WriteLine (bitAtPosition);
	}
}
