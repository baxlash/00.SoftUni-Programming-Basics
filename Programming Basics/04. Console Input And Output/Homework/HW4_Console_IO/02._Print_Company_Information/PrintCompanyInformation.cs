using System;

class PrintCompanyInformation
{
	public static void Main ()
	{
		string name;
		string address;
		string phoneNumber;
		string faxNumber;
		string website;
		string managerFirstName;
		string managerLastName;
		byte age;
		string managerPhoneNumber;

		Console.Write ("Enter the name of the company: ");
		name = Console.ReadLine ();
		Console.Write ("Enter the address of the company: ");
		address = Console.ReadLine ();
		Console.Write ("Enter the phone number of the company: ");
		phoneNumber = Console.ReadLine ();
		Console.Write ("Enter the fax number of the company: ");
		faxNumber = Console.ReadLine ();

		if (faxNumber == ""){
			faxNumber = ("no fax");
		}

		Console.Write ("Enter the website of the company: ");
		website = Console.ReadLine ();
		Console.Write ("Enter the first name of the manager: ");
		managerFirstName = Console.ReadLine ();
		Console.Write ("Enter the last name of the manager: ");
		managerLastName = Console.ReadLine ();
		Console.Write ("Enter the age of the manager: ");
		age = byte.Parse (Console.ReadLine ());
		Console.Write ("Enter the phone numner of the manager: ");
		managerPhoneNumber = Console.ReadLine ();


		Console.WriteLine ("{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWebsite: {4}\nManager: {5} {6} (age: {7} phone: {8})", name, address, phoneNumber, faxNumber, website, managerFirstName, managerLastName, age, managerPhoneNumber);
	}
}
