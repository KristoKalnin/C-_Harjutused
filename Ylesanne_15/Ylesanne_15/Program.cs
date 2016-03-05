using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_15
{
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Korrutustabeli Generaator";

        Console.Write("Sisesta esimene arv korrutustabeli jaoks: ");
        int userValue_number = int.Parse(Console.ReadLine());

        Console.Write("Sisesta teine arv korrutustabeli jaoks: ", userValue_number);
        int userValue_length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int n = userValue_number;
        int i = 1;
        while (n <= (userValue_number * userValue_length))
        {
            Console.WriteLine("{0} x {1} = {2}", i, userValue_number, n);
            n = n + userValue_number;
            i++;
        }
        Console.ReadLine();
    }
}
}