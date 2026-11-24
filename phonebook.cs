using System;
using System.Collections.Generic;

class Program{
	static void Main(){
		int choose;
		PhoneBook phone = new PhoneBook();
		
		do{
		Console.WriteLine("[1] store to ASEAN phonebook");
		Console.WriteLine("[2] edit entry in ASEAN phonebook");
		Console.WriteLine("[3] search ASEAN phonebook by country");
		Console.WriteLine("[4] exit");
		
		Console.Write("enter a number: ");
		choose = Convert.ToInt32(Console.ReadLine());
		}
	}
	
class Student{
	string StudentNumber;
	string Surname;
	string FirstName;
	string Occupation;
	char Gender;
	string CountryCode;
	string AreaCode;
	string PhoneNumber;
	
	public Student(string studentnumber, string surname, string firstname, string occupation, char gender, string countrycode, string areacode, string phonenumber){
		this.StudentNumber = studentnumber;
		this.Surname = surname;
		this.FirstName = firstname;
		this.Occupation = occupation;
		this.Gender = gender;
		this.CountryCode = countrycode;
		this.AreaCode = areacode;
		this.PhoneNumber = phonenumber;
		}
}
