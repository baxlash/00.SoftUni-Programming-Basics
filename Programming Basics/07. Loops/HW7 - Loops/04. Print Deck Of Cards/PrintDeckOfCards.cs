using System;
using System.Text;

class PrintDeckOfCards
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string cards = "2 3 4 5 6 7 8 9 10 J Q K A";
        string[] card = cards.Split();
        char[] suits = { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int i = 0; i < card.Length; i++)
        {
            foreach (char suit in suits)
            {
                Console.Write("{0,3}{1} ", card[i], suit);
            }
            Console.WriteLine();
        }
    }
}
