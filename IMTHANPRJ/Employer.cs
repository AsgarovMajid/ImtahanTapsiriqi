using System;

public class Employer
{
    int Id { get; set; }
    string Name { get; set; }
    string SurName { get; set; }
    string City { get; set; }
    int Phone { get; set; }
    int Age { get; set; }
    string Vacancies { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


    public Employer(int id, string name, string surName, string city, int phone, int age, string vacancies, string email, string password)
    {
        Id = id;
        Name = name;
        SurName = surName;
        City = city;
        Phone = phone;
        Age = age;
        Vacancies = vacancies;
        Email = email;
        Password = password;
    }

    public void ShowEmployer()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" ----------- Employer -----------");
        Console.WriteLine($" Id : {Id}");
        Console.WriteLine($" Name : {Name}");
        Console.WriteLine($" Surname : {SurName}");
        Console.WriteLine($" City : {City}");
        Console.WriteLine($" Phone : {Phone}");
        Console.WriteLine($" Age : {Age}");
        Console.WriteLine($" Vacancies : {Vacancies}");
        Console.WriteLine($" Email : {Email}");
        Console.WriteLine($" Password : {Password}");
        Console.WriteLine(" --------------------------------");

    }

    public void SingInEmployer()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\tLogin Page\n");
        Console.Write("\t\t\t\tEnter your email: ");
        Email = Console.ReadLine();
        Console.Write("\t\t\t\tEnter your password: ");
        Password = Console.ReadLine();

        //loading
        Loading loading = new Loading();
        loading.loading();
    }

}