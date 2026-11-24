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
		switch(choose){
				case 1:
					phone.store();
					break;
				case 2:
					phone.edit();
					break;
			}
			}while(choose != 4);
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
	public void Getdetails(){
		Console.WriteLine($"\n {Surname} {FirstName} is a {Occupation}. His number is {PhoneNumber}");
		}
	public string GetNumber(){
		return StudentNumber;
		}
	}
	
class PhoneBook{
	List<Student> students = new List<Student>();
	
	public PhoneBook()
    {
        students = new List<Student>();
    }
    
	public void store(){
		bool anotherentry = true;
		
		
		while(anotherentry){
			Console.Write("enter student number: ");
			string StudentNumber = Console.ReadLine();
			Console.Write("enter student number: ");
			string Surname = Console.ReadLine();
			Console.Write("enter student number: ");
			string FirstName = Console.ReadLine();
			Console.Write("enter student number: ");
			string Occupation = Console.ReadLine();
			Console.Write("enter student number: ");
			char Gender = Convert.ToChar(Console.ReadLine());
			Console.Write("enter student number: ");
			string CountryCode = Console.ReadLine();
			Console.Write("enter student number: ");
			string AreaCode = Console.ReadLine();
			Console.Write("enter student number: ");
			string PhoneNumber = Console.ReadLine();
			
			Student newstudent = new Student(StudentNumber, Surname, FirstName, Occupation, Gender, CountryCode, AreaCode, PhoneNumber);
			students.Add(newstudent);
			Console.Write("do you want to store another student? Y/N: ");
			char choice = Convert.ToChar(Console.ReadLine());
			
			if(char.ToUpper(choice) == 'Y'){
				anotherentry = true;
				}
			else{
				anotherentry = false;
				}
			}
			
		}
		
		public void edit(){
			Console.Write("enter stduent number: ");
			string studentnum = Console.ReadLine();
			foreach(Student student in students){
				if (studentnum == student.GetNumber()){
					Console.WriteLine($"here is the existing information about {studentnum}:");
					student.Getdetails();
					}
				}
			}
	
	}
