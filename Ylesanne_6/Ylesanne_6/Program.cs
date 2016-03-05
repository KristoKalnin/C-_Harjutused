using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_6
{
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Kes sa oled?"; // aknale oma nimi
        Console.Write("Kuidas on teie nimi: "); // kysime kasutaja nime
        string knimi = Console.ReadLine(); // loen klaviatuuri v22rtust sisse
        Console.WriteLine("Tere " + knimi); // v2ljastan saadud stringi ekraanile
        Console.WriteLine("Kui vana sa oled?"); // kysime kasutaja nime
        string kvanus = Console.ReadLine(); //loen klaviatuuri v22rtust sisse
        Console.WriteLine("Thx " + knimi); // v2ljastan saadud stringi ekraanile

        try
        {
            int number = Int32.Parse(kvanus); // string -> int

            if (number < 6)
            {
                Console.WriteLine(knimi + ", oled alaealine"); //v2ljastan saadud stringi ekraanile
            }
            else if (number >= 7 && number <= 18)
            {
                Console.WriteLine(knimi + ", oled koolis"); //v2ljastan saadud stringi ekraanile
            }
            else if (number >= 19 && number <= 129)
            {
                Console.WriteLine(knimi + ", rassi edasi"); //v2ljastan saadud stringi ekraanile
            }
            else if (number > 130)
            {
                Console.WriteLine(knimi + ", peaksid olema surnud..."); //v2ljastan saadud stringi ekraanile
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("See ei ole number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR");
        }

        Console.ReadKey();
    }
}
}
