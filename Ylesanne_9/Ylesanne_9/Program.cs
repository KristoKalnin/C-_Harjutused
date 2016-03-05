using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_9
{
class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Celsius/Fahrenheit";

        Console.WriteLine("Tee oma valik:");
        Console.WriteLine();
        Console.WriteLine("1. Celsius -> Fahrenheit");
        Console.WriteLine("2. Fahrenheit -> Celsius");
        Console.WriteLine("3. Tajutav temperatuur (Celsius)");
        Console.WriteLine("4. Exit");
        Console.WriteLine();

        string result = Console.ReadLine();
        int valik = Convert.ToInt32(result);

        if (valik == 1)
        {

            Console.WriteLine("Sisesta temperatuur (Celsius)");
            Console.WriteLine();
            double C = Convert.ToInt64(Console.ReadLine());

            double cF = C * 9 / 5 + 32; // valem C -> F

            Console.WriteLine("Celsius -> Fahrenheit: " + cF);

            Console.ReadKey();

        }
        else if (valik == 2)
        {

            Console.WriteLine("Sisesta temperatuur (Fahrenheit)");
            Console.WriteLine();
            double F = Convert.ToInt64(Console.ReadLine());

            double fC = (F - 32) * 5 / 9; // valem F -> C

            Console.WriteLine("Fahrenheit -> Celsius: " + fC);

            Console.ReadKey();
        }
        else if (valik == 3)
        {

            Console.WriteLine("Sisesta temperatuur (Celsius)");
            string temps = Console.ReadLine();
            double T = Int32.Parse(temps);
            Console.Write("Sisesta tuule kiirus: ");
            string WsS = Console.ReadLine();
            double Ws = Int32.Parse(WsS);
            Console.Write("Sisesta õhuniiskus: ");
            string RHS = Console.ReadLine();
            double RH = Int32.Parse(RHS);
            /*
            Tajutav temp = T+(0.33*(RH/100*6.105*exp(17.27*T/(237.7+T))))-(0.70*Ws)-4
            T – hetketemperatuur °C 2m kõrgusel
            V/Ws – keskmine tuule kiirus m/s 10m kõrgusel
            RH – õhuniiskus %
             */
            double tuul = T + (0.33 * (((RH / 100 * 6.105 * Math.Exp(17.27 * T / (237.7 + T)))) - (0.7 * Ws))) - 4;
            double tuul2 = T + (0.33 * (RH / 100 * 6.105 * Math.Exp(17.27 * T / (237.7 + T)))) - (0.70 * Ws) - 4;
            Console.WriteLine("Seega tajutav temperatuur on: " + tuul);
            Console.WriteLine("Vana arvutus tuleb seega: " + tuul2);

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
}
