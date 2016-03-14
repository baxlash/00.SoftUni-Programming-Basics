using System;

class ProspectInHospitality
{
    static void Main(string[] args)
    {
        uint builders = uint.Parse(Console.ReadLine());
        uint receptionists = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technicians = uint.Parse(Console.ReadLine());
        uint others = uint.Parse(Console.ReadLine());

        decimal nikiSalary = decimal.Parse(Console.ReadLine());
        decimal usdRate = decimal.Parse(Console.ReadLine());
        decimal coderSalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal builderSalary = 1500.04m;
        decimal receptionistSalary = 2102.10m;
        decimal chambermaidSalary = 1465.46m;
        decimal technicianSalary = 2053.33m;
        decimal otherSalary = 3010.98m;

        decimal totalExpenses = builders * builderSalary + receptionists * receptionistSalary + chambermaids * chambermaidSalary + technicians * technicianSalary + others * otherSalary + nikiSalary * usdRate + coderSalary;
        Console.WriteLine("The amount is: {0:F2} lv.", totalExpenses);

        if (totalExpenses < budget)
        {
            Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - totalExpenses);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", totalExpenses - budget);
        }


    }
}
