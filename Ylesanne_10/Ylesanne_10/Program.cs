using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_10
{
class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Celsius/Fahrenheit + Error Check";

        START:
        Console.WriteLine("Tee oma valik:");
        Console.WriteLine();
        Console.WriteLine("1. Celsius -> Fahrenheit");
        Console.WriteLine("2. Fahrenheit -> Celsius");
        Console.WriteLine("3. Tajutav temperatuur (Celsius)");
        Console.WriteLine("4. Exit");
        Console.WriteLine();
        Console.Write("Valik: ");

        string result = Console.ReadLine();


        // Kui väär siis valik = 0
        int valik;

        bool check = int.TryParse(result, out valik);

        if (valik == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Palun sisestage täisnumber vahemikus 1-4, kõik muu on väär! Palun proovi uuesti!");
            Console.ReadKey();
            goto START;
        }

        // int PreValik = Convert.ToInt32(result);

        if (valik == 1)
        {

            Console.Write("Sisesta temperatuur (Celsius): ");

            double C;

            string resultC = Console.ReadLine();

            bool checkC = double.TryParse(resultC, out C);

            if (C == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }

            double cF = C * 9 / 5 + 32; // valem C -> F

            Console.WriteLine("Celsius -> Fahrenheit: " + cF);

            Console.ReadKey();

        }
        else if (valik == 2)
        {

            Console.Write("Sisesta temperatuur (Fahrenheit): ");

            double F;

            string resultF = Console.ReadLine();

            bool checkF = double.TryParse(resultF, out F);

            if (F == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }

            double fC = (F - 32) * 5 / 9; // valem F -> C

            Console.WriteLine("Fahrenheit -> Celsius: " + fC);

            Console.ReadKey();
        }
        else if (valik == 3)
        {

            Console.Write("Sisesta temperatuur (Celsius): ");

            //string temps = Console.ReadLine();
            //double T = Int32.Parse(temps);

            double T;

            string resultT = Console.ReadLine();

            bool checkT = double.TryParse(resultT, out T);

            if (T == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }


            Console.Write("Sisesta tuule kiirus: ");

            double Ws;

            string resultWs = Console.ReadLine();

            bool checkWs = double.TryParse(resultWs, out Ws);

            if (Ws == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }

            Console.Write("Sisesta õhuniiskus: ");

            double RH;

            string resultRH = Console.ReadLine();

            bool checkRH = double.TryParse(resultRH, out RH);

            if (RH == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }

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
            Console.WriteLine("");
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
}
