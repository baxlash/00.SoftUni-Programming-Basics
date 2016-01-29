using System;


//TO BE FINISHED



class NumbersToWords
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        int hundreds = input / 100;
        int tens = (input % 100) / 10;
        int ones = (input % 100) % 10;

        Console.WriteLine("{0} hundred and {1} {2}", digitToWord(hundreds), digitToWord(tens), digitToWord(ones));
    }

    //static string digitToWordTens(int digit)
   // {

   // }
    static string digitToWord(int digit)
    {
        switch (digit)
        {
            case 0:
                return "";

            case 1:
                return "one";

            case 2:
                return "two";

            case 3:
                return "three";

            case 4:
                return "four";

            case 5:
                return "five";

            case 6:
                return "six";

            case 7:
                return "seven";

            case 8:
                return "eight";

            case 9:
                return "nine";

            default:
                return "not a digit";

        }
    }
}

