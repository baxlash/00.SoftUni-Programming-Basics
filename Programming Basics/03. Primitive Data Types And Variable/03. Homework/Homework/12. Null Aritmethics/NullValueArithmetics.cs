using System;

class NullValueArithmetics
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = 15;
        nullDouble = 156.35643d;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
            }
}
