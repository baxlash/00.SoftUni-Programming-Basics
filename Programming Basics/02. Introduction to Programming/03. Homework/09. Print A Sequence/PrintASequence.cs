using System;
using System.Text;

class PrintLongSequence
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 2; i <= 11; i++)
        {
            if (isEven(i))
            {
                sb.Append(i + ", ");
            }
            else
            {
                sb.Append(-i + ", ");
            }
        }
        Char[] trim = { ',', ' ' };
        String output = sb.ToString().TrimEnd(trim);
        Console.WriteLine(output);

    }

    static bool isEven(int a)
    {
        if (a % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
