using System;

class MasterHerbalist
{
    static void Main(string[] args)
    {
        string currentInput = string.Empty;
        int dailyExpenses = int.Parse(Console.ReadLine());
        double balance = 0;
        int days = 0;

        while (true)
        {
            int hours = 0;
            int dailyHerbs = 0;
            int dailyPrice = 0;
            currentInput = Console.ReadLine();
            if (currentInput == "Season Over")
            {
                break;
            }

            string[] splited = currentInput.Split(' ');
            hours = int.Parse(splited[0]);
            dailyPrice = int.Parse(splited[2]);
            string path = splited[1];

            for (int i = 0; i < hours; i++)
            {
                int index = i;
                if (index > path.Length - 1)
                {
                    index %= path.Length;
                }

                if (path[index] == 'H')
                {
                    dailyHerbs++;
                }
            }
            int dailyIncome = dailyPrice * dailyHerbs;
            int dailyBalance = dailyIncome - dailyExpenses;
            balance += dailyBalance;
            days++;
        }
        if (balance > 0)
        {
            double avarageBalance = balance / days;
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", avarageBalance);
        }
        else
        {
            Console.WriteLine("We are in the red. Money needed: {0}.", balance * (-1));
        }
    }
}
