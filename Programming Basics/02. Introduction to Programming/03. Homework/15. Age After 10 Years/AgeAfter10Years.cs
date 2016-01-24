using System;

    class AgeAfter10Years
    {
    
        static void Main()
        {
        DateTime birthDate = new DateTime();
        Console.WriteLine("Enter your birth date in format dd.mm.yyyy:");
        Console.Write(">");
        String bDay = Console.ReadLine();

        birthDate = DateTime.Parse(bDay);
        DateTime now =  DateTime.Today;
        int age = now.Year - birthDate.Year;

        Console.WriteLine("Now: " + age);
        Console.WriteLine("In 10 years: " + (age + 10));
        }
    }
