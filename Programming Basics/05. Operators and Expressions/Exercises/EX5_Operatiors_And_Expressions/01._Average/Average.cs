using System;

class Average
{
	public static void Main ()
	{
		Console.Write ("Enter first number: ");
		int firstNumber = int.Parse (Console.ReadLine ());
		Console.Write ("Enter second number: ");
		int secondNumber = int.Parse (Console.ReadLine ());
		Console.Write ("Enter third number: ");
		int thirdNumber = int.Parse (Console.ReadLine ());

		double result = (double)(firstNumber + secondNumber + thirdNumber) / 3;

		Console.WriteLine ("The average of the three number is {0}",result);
	}
}