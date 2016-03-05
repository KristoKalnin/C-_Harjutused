using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_11
{
class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Ole tervitatud ... !";

        Console.Write("Palun sisesta oma nimi: ");


        string nimi = Console.ReadLine();
        Console.WriteLine();

        int i = 1;

        while (i <= 5)
        {
            Console.WriteLine("Ole tervitatud, " + nimi + ", " + i + ". korda.");
            i++;
        }
        Console.ReadKey();

    }
}
}
