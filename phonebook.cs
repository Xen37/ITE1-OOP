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
	public string GetCountrycode(){
		return CountryCode;
		}
	public void SetStudentnumber(string studentnumber){
		StudentNumber = studentnumber;
		}
	public void SetSurname(string surname){
		Surname = surname;
		}
	public void SetGender(char gender){
		Gender = gender;
		}
	public void SetOccupation(string occupation){
		Occupation = occupation;
		}
	public void SetCountrycode(string countrycode){
		CountryCode = countrycode;
		}
	public void SetAreacode(string areacode){
		AreaCode = areacode;
		}
	public void SetPhonenumber(string phonenumber){
		PhoneNumber = phonenumber;
		}
	}
	
class PhoneBook{
	List<Student> students = new List<Student>();
	
    
	public void store(){
		bool anotherentry = true;
		
		
		while(anotherentry){
			Console.Write("enter student number: ");
			string StudentNumber = Console.ReadLine();
			Console.Write("enter Surname: ");
			string Surname = Console.ReadLine();
			Console.Write("enter firstname: ");
			string FirstName = Console.ReadLine();
			Console.Write("enter Occupation: ");
			string Occupation = Console.ReadLine();
			Console.Write("enter Gender: ");
			char Gender = Convert.ToChar(Console.ReadLine());
			Console.Write("enter CountryCode: ");
			string CountryCode = Console.ReadLine();
			Console.Write("enter Areacode: ");
			string AreaCode = Console.ReadLine();
			Console.Write("enter phone number: ");
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
			int choice;
			bool editing = true;
			Student studentfound = null;
			Console.Write("enter stduent number: ");
			string studentnum = Console.ReadLine();
			
			foreach(Student student in students){
				if (studentnum == student.GetNumber()){
					Console.Write($"here is the existing information about {studentnum}:");
					student.Getdetails();
					studentfound = student;
					}
				else{
					Console.WriteLine("student not found");
					}
				}
				

				
				while(editing){
				Console.WriteLine("which of the following information do you wish to change?");
				Console.WriteLine("[1] studen number");
				Console.WriteLine("[2] surname");
				Console.WriteLine("[3] Gender");
				Console.WriteLine("[4] Occupation");
				Console.WriteLine("[5] Country code");
				Console.WriteLine("[6] area code");
				Console.WriteLine("[7] phone number");
				Console.WriteLine("[8] None - go back to main menu");
				
				Console.Write("Enter Number: ");
				choice = Convert.ToInt32(Console.ReadLine());
				
				switch(choice){
						case 1:
							Console.Write("Enter new student number: ");
							string StudentNumber = Console.ReadLine();
							studentfound.SetStudentnumber(StudentNumber);
							Console.WriteLine($"modified information student number: {studentfound.GetNumber()} ");
							break;
						case 2:
							Console.Write("Enter new Surname: ");
							string Surname = Console.ReadLine();
							studentfound.SetSurname(Surname);
							break;
						case 3:
							Console.Write("Enter new Gender: ");
							char Gender = Convert.ToChar(Console.ReadLine());
							studentfound.SetGender(Gender);
							break;
						case 4:
							Console.Write("Enter new Occupation: ");
							string Occupation = Console.ReadLine();
							studentfound.SetOccupation(Occupation);
							break;
						case 5:
							Console.Write("Enter new Country code: ");
							string CountryCode = Console.ReadLine();
							studentfound.SetCountrycode(CountryCode);
							Console.WriteLine($"modified information country code: {studentfound.GetCountrycode()} ");
							break;
						case 6:
							Console.Write("Enter new Area Code: ");
							string AreaCode = Console.ReadLine();
							studentfound.SetAreacode(AreaCode);
							break;
						case 7:
							Console.Write("Enter new Phone number: ");
							string PhoneNumber = Console.ReadLine();
							studentfound.SetPhonenumber(PhoneNumber);
							break;
						case 8:
						editing = false;
							break;
					}
				}
				
			}
	
	}
