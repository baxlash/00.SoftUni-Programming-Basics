using System;

class PrimeNumberCheck
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine ());

		bool result = isPrime (number);
		Console.WriteLine (result);

	
	}

	public static bool isPrime(int number)
	{
		int anchor = (int) Math.Sqrt(number);

		if (number == 1) return false;
		if (number == 2) return true;

		for (int i = 2; i <= anchor; ++i)  {
			if (number % i == 0)  return false;
		}

		return true;        
	}
}
