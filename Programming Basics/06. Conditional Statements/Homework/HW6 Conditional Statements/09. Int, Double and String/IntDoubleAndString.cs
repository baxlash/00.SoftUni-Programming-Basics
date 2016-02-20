using System;

class IntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Input: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputStr = Console.ReadLine();
                Console.WriteLine(inputStr + "*");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
