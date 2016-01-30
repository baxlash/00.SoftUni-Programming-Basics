using System;

class BiggestOfThree
{
	public static void Main ()
	{
		Console.Write ("Enter first number: ");
		double firstNumber = double.Parse (Console.ReadLine ());
		Console.Write ("Enter second number: ");
		double secondNumber = double.Parse (Console.ReadLine ());
		Console.Write ("Enter third number: ");
		double thirdNumber = double.Parse (Console.ReadLine ());

		if (firstNumber == secondNumber && secondNumber == thirdNumber) {
			Console.WriteLine ("The numbers are equal");
		}else if (firstNumber==secondNumber) {
			if (firstNumber>thirdNumber) {
				Console.WriteLine ("First and second are equal and the biggest");
			} else {
				Console.WriteLine ("Third number is the biggest");
			}
		} 
		else if (firstNumber > secondNumber) {
			if (firstNumber == thirdNumber) {
				Console.WriteLine ("First and third are equal and the biggest");
			} else if (firstNumber > thirdNumber) {
				Console.WriteLine ("First number is the biggest");
			} else {
				Console.WriteLine ("Third number is the biggest");
			}
		} else {
			if (secondNumber == thirdNumber) {
				Console.WriteLine ("Second and third are equal and the biggest");
			} else if (secondNumber > thirdNumber) {
				Console.WriteLine ("Second number is the biggest");
			} else {
				Console.WriteLine ("Third number is the biggest");
			}
		}
	}
}
