using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_17
{
class Program
{
    static void Main(string[] args)
    {

        // MUUTUJAD
        double Distants = 0;
        double DistantsKM = 0;

        string distantsYhik = "";
        double OrigDistants = 0;
        double OrigSpeed = 0;
        double tUnitsSeconds = 0;

        double uusKiirus = 0;


        Console.Title = "Kiiruse & Vahemaa Kalkulaator - 1 tund STEP";

        Console.WriteLine("PROGRAMM TÖÖTAB AGA LAHENDUSLOOGIKA POLE KÕIGE PAREMINI SÕNASTATUD, ALGORITMI SAAB TÄIUSTADA LOOGILISEMAKS!!!");
        Console.WriteLine();

        inputSpeed:

        Console.Write("Palun sisesta kiirus (km/h): ");

        double SpeedKMH, Speed;
        string speedInput = Console.ReadLine();

        bool BoolCheckSpeed = double.TryParse(speedInput, out SpeedKMH);

        OrigSpeed = SpeedKMH;

        if(SpeedKMH == 0)
        {
            Console.WriteLine("Ainult numbrid! Proovi uuesti.");
            goto inputSpeed;
        }

        Speed = (SpeedKMH * 1000) / 3600; // km/h -> meetrit sekundis (m/s)

        Console.WriteLine();

        Console.WriteLine("Mis ühikus soovid sisestada vahemaa?");
        Console.WriteLine("1.) Kilomeetrid (km)");
        Console.WriteLine("2.) Meetrid (m)");
        Console.WriteLine();
        Console.Write("Valik: ");

        string Valik = Console.ReadLine();

        if(Valik == "1" || Valik == "Kilomeetrid" || Valik == "kilomeetrid" || Valik == "km" || Valik == "KM" || Valik == "kilomeeter" || Valik == "Kilomeeter")
        {



            inputKM:

            Console.Write("Palun sisesta vahemaa (km): ");
            string Input = Console.ReadLine();

            bool BoolCheck = double.TryParse(Input, out DistantsKM);

            if(DistantsKM == 0)
            {
                Console.WriteLine("Ainult numbrid! Proovi uuesti.");
                goto inputKM;
            }

            OrigDistants = DistantsKM;
            distantsYhik = " km";

            Distants = DistantsKM * 1000; // KM -> M

        }
        else if (Valik == "2" || Valik == "Meetrid" || Valik == "meetrid" || Valik == "m" || Valik == "M" || Valik == "meeter" || Valik == "Meeter")
        {

            inputM:

            Console.Write("Palun sisesta vahemaa (m): ");
            string Input = Console.ReadLine();

            bool BoolCheck = double.TryParse(Input, out Distants);



            if (Distants == 0)
            {
                Console.WriteLine("Ainult numbrid! Proovi uuesti.");
                goto inputM;
            }
            OrigDistants = Distants;
            distantsYhik = " m";

        }

        Console.WriteLine();

        int Kaunter = 0;
        int KaunterFirstRun = 1; // 1 ehk true

        while (Distants >= 0)
        {

            /*
            FORMULA

            SPEED:      r = d / t
            DISTANCE:   d = r * t
            TIME:       t = d / r
            */


            // Kui kaua on VEEL vaja liikuda, formula TIME

            double TimeLeftS = Distants / Speed;
            double TimeLeftM = (Distants / Speed) / 60;
            double TimeLeftT = ((Distants / Speed) / 60) / 60;

            double travelDistance = Speed * 3600; // Arvutab palju aja jooksul liigud, formula TIME

            if (KaunterFirstRun == 1)
            {


                Console.WriteLine("//////////////////////////////////////////////");
                Console.WriteLine("Esialgne sisestatud: ");
                Console.WriteLine("     Distants: " + OrigDistants + distantsYhik);
                Console.WriteLine("     Kiirus: " + OrigSpeed + " km/h");
                Console.WriteLine();

                Distants = Distants - travelDistance;

                Console.WriteLine("Algne travel data (Etapp 0) =>");
                Console.WriteLine("     ajaliselt: " + TimeLeftS + " sekundit (s) / " + TimeLeftM + " minutit (min) / " + TimeLeftT + " tundi (t)");
                Console.WriteLine();
                Console.WriteLine("     uus distants peale 1-te tundi: " + Distants + " m");

                Console.WriteLine();
                Console.WriteLine("//////////////////////////////////////////////");
                Console.WriteLine();

            }

            if (KaunterFirstRun <= 0)
            {

                Console.WriteLine("//////////////////////////////////////////////");
                Console.WriteLine();
                Console.WriteLine("Etapp " + Kaunter + " / Kiirus millega arvutati: " + SpeedKMH +" km/h");
                Console.WriteLine();

                Distants = Distants - travelDistance;

                Console.WriteLine("Andmed (1 tunni edasiliikumise järel):");
                Console.WriteLine("     ajaliselt: " + TimeLeftS + " sekundit (s) / " + TimeLeftM + " minutit (min) / " + TimeLeftT + " tundi (t)" );
                Console.WriteLine();
                Console.WriteLine("     uus distants peale 1-te tundi: " + Distants + " m");
                Console.WriteLine();

                Console.ReadKey();

            }

            KaunterFirstRun = KaunterFirstRun - 1;

            inputSpeedWhileLoop:
            Console.Write("Palun sisesta uus kiirus (km/h): ");

            speedInput = Console.ReadLine();

            BoolCheckSpeed = double.TryParse(speedInput, out SpeedKMH);

            if (SpeedKMH == 0)
            {
                Console.WriteLine("Ainult numbrid! Proovi uuesti.");
                goto inputSpeedWhileLoop;
            }

            Speed = (SpeedKMH * 1000) / 3600; // km/h -> meetrit sekundis (m/s)

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Kaunter++;

        }

        Console.WriteLine("Programm saigi läbi! Press anykey");
        Console.ReadKey();




    } // Main END
}
}