using System;

class FourdigitNumber
{
	public static void Main ()
	{
		Console.Write ("Enter a four-digits number: ");
		string number = Console.ReadLine ();
		char[] digits = number.ToCharArray ();

		int sum = 0;
		foreach (char digit in digits) {
			sum += int.Parse (digit.ToString ());
		}

		string reversed = "";
		for (int i = digits.Length; i > 0; i--) {
			reversed += digits [i - 1].ToString ();
		}

		string lastToFirst = "" + digits [3] + digits [0] + digits [1] + digits [2];
		string secondTwoSwapped = "" + digits [0] + digits [2] + digits [1] + digits [3];

		Console.WriteLine ("Sum: {0}.", sum);
		Console.WriteLine ("Reversed: {0}", reversed);
		Console.WriteLine ("Last digit first: {0}", lastToFirst);
		Console.WriteLine ("Second and third digit swapped: {0}", secondTwoSwapped);
	}
}
