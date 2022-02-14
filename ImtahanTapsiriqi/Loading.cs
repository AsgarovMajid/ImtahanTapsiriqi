using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Loading
{
    public void loading()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\n\n\n\n\n\n   " +
            "\t\t\t\t\tL O A D I N G : ");
        for (int i = 1; i <= 11; i++)
        {
            Thread.Sleep(100);
            Console.Write($"{(char)1421}");
        }
        Console.Clear();
    }
}

