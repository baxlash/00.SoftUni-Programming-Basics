using System;

class BitsExchangeAdvanced
{
	public static void Main ()
	{
		try
		{
			Console.Write("Enter number: ");
			uint n = uint.Parse(Console.ReadLine());
			Console.Write("Enter starting bit for the first sequence: ");
			int p = int.Parse(Console.ReadLine());
			Console.Write("Enter starting bit for the second sequence: ");
			int q = int.Parse(Console.ReadLine());
			Console.Write("Enter number of bits in the sequence: ");
			int k = int.Parse(Console.ReadLine());

			bool overlapping = Math.Abs(p - q) < k;
			bool outOfRange = p < 0 | q < 0 | p + (k - 1) > 31 | q + (k - 1) > 31;

			if (!outOfRange && !overlapping)
			{
				uint firstBits = (n << (32 - p - k)) >> (32 - k);
				uint secondBits = (n << (32 - q - k)) >> (32 - k);
				n = n & ~(firstBits << p) | secondBits << p;
				n = n & ~(secondBits << q) | firstBits << q;
				Console.WriteLine("Result: {0}", n);
				Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
			}
			else if (outOfRange == true)
			{
				Console.WriteLine("Out Of Range");
			}
			else
			{
				Console.WriteLine("Overlapping");
			}
		}        
		catch (Exception)
		{
			Console.WriteLine("The given number exceeds the uint size");
		}       
	}
}
