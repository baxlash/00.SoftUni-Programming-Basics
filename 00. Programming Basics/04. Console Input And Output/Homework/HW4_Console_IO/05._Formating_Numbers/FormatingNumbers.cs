using System;

class FormattingNumbers
{
	static void Main()
	{
		int firstNumber;
		double secondNumber;
		double thirdNumber;

		Console.Write ("Enter the first number: ");
		firstNumber = int.Parse(Console.ReadLine());
		Console.Write ("Enter the second number: ");
		secondNumber = double.Parse(Console.ReadLine());
		Console.Write ("Enter the third number: ");
		thirdNumber = double.Parse(Console.ReadLine());

		string binary = Convert.ToString(firstNumber, 2).PadLeft(10,'0');

		Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:F3}|", firstNumber, binary, secondNumber, thirdNumber);
	}
}