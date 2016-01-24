using System;

class BankAccount
{
    static void Main()
    {
        String firstName = "Gudio";
        String middleName = "Gudev";
        String lastName = "Sachmanliev";
        decimal amount = 862.17m;
        String iban = "BG78STSA93000047952345";
        String cc1 = "3468 9742 4675 0756";
        String cc2 = "6654 7865 1354 8785";
        String cc3 = "3533 5556 7667 8890";

        Console.WriteLine("First Name:{0}\nMiddle Name: {1}\nLast Name: {2}\nAvailable Money: {3}\nIBAN: {4}\nCredit Card #1: {5}\nCredit Card #3: {6}\nCredit Card #3: {7}", firstName, middleName, lastName, amount, iban, cc1, cc2, cc3);
    }
}
