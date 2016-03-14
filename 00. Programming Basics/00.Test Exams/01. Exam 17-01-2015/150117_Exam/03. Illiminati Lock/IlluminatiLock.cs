using System;

class IlluminatiLock
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int length = 3 * input;
        char eye = '#';
        char filler = '.';

        string sideBorder = new string(filler, input);
        string middleBorder = new string(eye, input);
        Console.WriteLine("{0}{1}{0}", sideBorder, middleBorder);

        for (int i = 1; i <= input / 2; i++)
        {
            int sideSpace = input - 2 * i;
            int centerSpace = input - 2;
            int middleSpace = (length - 2 * sideSpace - centerSpace - 6) / 2;
            string side = new string(filler, sideSpace);
            string center = new string(filler, centerSpace);
            string middle = new string(filler, middleSpace);

            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", side, middle, center);
        }

        for (int i = input / 2; i > 0; i--)
        {
            int sideSpace = input - 2 * i;
            int centerSpace = input - 2;
            int middleSpace = (length - 2 * sideSpace - centerSpace - 6) / 2;
            string side = new string(filler, sideSpace);
            string center = new string(filler, centerSpace);
            string middle = new string(filler, middleSpace);

            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", side, middle, center);
        }

        Console.WriteLine("{0}{1}{0}", sideBorder, middleBorder);

    }
}