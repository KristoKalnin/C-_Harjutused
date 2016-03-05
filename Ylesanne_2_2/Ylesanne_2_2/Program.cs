using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_2_2
{
class Program
{
    static void Main(string[] args)
    {


        double Uring = 2 * Math.PI * 6378; //Maa ümbermõõt

        double mynt = 25.75 / 1000000; // mm -> km

        double vaja = Uring / mynt;

        Console.WriteLine("Mynte l2heb: " +vaja);
        Console.ReadKey();


    }
}
}
