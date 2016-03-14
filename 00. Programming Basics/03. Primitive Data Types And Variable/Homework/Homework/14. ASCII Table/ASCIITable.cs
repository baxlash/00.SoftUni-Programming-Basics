using System;

class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            char current = (char)i;
            Console.WriteLine("{0}. ASCII character is {1}", i, current);
        }
    }
}
