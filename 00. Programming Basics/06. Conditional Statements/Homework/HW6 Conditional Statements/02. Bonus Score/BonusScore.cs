using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 9: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine(number*10);
                break;
            case 2:
                Console.WriteLine(number*10);
                break;
            case 3:
                Console.WriteLine(number * 10);
                break;
            case 4:
                Console.WriteLine(number * 100);
                break;
            case 5:
                Console.WriteLine(number * 100);
                break;
            case 6:
                Console.WriteLine(number * 100);
                break;
            case 7:
                Console.WriteLine(number * 1000);
                break;
            case 8:
                Console.WriteLine(number * 1000);
                break;
            case 9:
                Console.WriteLine(number * 1000);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }
    }
}
