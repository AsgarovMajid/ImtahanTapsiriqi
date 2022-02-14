using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Threading;
using System.Text.RegularExpressions;

public class Worker
{



    public Worker[] workerss;

    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Age { get; set; }
    public string Specialty { get; set; }
    public string School { get; set; }
    public string Skills { get; set; }
    public string Companies { get; set; }
    public string WorkStartEnd { get; set; }
    public string Language { get; set; }
    public string Diploma { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Worker()
    {

    }

    public Worker(string email, string password, string name, string surname, string city, string phoneNumber, string age, string specialty, string school,  string skills, string companies, string workStartEnd, string language, string diploma)
    {
        Email = email;
        Password = password;
        Name = name;
        Surname = surname;
        City = city;
        PhoneNumber = phoneNumber;
        Age = age;
        Specialty = specialty;
        School = school;
        Skills = skills;
        Companies = companies;
        WorkStartEnd = workStartEnd;
        Language = language;
        Diploma = diploma;

    }



    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------Worker----------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Specialty: {Specialty}");
        Console.WriteLine($"School: {School}");
        Console.WriteLine($"Skills: {Skills}");
        Console.WriteLine($"Companies: {Companies}");
        Console.WriteLine($"Work Started Ended: {WorkStartEnd}");
        Console.WriteLine($"Language: {Language}");
        Console.WriteLine($"Diploma: {Diploma}");
        Console.WriteLine("--------------------------------------------------");
        return Name;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------Worker----------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Specialty: {Specialty}");
        Console.WriteLine($"School: {School}");
        Console.WriteLine($"Skills: {Skills}");
        Console.WriteLine($"Companies: {Companies}");
        Console.WriteLine($"Work Started Ended: {WorkStartEnd}");
        Console.WriteLine($"Language: {Language}");
        Console.WriteLine($"Diploma: {Diploma}");
        Console.WriteLine("--------------------------------------------------");
    }

    public void RegisterWorker()
    {
    flag:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\tRegister Page\n");
        Console.Write("Enter your email: ");
        Email = Console.ReadLine();
        string pattern = "[@]";
        var regex = new Regex(pattern);
        var match = regex.Match(Email);
        if (match.Success)
        {
            Console.Write("Enter your password: ");
            Password = Console.ReadLine();
            Console.Write("Enter your Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter your Surname: ");
            Surname = Console.ReadLine();
            Console.Write("Enter your City: ");
            City = Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            PhoneNumber = Console.ReadLine();
        aaa:
            Console.Write("Enter your Age: ");
            Age = Console.ReadLine();
            if (Age == "1" || Age == "2" || Age == "3" || Age == "4" || Age == "5" || Age == "6" || Age == "7" || Age == "8" || Age == "9" || Age == "10" || Age == "11" || Age == "12" || Age == "13" || Age == "14" || Age == "15" || Age == "16" || Age == "17")
            {
                Console.WriteLine("You cannot apply to job ");
                Console.Clear();
                goto aaa;
            }
            else
            {
                Console.Write("Enter your Specialty: ");
                Specialty = Console.ReadLine();
                Console.Write("Enter your School: ");
                School = Console.ReadLine();
                Console.Write("Enter your Skills: ");
                Skills = Console.ReadLine();
                Console.Write("Enter your Companies: ");
                Companies = Console.ReadLine();
                Console.Write("Enter your work started and end: ");
                WorkStartEnd = Console.ReadLine();
                Console.Write("Which language do you know?: ");
                Language = Console.ReadLine();
                Console.Write("You have Diploma?: ");
                Diploma = Console.ReadLine();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tRegister Page\n");

            Console.WriteLine("You need to use @ !");

            Thread.Sleep(3000);
            Console.Clear();
            goto flag;

        }


        //lstemail.Add(new Worker(Email, Password, Id, Name, Surname, City, PhoneNumber, Age, Specialty, School, UniJoinScore, Skills, Companies, WorkStartEnd, Language, Diploma));
        //var myIntList = new List<Worker> { };
        //Thread.Sleep(1000);

        //loading
        Loading loading = new Loading();
        loading.loading();
    }


}

