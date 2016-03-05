using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_2
{
class Program
{
    static void Main(string[] args)
    {
        /* LIHTSALT INFOKS
        public const int MaxValue = 2147483647;
        public const int MinValue = -2147483648;
        */

        algus: //lipp
        int a = 3 + 8 / (4 - 2) * 4;

        Console.WriteLine("Kui palju on: 3 + 8 / (4 - 2) * 4");
        Console.ReadKey();

        Console.WriteLine("Ja vastus on: " + a);
        Console.ReadKey();
        goto algus; // Korda alates lipust "algus"

    }
}
}
