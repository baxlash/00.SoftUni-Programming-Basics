using System;

class BeerStock
{
    static void Main()
    {
        string currentInput = string.Empty;
        int reservedBeers = int.Parse(Console.ReadLine());
        long beers, sixPacks, cases;
        beers = 0;
        sixPacks = 0;
        cases = 0;

        do
        {
            currentInput = Console.ReadLine();
            string[] splited = currentInput.Split(' ');
            switch (splited[1])
            {
                case "Beers":
                    beers += long.Parse(splited[0]);
                    break;
                case "SixPacks":
                    sixPacks += long.Parse(splited[0]);
                    break;
                case "Cases":
                    cases += long.Parse(splited[0]);
                    break;
                default:
                    break;
            }
            //Console.WriteLine(beers);
            //Console.WriteLine(sixPacks);
            //Console.WriteLine(cases);
        } while (currentInput != "Exam Over");

        beers += sixPacks * 6 + cases * 24 - beers / 100;

        if (beers<reservedBeers)
        {
            long difference = reservedBeers - beers;
            long insufficientCases = difference / 24;
            long insufficientSixPacks = (difference % 24) / 6;
            long insufficientBeers = (difference % 24) % 6;

            Console.WriteLine(
                "Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", 
                insufficientCases,
                insufficientSixPacks,
                insufficientBeers
                );
        }
        else
        {
            long difference = beers - reservedBeers;
            long casesLeft = difference / 24;
            long sixPacksLeft = (difference % 24) / 6;
            long beersLeft = (difference % 24) % 6;

            Console.WriteLine(
                "Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.",
                casesLeft,
                sixPacksLeft,
                beersLeft);

        }
    }
}
