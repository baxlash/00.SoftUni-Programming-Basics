using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine();

        int dec = 0;

        for (int i = 0; i < bin.Length; i++)
        {
            if (bin[bin.Length - i - 1] == '0')
            {
                continue;
            }
            dec += (int)Math.Pow(2, i);
        }

        Console.WriteLine("Decimal: {0}", dec);
    }
}