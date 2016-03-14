using System;

class CakeTycoon
{
	public static void Main (string[] args)
	{
		ulong numberOfCakes = ulong.Parse (Console.ReadLine ());
		double flourNeededPerCake = double.Parse (Console.ReadLine ());
		ulong flourAvailable = ulong.Parse (Console.ReadLine ());
		ulong truffles = ulong.Parse (Console.ReadLine ());
		ulong trufflesPrice = ulong.Parse (Console.ReadLine ());

		double cakesMakable = flourAvailable / flourNeededPerCake;

		if (cakesMakable > numberOfCakes) {
			ulong trufflesCost = truffles * trufflesPrice;
			double cakePrice = (trufflesCost / numberOfCakes) * 1.25;

			Console.WriteLine (
				"All products available, price of a cake: {0:F2}", 
				cakePrice);
		} else {
			double totalFlourNeeded = numberOfCakes * flourNeededPerCake;
			double differenceInFlour = totalFlourNeeded - flourAvailable;

			Console.WriteLine (
				"Can make only {0} cakes, need {1:F2} kg more flour", 
				Math.Floor (cakesMakable),
				differenceInFlour);
		}

	}
}
