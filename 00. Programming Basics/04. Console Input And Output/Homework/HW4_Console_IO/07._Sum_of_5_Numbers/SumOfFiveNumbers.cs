using System;

class SumOfFiveNumbers
{
	public static void Main ()
	{
		string stringOfNumbers;
		char[] delimerter = {' '};
		string[] numbers;
		double result = 0 	;

		Console.WriteLine ("Enter a string of 5 integers separated by spaces:");
		stringOfNumbers = Console.ReadLine();

		numbers=stringOfNumbers.Split(delimerter);

		foreach (var number in numbers)
		{
			result += double.Parse(number);
		}

		Console.WriteLine ("The sum if the given numbers is {0:F2}.", result);
	}
}
