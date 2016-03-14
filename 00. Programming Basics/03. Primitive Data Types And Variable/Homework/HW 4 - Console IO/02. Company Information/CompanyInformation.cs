using System;

class CompanyInformation
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string phoneNumber;
        string fax;
        string website;
        string managerFirstName;
        string managerLastName;
        byte managerAge;
        string managerPhone;

        Console.Write("Company Name: ");
        companyName = Console.ReadLine();
        Console.Write("Company Address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        phoneNumber = Console.ReadLine();

        if (phoneNumber == "")
            phoneNumber = "n/a";

        Console.Write("Fax Number: ");
        fax = Console.ReadLine();

        if (fax == "")
            fax = "n/a";
                
        Console.Write("Website: ");
        website = Console.ReadLine();
        Console.Write("Manager First Name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Manager Last Name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Manager Age: ");
        managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager Phone: ");
        managerPhone = Console.ReadLine();

        if (managerPhone == "")
            managerPhone = "n/a";

        Console.WriteLine("Company Name: {0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWebsite {4}\nManager: {5}{6} (age: {7}, tel. {8}", 
            companyName, companyAddress, phoneNumber, fax, website, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
