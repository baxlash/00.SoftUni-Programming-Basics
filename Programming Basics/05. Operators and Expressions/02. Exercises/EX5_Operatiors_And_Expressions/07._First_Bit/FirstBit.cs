using System;

class FirstBit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		int shiftedNumber = number >> 1;
		int bitAtPosition1 = shiftedNumber & 1;
		Console.WriteLine (bitAtPosition1);
	}
}
