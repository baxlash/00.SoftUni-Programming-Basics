using System;

class FallenInLove
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int width = input * 2 * 2 + 6;

        for (int i = 0; i < input; i++)
        {
            string backgroundOuter = new string('.', input * 2 - 2 * i);
            string backgroundInner = new string('.', i * 2);
            string leaves = new string('~', i);

            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", leaves, backgroundOuter, backgroundInner);
        }

        for (int i = 0; i < input; i++)
        {
            string backgroundOuter = new string('.', 2 * i + 1);
            string backgroundInner = new string('.', 2 * input - 2 * i);
            string leaves = new string('~', input - i);

            Console.WriteLine("{0}#{1}#{2}#{1}#{0}", backgroundOuter, leaves, backgroundInner);
        }
        Console.WriteLine("{0}####{0}", new string('.', 2 * input + 1));

        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', 2 * input + 2));
        }
    }
}
