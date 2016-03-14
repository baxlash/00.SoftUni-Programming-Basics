using System;

class SudokuResults
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int count = 0;
        int totalTime = 0;

        do
        {
            if (input == "Quit")
            {
                continue;
            }

            string[] splitted = input.Split(':');
            int minutes = int.Parse(splitted[0]);
            int seconds = int.Parse(splitted[1]);

            seconds += minutes * 60;
            totalTime += seconds;
            count++;

            input = Console.ReadLine();

        } while (input != "Quit");

        int average = (int)Math.Ceiling((double)totalTime / count);

        if (average < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (average >= 720 && average <= 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else
        {
            Console.WriteLine("Bronze Star");
        }

        Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
    }
}
