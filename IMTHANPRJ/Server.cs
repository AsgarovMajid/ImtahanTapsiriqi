using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class Server
{
    public string daxil;

    public List<Worker> WorkersList = new List<Worker>();

    public List<WorkCv> addPostList = new List<WorkCv>();

    public void AboutUs()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                         Haqqımızda                                         ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Layihə haqqında:                                                                             ");
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine();
        Console.WriteLine("Boss.Az - əmək bazarının bütün iştirakçılarının faydalana biləcəyi, dəqiq və sürətli iş və ya");
        Console.WriteLine("işçi axtarışı üçün nəzərdə tutulmuş onlayn platformadır. Layihə istifadəçilərə geniş iş elanı və");
        Console.WriteLine("CV bazasından rahat istifadə imkanı yaradır.");
        Console.WriteLine();
        Console.WriteLine("Layihə fəaliyyətinə 2008-ci ildə başlayıb və hal-hazırda Azərbaycanın əmək bazarında");
        Console.WriteLine("aparıcı onlayn resuslarından biridir.");
        Console.WriteLine();
        Console.WriteLine("Boss.Az - işədüzəltmə şirkəti deyil. Layihənin məqsədi işə götürən ilə potensial işçi arasında");
        Console.WriteLine("vasitəçisiz və operativ əlaqə imkanı yaratmaqdır.");

    }
    public void StartMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;


        Console.WriteLine("\t\t\t\t--------------------- Boss.az ----------------------");
        Console.WriteLine("\t\t\t\tNo# ------------------------------------------------#");
        Console.WriteLine("\t\t\t\t[1] Login With Worker.............................[1]");
        Console.WriteLine("\t\t\t\t[2] Login with Employer...........................[2]");
        Console.WriteLine("\t\t\t\t[3] Register......................................[3]");
        Console.WriteLine("\t\t\t\t[4] About us......................................[4]");
        Console.WriteLine("\t\t\t\t[5] Exit..........................................[5]");
        Console.WriteLine("\t\t\t\t#___________________________________________________#");
        Console.Write("\t\t\t\t             Choose number[1,2,3,4]:");
        Console.ForegroundColor = ConsoleColor.White;

        daxil = Console.ReadLine();
        Console.Clear();
        //loading
        Loading loading = new();
        loading.loading();
    }
    public void AfterLoginEmp()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.WriteLine("\t\t\t\t..............Employer.............");
        Console.WriteLine("\t\t\t\tNo# -------------------------------#");
        Console.WriteLine("\t\t\t\t[1] Add Post");
        Console.WriteLine("\t\t\t\t[2] Show Posts");
        Console.WriteLine("\t\t\t\t[3] Log out");
        Console.WriteLine("\t\t\t\t[4] Accept for work");
        Console.WriteLine("\t\t\t\t#__________________________________#");
        Console.Write("\t\t\t\t            Choose[1,2,3,4]:");
        Console.ForegroundColor = ConsoleColor.White;

        daxil = Console.ReadLine();

        Console.Clear();
        //loading
        Loading loading = new();
        loading.loading();
    }
    public void AfterLoginWorker()
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("\t\t\t\t................Worker..............\n");
        Console.WriteLine("\t\t\t\tNo# -------------------------------#");
        Console.WriteLine("\t\t\t\t[1] Show works");
        Console.WriteLine("\t\t\t\t[2] About Us ");
        Console.WriteLine("\t\t\t\t[3] Log out");
        Console.WriteLine("\t\t\t\t#__________________________________#");
        Console.Write("\t\t\t\t           Choose[1,2,3]:");
        Console.ForegroundColor = ConsoleColor.White;

        daxil = Console.ReadLine();
        Console.Clear();
        //loading
        Loading loading = new();
        loading.loading();
    }


}
