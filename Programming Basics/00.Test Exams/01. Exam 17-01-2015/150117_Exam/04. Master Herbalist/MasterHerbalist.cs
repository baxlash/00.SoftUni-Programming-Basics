using System;

class MasterHerbalist
{
    static void Main(string[] args)
    {
        string currentInput = string.Empty;
        int dailyExpenses = int.Parse(Console.ReadLine());
        //int dailyBalance = 0;

        while (currentInput != "Season Over")
        {
            int hours = 0;
            int herbs = 0;
            int price = 0;
            currentInput = Console.ReadLine();
            string[] splited = currentInput.Split(' ');
            hours = int.Parse(splited[0]);
            price = int.Parse(splited[2]);
            string path = splited[1];

            for (int i = 0; i < hours; i++)
            {
                int index = i;
                if (index>path.Length-1)
                {
                    index -= path.Length;
                }

                Console.WriteLine(path[index]);
                if (path[index] == 'H')
                {
                    herbs++;
                }
            }

        }
    }
}
