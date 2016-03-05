using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_5
{
class Program
{
    static void Main(string[] args)
    {


        Console.Title = "Ristkülik"; // aknale oma nimi
        Console.Write("Sisestage ristküliku pikkus: ");
        double rPikkus = Convert.ToInt64(Console.ReadLine()); // loen klaviatuuri v22rtust sisse
        Console.Write("Sisestage ristküliku laius: ");
        double rLaius = Convert.ToInt64(Console.ReadLine()); // loen klaviatuuri v22rtust sisse

        double P, U;

        P = rPikkus * rLaius; // pindala valem
        U = 2 * (rPikkus + rLaius);// ümbermõõdu valem

        Console.WriteLine();
        Console.WriteLine("Ristküliku pindala on: "+P);
        Console.WriteLine("Ristküliku ümbermõõt on: "+U);
        Console.WriteLine();
        Console.WriteLine("Vajuta suvalist klahvi programmi sulgemiseks");
        Console.ReadKey();
    }
}
}
