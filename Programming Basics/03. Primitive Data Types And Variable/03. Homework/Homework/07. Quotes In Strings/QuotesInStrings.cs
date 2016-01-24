using System;

class QuotesInStrings
{
    static void Main()
    {
        String str1 = "The \"use\" of quotations causes difficulties.";
        String str2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}
