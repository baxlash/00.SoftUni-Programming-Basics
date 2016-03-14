using System;

class ExtractSpecificBit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		Console.Write ("Enter the position of the bit: ");
		int position = int.Parse (Console.ReadLine ());

		int shiftedNumber = number >> position;
		int bit = shiftedNumber & 1;

		Console.WriteLine ("Bit: {0}.", bit);
	}
}
