using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_13
{
class Program
{
    static void Main(string[] args)
    {

        //Muutujad

        int mituTehet;
        int mituTehetCounter = 0;
        int misVahemik;
        int oigeVastus;
        int wrongAnswerCounter = 0;
        int rightAnswerCounter = 0;


        Console.Title = "Programm arvutamise harjutamiseks";

        Console.WriteLine("Õpime arvutama!");
        Console.WriteLine();

        START1:

        Console.Write("Mitu tehet arvutada tahad?: ");

        string inputMitu = Console.ReadLine();

        bool BoolCheck = int.TryParse(inputMitu, out mituTehet);

        if (mituTehet == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Ainult numbrid! Palun proovi uuesti!");
            Console.ReadKey();

            goto START1;
        }

        START2:

        Console.Write("Mis vahemikus arvud genereerin (vahemik 1 - 50)?: ");

        string inputVahemik = Console.ReadLine();

        bool BoolCheck2 = int.TryParse(inputVahemik, out misVahemik);

        if (misVahemik == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Ainult numbrid vahemikus 1-50! Palun proovi uuesti!");
            Console.ReadKey();

            goto START2;
        }
        else if (misVahemik > 50)
        {

            Console.WriteLine();
            Console.WriteLine("Ainult numbrid vahemikus 1-50! Palun proovi uuesti!");
            Console.ReadKey();

            goto START2;

        }

        Console.WriteLine();
        Console.WriteLine("1.) Tahan ainult liitmistehteid (+)");
        Console.WriteLine("2.) Tahan ainult lahutamistehteid (-)");
        Console.WriteLine("3.) Tahan ainult korrutamistehteid (*)");
        Console.WriteLine("4.) Tahan ainult jagamistehteid (/) - EI SOOVITA KUNA JAGAMINE EI ANNA ENAMASTI TÄISARVE");
        Console.WriteLine("5.) Tahan teha kõiki tüüpe (+) (-) (*) (/)");
        Console.WriteLine();
        Console.Write("Sisesta oma valik: ");


        string valik = Console.ReadLine();

        Console.WriteLine("Hetkel teeme " + mituTehet + " tehet numbrivahemikus " + misVahemik);
        Console.WriteLine();


        // LIITMINE (+) START
        if (valik == "+" || valik == "1")
        {
            while (mituTehetCounter < mituTehet)
            {

                /*
                Random rnd = new Random();
                int month = rnd.Next(1, 13); // creates a number between 1 and 12
                int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
                int card = rnd.Next(52);     // creates a number between 0 and 51
                */

                Random rnd = new Random();
                int a = rnd.Next(misVahemik);
                int b = rnd.Next(misVahemik);

                oigeVastus = a + b;

                Console.Write(a + " + " + b + " = ");

                int vastus = Int32.Parse(Console.ReadLine());

                if (vastus == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;
            }



        } // LIITMINE END

        // LAHUTAMINE (-) START
        if (valik == "-" || valik == "2")
        {
            while (mituTehetCounter < mituTehet)
            {

                Random rnd = new Random();
                int a = rnd.Next(misVahemik);
                int b = rnd.Next(misVahemik);

                oigeVastus = a - b;

                Console.Write(a + " - " + b + " = ");

                int vastus = Int32.Parse(Console.ReadLine());

                if (vastus == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;
            }



        } // LAHUTAMINE END

        // KORRUTAMINE (*) START
        if (valik == "*" || valik == "3")
        {
            while (mituTehetCounter < mituTehet)
            {

                Random rnd = new Random();
                int a = rnd.Next(misVahemik);
                int b = rnd.Next(misVahemik);

                oigeVastus = a * b;

                Console.Write(a + " * " + b + " = ");

                int vastus = Int32.Parse(Console.ReadLine());

                if (vastus == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;
            }



        } // KORRUTAMINE END

        // JAGAMINE (/) START
        if (valik == "/" || valik == "4")
        {
            while (mituTehetCounter < mituTehet)
            {

                Random rnd = new Random();
                int a = rnd.Next(1, misVahemik);
                int b = rnd.Next(misVahemik);

                oigeVastus = a / b;

                Console.Write(a + " / " + b + " = ");

                int vastus = Int32.Parse(Console.ReadLine());

                if (vastus == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;
            }



        } // JAGAMINE END


        // KÕIK (+)(-)(*)(/) START

        ALL:

        if (valik == "5" && mituTehetCounter < mituTehet)
        {
            Random rnd = new Random();

            int randomTehe = rnd.Next(1, 4);

            // LIITMINE START
            if (randomTehe == 1)
            {

                Random rnd2 = new Random();
                int a2 = rnd2.Next(misVahemik);
                int b2 = rnd2.Next(misVahemik);

                oigeVastus = a2 + b2;

                Console.Write(a2 + " + " + b2 + " = ");

                int vastus2 = Int32.Parse(Console.ReadLine());

                if (vastus2 == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;



            } // LIITMINE END

            // LAHUTAMINE (-) START
            if (randomTehe == 2)
            {


                Random rnd2 = new Random();
                int a2 = rnd2.Next(misVahemik);
                int b2 = rnd2.Next(misVahemik);

                oigeVastus = a2 - b2;

                Console.Write(a2 + " - " + b2 + " = ");

                int vastus2 = Int32.Parse(Console.ReadLine());

                if (vastus2 == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;




            } // LAHUTAMINE END

            // KORRUTAMINE (*) START
            if (randomTehe == 3)
            {
                Random rnd2 = new Random();
                int a2 = rnd2.Next(misVahemik);
                int b2 = rnd2.Next(misVahemik);

                oigeVastus = a2 * b2;

                Console.Write(a2 + " * " + b2 + " = ");

                int vastus2 = Int32.Parse(Console.ReadLine());

                if (vastus2 == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;




            } // KORRUTAMINE END

            // JAGAMINE (/) START
            if (randomTehe == 4)
            {
                Random rnd2 = new Random();
                int a2 = rnd2.Next(1, misVahemik);
                int b2 = rnd2.Next(misVahemik);

                oigeVastus = a2 / b2;

                Console.Write(a2 + " / " + b2 + " = ");

                int vastus2 = Int32.Parse(Console.ReadLine());

                if (vastus2 == oigeVastus)
                {
                    Console.WriteLine("Tubli, õige vastus!");
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    rightAnswerCounter++;
                }
                else
                {

                    Console.WriteLine("Sinu vastus polnud õige. Õige vastus on " + oigeVastus);
                    Console.WriteLine("Vajuta suvalist klahvi, et jätkata...");
                    Console.WriteLine();
                    Console.ReadKey();
                    wrongAnswerCounter++;
                }



                mituTehetCounter++;




            } // JAGAMINE END
            goto ALL;
        }
        Console.WriteLine("See oli viimane ülesanne. Kogusid " + mituTehet + "-st punktist " + rightAnswerCounter + ".");
        Console.ReadKey();
    } // MAIN END

}
}