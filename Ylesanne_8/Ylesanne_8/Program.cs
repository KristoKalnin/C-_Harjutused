using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_8
{
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Matemaatiline Koer";

        Console.Write("Esimene arv: ");
        string arvyks = Console.ReadLine();
        int arv1 = Int32.Parse(arvyks);

        Console.Write("Teine arv ");
        string arvkaks = Console.ReadLine();
        int arv2 = Int32.Parse(arvkaks);


        Console.Write("Tehetemärk: ");
        string mark = Console.ReadLine();



        if (mark == "+")
        {
            int sum = arv1 + arv2;

            int i = 0;

            while (i < sum)
            {
                Console.Write(" auh");
                i++;
            }
        }

        if (mark == "-")
        {
            int sum = arv1 - arv2;

            int i = 0;

            while (i < sum)
            {
                Console.Write(" auh");
                i++;
            }
        }

        if (mark == "*")
        {
            int sum = arv1 * arv2;

            int i = 0;

            while (i < sum)
            {
                Console.Write(" auh");
                i++;
            }
        }

        if (mark == "/")
        {
            int sum = arv1 / arv2;

            int i = 0;

            while (i < sum)
            {
                Console.Write(" auh");
                i++;
            }
        }

        Console.ReadKey();
    }
}
}
