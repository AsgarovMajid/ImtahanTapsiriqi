using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;

public class Program
{
    private static int value;

    static void Main(string[] args)
    {
        string a;
        string b;
        string fg;
        string acceptornot;
        Console.ForegroundColor = ConsoleColor.DarkGray;

        Server server = new();
        WorkCv wc = new();

        Console.WriteLine("\t\t\t                         Welcome to Boss.az !");
        Thread.Sleep(1000);
        Console.WriteLine("\t\t\tPlease continue to make all your selections by using the item number on the left");
        Thread.Sleep(1000);
        Console.WriteLine("\t\t\t                  When you are finished type '5' to exit.\n");
        Thread.Sleep(2000);

    mbox:
        server.StartMenu();

        Worker wrr = new();
        
        server.addPostList = JSON.JsonDeSerializeWorkCV() as List<WorkCv>;

        List<Employer> employer = JSON.JsonDeSerializeEmployer() as List<Employer>;

        List<Worker> workers = JSON.JsonDeSerializeWorker() as List<Worker>;

        if (workers is null) workers = new();
        if (employer is null) employer = new();
        if (server.addPostList is null) server.addPostList = new();


        if (server.daxil == "1")
        {
            Console.WriteLine("\t\t\t\t             W O R K E R ");
            Console.WriteLine();
            Console.Write("\t\t\t\t|Email| : ");
            a = Console.ReadLine();
            Console.WriteLine("\t\t\t\t---------------------");
            Console.Write("\t\t\t\t|Password| : ");
            b = Console.ReadLine();
            Console.WriteLine("\t\t\t\t---------------------");


            for (int i = 0; i < server.WorkersList.Count; i++)
            {
                if (server.WorkersList[i].Email == a && server.WorkersList[i].Password == b)
                {
                armud:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\t\t\t\t{server.WorkersList[i].Name}`s Personal Page");
                    Thread.Sleep(2000);
                    Console.Clear();
                    server.AfterLoginWorker();
                    if (server.daxil == "1")
                    {

                        foreach (WorkCv re in server.addPostList)
                        {
                            Console.WriteLine(re);

                        }


                        Thread.Sleep(4000);
                        goto armud;
                    }
                    else if (server.daxil == "2")
                    {
                        server.AboutUs();
                        Thread.Sleep(2000);
                        goto armud;
                    }
                    else if (server.daxil == "3")
                    {
                        goto mbox;
                    }
                }
            }
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Email == a && workers[i].Password == b)
                {
                alma:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\t\t\t\t{workers[i].Name}`s Personal Page");
                    Thread.Sleep(3000);
                    Console.Clear();
                    server.AfterLoginWorker();
                    if (server.daxil == "1")
                    {
                        foreach (WorkCv re in server.addPostList)
                        {
                            Console.WriteLine(re);

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\tGO TO EMPLOYER TO APPLY JOB");
                        Thread.Sleep(4000);

                        goto alma;
                    }
                    else if (server.daxil == "2")
                    {
                        server.AboutUs();
                        goto alma;
                    }
                    else if (server.daxil == "3")
                    {
                        goto mbox;
                    }
                }

                else
                {


                }
            }

            Console.Clear();
            goto mbox;

        }

        else if (server.daxil == "2")
        {

            Console.WriteLine("Employer default olaraq Email:b@gmail.com");
            Console.WriteLine("Password:123");
            Console.WriteLine("\t\t\t\t           E M P L O Y E R");


            Console.WriteLine();
            Console.Write("\t\t\t\t|Email| : ");
            a = Console.ReadLine();
            Console.WriteLine("\t\t\t\t---------------------");
            Console.Write("\t\t\t\t|Password| : ");
            b = Console.ReadLine();

            if (employer.Count == 0)
            {
                employer.Add(new Employer(2, "a", "as", "ds", 2, 3, "asasa", "b@gmail.com", "123"));
            }
                
            for (int i = 0; i < employer.Count; i++)
            {
                if (employer[i].Email == a && employer[i].Password == b)
                {
                    server.AfterLoginEmp();

                    if (server.daxil == "1")
                    {
                        wc.InputAboutYourWork();
                        server.addPostList.Add(new WorkCv("NOT APPLIED TO JOB", wc.JobsName, wc.YourName, wc.AboutJob, wc.City, wc.Phone, wc.AgeForJob, wc.Salary, wc.Email));
                        JSON.JsonSerializeWorkCV(server.addPostList);
                    }
                    if (server.daxil == "2")
                    {
                        foreach (WorkCv re in server.addPostList)
                        {
                            Console.WriteLine(re);
                        }
                        Console.Clear();

                    }
                    if (server.daxil == "4")
                    {
                        foreach (WorkCv re in server.addPostList)
                        {
                            Console.WriteLine(re);
                        }

                        Console.WriteLine("Do you want to accept Someone if you want enter persons email ?:");

                        acceptornot = Console.ReadLine();
                        Console.Clear();
                        for (int mj = 0; mj < server.addPostList.Count; mj++)
                        {
                            if (acceptornot == server.addPostList[mj].Email && server.addPostList[mj].AppliedOrNot != "NOT APPLIED TO JOB")
                            {
                                Console.Clear();
                                Console.WriteLine(server.addPostList[mj].Email, "Applied");
                                Thread.Sleep(2000);
                                server.addPostList[mj].AppliedOrNot = "APPLIED TO JOB";
                                JSON.JsonSerializeWorkCV(server.addPostList);
                            }
                            else if (acceptornot == server.addPostList[mj].Email)
                            {
                                Console.WriteLine("This person already have job");
                                Thread.Sleep(3000);
                            }
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("\t\t\t\t\tParol ve ya email sefdir");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                goto mbox;

            }
        }

        else if (server.daxil == "3")
        {


            wrr.RegisterWorker();

            workers.Add(new Worker(wrr.Email, wrr.Password, wrr.Name, wrr.Surname, wrr.City, wrr.PhoneNumber, wrr.Age, wrr.Specialty, wrr.School, wrr.Skills, wrr.Companies, wrr.WorkStartEnd, wrr.Language, wrr.Diploma));
            JSON.JsonSerializeWorker(workers);
            foreach (Worker re in workers)
            {
                Console.WriteLine(re);
                Console.WriteLine(server.WorkersList.Count);

            }

            Thread.Sleep(2000);
            goto mbox;


        }

        else if (server.daxil == "4")
        {
            server.AboutUs();
            Thread.Sleep(3000);
            Console.Clear();
            goto mbox;

        }

        else if (server.daxil == "5")
        {
            Environment.Exit(0);
        }

        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\t\t\t\t\tSef reqem daxil etdiniz!\n\n" +
                "\t\t\t\t\t   Netice Tapilmadi!");
            Thread.Sleep(4000);
            Console.Clear();
            goto mbox;

        }

    }
}
