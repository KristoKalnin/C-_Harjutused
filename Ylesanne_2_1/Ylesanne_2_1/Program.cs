using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_2_1
{
class Program
{
    static void Main(string[] args)
    {
        int r = 3; // raadius
        int a = r + r; // kylje pikkus
        int Pruut = a * a; // ruudu pindala valem
        int Uruut = 4 * a; // ruudu ymberm66t
        double Pring = Math.PI * (r * r); // ringi pindala
        double Uring = 2 * Math.PI * r; // ringi ymberm66t

        Console.WriteLine("Ringi raadius on: " +r);
        Console.ReadKey();

        Console.WriteLine("Ruudu pindala: "+Pruut);
        Console.WriteLine("Ruudu ymberm66t: " +Uruut);
        Console.WriteLine("Ringi pindala: " +Pring);
        Console.WriteLine("Ringi ymberm66t: " +Uring);
        Console.ReadKey();
    }
}
}
