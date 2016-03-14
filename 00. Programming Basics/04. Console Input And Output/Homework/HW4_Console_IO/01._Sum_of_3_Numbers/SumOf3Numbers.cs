using System;

class SumOf3Numbers
{
	public static void Main ()
	{
		double numberOne;
		double numberTwo;
		double numberThree;

		Console.Write ("Enter the first numbers: ");
		numberOne = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the second number: ");
		numberTwo = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the third number: ");
		numberThree = double.Parse (Console.ReadLine ());

		Console.WriteLine ("The sum of {0:F2}, {1:F2} and {2:F2} is {3:F2}", numberOne, numberTwo, numberThree, numberOne+numberTwo+numberThree);
	}
}
