using System;

class FibonacciNumbers
{
	public static void Main ()
	{
		Console.Write ("Enter a number: ");
		int number = int.Parse (Console.ReadLine());
		Console.WriteLine ("The first {0} Fibonacci numbers are:", number);
		for (int i = 1; i <= number; i++) {
			Console.Write (fiboNumbers (i) + " ");
		}
	}

	public static int fiboNumbers(int fib)
	{
		if (fib == 1)
			return 0;
		else if (fib == 2)
			return 1;
		else
			return fiboNumbers (fib - 1) + fiboNumbers (fib - 2);
	}
}
