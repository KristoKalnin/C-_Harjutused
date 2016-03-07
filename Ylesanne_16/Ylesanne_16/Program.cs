using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_16
{
class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        string rida = "";
        kysimus:
        Console.Write("Sisesta number: ");
        string nS = Console.ReadLine();
        try
        {
            n = Int32.Parse(nS);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ei saanud aru!");
            goto kysimus;
        }
        for (int i = 1; i < n + 1; i++)
        {
            for (int k = 1; k < n + 1; k++)
            {
                if (i == k || n - i + 1 == k)
                {
                    rida = rida + "X ";
                }
                else
                {
                    rida = rida + "O ";
                }

                if (k == n)
                {
                    Console.WriteLine(rida);
                    rida = "";
                }
            }
        }
        Console.ReadKey();
    }
}
}


