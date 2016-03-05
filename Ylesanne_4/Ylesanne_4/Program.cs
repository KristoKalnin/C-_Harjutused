using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_4
{
class Program
{
    static void Main(string[] args)
    {


        string a, ax, b, c, cx, d, e, f, g, laul;

        a = "Rong see sõitis ";
        ax = "tsuhh tsuhh tsuhh"; //vajadusel muuda

        b = "piilupart oli rongijuht";

        c = "Rattad tegid ";
        cx = "rat tat taa"; //vajadusel muuda

        d = "rat tat taa ja tat tat taa"; //vajadusel muuda

        e = "Aga seal rongi peal";
        f = "kas sa tead, kes olid seal";

        laul = a+ax+", "+ b+". "+ c+cx+", " + d+". " + e+", " + f+"?";

        Console.WriteLine(laul);
        Console.ReadKey();


    }
}
}
