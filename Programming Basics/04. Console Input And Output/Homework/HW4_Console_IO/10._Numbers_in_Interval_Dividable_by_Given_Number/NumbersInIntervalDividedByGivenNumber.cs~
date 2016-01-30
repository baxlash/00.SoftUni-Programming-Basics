using System;

class NumbersInIntervalDividedByGivenNumber
{
	public static void Main ()
	{
		Console.Write ("Enter the start number of the interval: ");
		int start = int.Parse (Console.ReadLine ());
		Console.Write ("Enter the end number of the interval: ");
		int end = int.Parse (Console.ReadLine ());
		string result = "";
		int numberOfResults = 0;

		for (int i = start; i <= end; i++) {
			if (i % 5 == 0) {
				result += (i.ToString() + " ");
				numberOfResults++;
			}
		}

		Console.WriteLine ("There are {0} number between {1} and {2} which can be divided by 5 with out reminder", numberOfResults, start, end);
		Console.WriteLine ("These numbers are: {0}", result);

	}
}
