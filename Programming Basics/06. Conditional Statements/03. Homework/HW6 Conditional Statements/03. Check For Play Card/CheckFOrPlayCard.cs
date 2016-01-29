using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Enter a symbol to check if it is a play card symbol: ");
        string symbol = Console.ReadLine();

        string cards = "2 3 4 5 6 7 8 9 10 J Q K A";
        string[] card = cards.Split();
        bool isCard = false;

        foreach (var item in card)
        {
            if (symbol==item)
            {
                isCard = true;
                break;
            }
        }

        if (isCard)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        
    }
}
