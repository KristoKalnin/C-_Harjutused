using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_12
{
class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Massiiv 10 liitmine";

        //Muutujad START

        int i = 0;
        int mitmesArv = 1;
        double InputCheck;
        double sum = 0;
        // END

        double[] numbrid = new double[10]; // Tekita massiiv kuhu saab sisestada 10 elementi

        for (int runs = 0; runs < 10; runs++)
        {

            START:

            Console.Write("Palun sisesta arv number " + mitmesArv + ": ");

            string input = Console.ReadLine();
            bool BoolCheck = double.TryParse(input, out InputCheck);

            if (InputCheck == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
                Console.ReadKey();
                goto START;
            }


            numbrid[i] = InputCheck;

            mitmesArv++;
            i++;


        }

        // TESTIMISEKS
        /*
        Console.WriteLine(numbrid[0]);
        Console.WriteLine(numbrid[1]);
        Console.WriteLine(numbrid[2]);
        Console.WriteLine(numbrid[3]);
        Console.WriteLine(numbrid[4]);
        Console.WriteLine(numbrid[5]);
        Console.WriteLine(numbrid[6]);
        Console.WriteLine(numbrid[7]);
        Console.WriteLine(numbrid[8]);
        Console.WriteLine(numbrid[9]);
        Console.ReadKey();
        */

        Console.WriteLine();
        Console.WriteLine("Muutujate summa kokku on: " + numbrid.Sum());
        Console.ReadKey();
    }
}
}