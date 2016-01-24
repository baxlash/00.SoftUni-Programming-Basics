using System;

class ExtractSpecificBit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		Console.Write ("Enter the position of the bit: ");
		int position = int.Parse (Console.ReadLine ());
		Console.Write ("Enter the new value: ");
		int newValue = int.Parse (Console.ReadLine ());


		if (newValue == 1) {
			int result = setOne (number, position);
			Console.WriteLine ("Binary result: {0,16}", Convert.ToString (result, 2).PadLeft(16,'0'));
			Console.WriteLine ("Decimal result: {0}", result);
		} else {
			int result = setZero (number, position);
			Console.WriteLine ("Binary result: {0}", Convert.ToString (result, 2).PadLeft(16,'0'));
			Console.WriteLine ("Decimal result: {0}", result);
		}
	}

	public static int setZero(int number, int position)
	{
		int mask = ~(1 << position);
		return number & mask;
	}

	public static int setOne(int number, int position)
	{
		int mask = 1 << position;
		return number | mask;
	}
	
}
