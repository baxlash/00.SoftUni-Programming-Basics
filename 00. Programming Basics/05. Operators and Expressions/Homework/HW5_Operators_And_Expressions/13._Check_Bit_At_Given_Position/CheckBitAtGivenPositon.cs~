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

		Console.WriteLine (isOne(bit));
	}

	public static bool isOne(int i){
		if (i == 1)
			return true;
		else
			return false;
	}
}
