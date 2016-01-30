using System;

class NthDigit
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());
		Console.Write ("Enter which digit if the number should discovered: ");
		int n = int.Parse (Console.ReadLine ());

		int nDigit = (number / (int) Math.Pow (10, n - 1)) % 10;

		if (n==1)
			Console.WriteLine ("The {0}st digit of {1} is {2}.", n, number, nDigit);
		else if (n==2)
			Console.WriteLine ("The {0}nd digit of {1} is {2}.", n, number, nDigit);
		else if (n==3)
			Console.WriteLine ("The {0}rd digit of {1} is {2}.", n, number, nDigit);
		else 
			Console.WriteLine ("The {0}th digit of {1} is {2}.", n, number, nDigit);
						
	}
}
