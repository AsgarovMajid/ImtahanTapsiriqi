using System;
using System.Threading;

public class WorkCv
{
    public string AppliedOrNot { get; set; }
    public string JobsName { get; set; }
    public string YourName { get; set; }
    public string AboutJob { get; set; }
    public string AgeForJob { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string Salary { get; set; }
    public string Phone { get; set; }




    public WorkCv()
    {
        AppliedOrNot = "Not applied to job";
    }

    public WorkCv(string app, string jobsName, string yourName, string aboutJob, string city, string phone, string ageForJob, string salary, string email)
    {
        AppliedOrNot = app;
        JobsName = jobsName;
        YourName = yourName;
        AboutJob = aboutJob;
        City = city;
        Phone = phone;
        AgeForJob = ageForJob;
        Salary = salary;
        Email = email;
    }
    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"              {AppliedOrNot}       ");
        Console.WriteLine($"              {JobsName}           ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Who added this post : {YourName}");
        Console.WriteLine($"About This Job : {AboutJob}");
        Console.WriteLine($"Age : {AgeForJob}+");
        Console.WriteLine($"Salary : {Salary}$ ");
        Console.WriteLine($"Our Email : {Email}");

        Thread.Sleep(2000);
        return JobsName;
    }
    public void InputAboutYourWork()
    {

        Console.WriteLine("----------------- ADD POST -----------------");
        Console.WriteLine("No#________________________________________#");
        Console.WriteLine();
        Console.Write("[1] Enter your Jobs Name: ");
        JobsName = Console.ReadLine();
        Console.Write("[2] Enter your Name: ");
        YourName = Console.ReadLine();
        Console.Write("[3] Enter About Job: ");
        AboutJob = Console.ReadLine();
        Console.Write("[4] Enter City: ");
        City = Console.ReadLine();
        Console.Write("[5] Enter your Phone number: ");
        Phone = Console.ReadLine();
    aaaa:
        Console.Write("[6] Enter Age: ");
        AgeForJob = Console.ReadLine();
        if (AgeForJob == "1" || AgeForJob == "2" || AgeForJob == "3" || AgeForJob == "4" || AgeForJob == "5" || AgeForJob == "6" || AgeForJob == "7" || AgeForJob == "8" || AgeForJob == "9" || AgeForJob == "10" || AgeForJob == "11" || AgeForJob == "12" || AgeForJob == "13" || AgeForJob == "14" || AgeForJob == "15" || AgeForJob == "16" || AgeForJob == "17")
        {
            goto aaaa;
        }
        else
        {
            Console.Write("[7] Enter Salary: ");
            Salary = Console.ReadLine();
            Console.Write("[8] Enter your email: ");
            Email = Console.ReadLine();
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"              {JobsName}           ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Who added this post : {YourName}");
        Console.WriteLine($"About This Job : \n{AboutJob}");
        Console.WriteLine($"Age : {AgeForJob}+");
        Console.WriteLine($"Salary : {Salary}$ ");
        Console.WriteLine($"Our Email : {Email}");

        Console.Clear();
    }
    public void ShowJobs()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"              {JobsName}           ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Who added this post : {YourName}");
        Console.WriteLine($"About This Job : {AboutJob}");
        Console.WriteLine($"Age : {AgeForJob}+");
        Console.WriteLine($"Salary : {Salary}$ ");
        Console.WriteLine($"Our Email : {Email}");

        Thread.Sleep(2000);
    }

}