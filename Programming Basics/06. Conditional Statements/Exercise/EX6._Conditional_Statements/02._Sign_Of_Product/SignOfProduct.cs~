using System;

class SignOfProduct
{
	public static void Main ()
	{
		Console.Write ("Enter first number: ");
		double firstNumber = double.Parse (Console.ReadLine ());
		Console.Write ("Enter second number: ");
		double secondNumber = double.Parse (Console.ReadLine ());
		Console.Write ("Enter third number: ");
		double thirdNumber = double.Parse (Console.ReadLine ());

		//double product = firstNumber * secondNumber * thirdNumber;
		bool isNegative = false;

		if (firstNumber < 0) {
			isNegative = !isNegative;
		}
		if (secondNumber<0) {
			isNegative = !isNegative;
		}
		if (thirdNumber<0) {
			isNegative = !isNegative;
		}
		if (isNegative) {
			Console.WriteLine ("Negative");
		} else {
			Console.WriteLine ("Positive");
		}
	}
}
