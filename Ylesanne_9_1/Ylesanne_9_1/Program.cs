using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_9_1
{
class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Isikukoodi analüüsija ver 1.0 / Autor: Kristo Kalnin";

        IDkontroll:

        Console.Write("Sisesta isikukood: ");
        string isikukood = Console.ReadLine();
        Console.WriteLine();

        char[] ArrayID = isikukood.ToCharArray();
        int[] IntArrayDouble = Array.ConvertAll(ArrayID, c => (int)Char.GetNumericValue(c)); // http://stackoverflow.com/questions/21587186/convert-char-array-to-int-array-c-sharp

        // Kontrollnumbri kordajad
        int[] kordajad1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
        int[] kordajad2 = new int[10] { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };
        double[] arrayMultiply = new double[10];

        // Sünniaasta
        string birthYear = "" + ArrayID[1] + ArrayID[2];
        int birthyearNum = Int32.Parse(birthYear);

        // Console.WriteLine("Birthyearnumtest" + birthyearNum);

        for (int i = 0; i <= 9; i++)
        {
            arrayMultiply[i] = IntArrayDouble[i] * kordajad1[i];

        }
        double arrayMultiplySum = arrayMultiply.Sum();

        /*
        Console.WriteLine("SUM ENNE 2 kordaja: " + arrayMultiplySum);
        Console.ReadKey();
        */

        double leftNum = Math.Floor(arrayMultiplySum / 11);
        double leftNumX11 = leftNum * 11;
        leftNum = arrayMultiplySum - leftNumX11;


        // Console.WriteLine("Kontroll: " + leftNum);

        /*
        Console.WriteLine("leftNum: " + leftNum);
        Console.ReadKey();
        */

        double checkNumber = leftNum;

        if(leftNum >= 10)
        {
            for (int i = 0; i <= 9; i++)
            {
                arrayMultiply[i] = IntArrayDouble[i] * kordajad2[i];
            }
            arrayMultiplySum = arrayMultiply.Sum();

            /*
            Console.WriteLine("Kontroll2 SUM: " + arrayMultiplySum);
            Console.ReadKey();
            */

            leftNum = Math.Floor(arrayMultiplySum / 11);
            leftNumX11 = leftNum * 11;
            leftNum = arrayMultiplySum - leftNumX11;

            if (leftNum == 10)
            {
                checkNumber = 0;
            }
            else
            {
                checkNumber = leftNum;
            }
        }

        /*
        Console.WriteLine("Kontrollnumber: " + checkNumber);
        */
        if (IntArrayDouble[10] != checkNumber)
        {
            Console.WriteLine("Isikukoodi kontrollsumma ei klapi. Proovi uuesti!");

            goto IDkontroll;
        }


        Console.WriteLine("Leitud andmed: ");
        Console.WriteLine();

        if (IntArrayDouble[0] == 1)
        {
            Console.WriteLine("     Sugu: Mees");
        }
        else if(IntArrayDouble[0] == 2)
        {
            Console.WriteLine("     Sugu: Naine");
        }
        else if (IntArrayDouble[0] == 3)
        {
            Console.WriteLine("     Sugu: Mees");
        }
        else if (IntArrayDouble[0] == 4)
        {
            Console.WriteLine("     Sugu: Naine");
        }
        else if (IntArrayDouble[0] == 5)
        {
            Console.WriteLine("     Sugu: Mees");
        }
        else if (IntArrayDouble[0] == 6)
        {
            Console.WriteLine("     Sugu: Naine");
        }
        else if (IntArrayDouble[0] == 7)
        {
            Console.WriteLine("     Sugu: Mees");
        }
        else if (IntArrayDouble[0] == 8)
        {
            Console.WriteLine("     Sugu: Naine");
        }

        Console.WriteLine("     Sünniaasta: " + ArrayID[1] + ArrayID[2] + "'");

        string birthMonth = ""+ ArrayID[3] + ArrayID[4];

        if (birthMonth == "01")
        {
            Console.WriteLine("     Sünnikuu: Jaanuar");
        }
        else if (birthMonth == "02")
        {
            Console.WriteLine("     Sünnikuu: Veebruar");
        }
        else if (birthMonth == "03")
        {
            Console.WriteLine("     Sünnikuu: Märts");
        }
        else if (birthMonth == "04")
        {
            Console.WriteLine("     Sünnikuu: Aprill");
        }
        else if (birthMonth == "05")
        {
            Console.WriteLine("     Sünnikuu: Mai");
        }
        else if (birthMonth == "06")
        {
            Console.WriteLine("     Sünnikuu: Juuni");
        }
        else if (birthMonth == "07")
        {
            Console.WriteLine("     Sünnikuu: Juuli");
        }
        else if (birthMonth == "08")
        {
            Console.WriteLine("     Sünnikuu: August");
        }
        else if (birthMonth == "09")
        {
            Console.WriteLine("     Sünnikuu: September");
        }
        else if (birthMonth == "10")
        {
            Console.WriteLine("     Sünnikuu: Oktoober");
        }
        else if (birthMonth == "11")
        {
            Console.WriteLine("     Sünnikuu: November");
        }
        else if (birthMonth == "12")
        {
            Console.WriteLine("     Sünnikuu: Detsember");
        }

        string birthDay = "" + ArrayID[5] + ArrayID[6];
        Console.WriteLine("     Sünnikuupäev: " + birthDay);

        if (IntArrayDouble[0] == 1 || IntArrayDouble[0] == 2 || IntArrayDouble[0] == 3 || IntArrayDouble[0] == 4)
        {
            string birthHospital = "" + ArrayID[7] + ArrayID[8] + ArrayID[9];
            int birthHospitalNum = Int32.Parse(birthHospital);

            // Haiglakoodid (kuni 2013. aasta)
            /*
            001...010 = "Kuressaare Haigla";
            011...019 = "Tartu Ülikooli Naistekliinik, Tartumaa, Tartu";
            021...220 = "Ida - Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla";
            221...270 = "Ida - Viru Keskhaigla(Kohtla - Järve, endine Jõhvi)";
            271...370 = "Maarjamõisa Kliinikum(Tartu), Jõgeva Haigla";
            371...420 = "Narva Haigla";
            421...470 = "Pärnu Haigla";
            471...490 = "Pelgulinna Sünnitusmaja(Tallinn), Haapsalu haigla";
            491...520 = "Järvamaa Haigla(Paide)";
            521...570 = "Rakvere, Tapa haigla";
            571...600 = "Valga Haigla";
            601...650 = "Viljandi Haigla";
            651...710 ? = "Lõuna - Eesti Haigla(Võru), Põlva Haigla";
            */

            if (birthHospitalNum >= 1 && birthHospitalNum <= 10)
            {
                Console.WriteLine("     Sünnihaigla: Kuressaare Haigla");
            }
            else if (birthHospitalNum >= 11 && birthHospitalNum <= 19)
            {
                Console.WriteLine("     Sünnihaigla: Tartu Ülikooli Naistekliinik, Tartumaa, Tartu");
            }
            else if (birthHospitalNum >= 21 && birthHospitalNum <= 220)
            {
                Console.WriteLine("     Sünnihaigla: Ida - Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla");
            }
            else if (birthHospitalNum >= 221 && birthHospitalNum <= 270)
            {
                Console.WriteLine("     Sünnihaigla: Ida - Viru Keskhaigla (Kohtla - Järve, endine Jõhvi)");
            }
            else if (birthHospitalNum >= 271 && birthHospitalNum <= 370)
            {
                Console.WriteLine("     Sünnihaigla: Maarjamõisa Kliinikum (Tartu), Jõgeva Haigla");
            }
            else if (birthHospitalNum >= 371 && birthHospitalNum <= 420)
            {
                Console.WriteLine("     Sünnihaigla: Narva haigla");
            }
            else if (birthHospitalNum >= 421 && birthHospitalNum <= 470)
            {
                Console.WriteLine("     Sünnihaigla: Pärnu Haigla");
            }
            else if (birthHospitalNum >= 471 && birthHospitalNum <= 490)
            {
                Console.WriteLine("     Sünnihaigla: Pelgulinna Sünnitusmaja (Tallinn), Haapsalu haigla");
            }
            else if (birthHospitalNum >= 491 && birthHospitalNum <= 520)
            {
                Console.WriteLine("     Sünnihaigla: Järvamaa Haigla (Paide)");
            }
            else if (birthHospitalNum >= 521 && birthHospitalNum <= 570)
            {
                Console.WriteLine("     Sünnihaigla: Rakvere, Tapa haigla");
            }
            else if (birthHospitalNum >= 571 && birthHospitalNum <= 600)
            {
                Console.WriteLine("     Sünnihaigla: Valga Haigla");
            }
            else if (birthHospitalNum >= 601 && birthHospitalNum <= 520)
            {
                Console.WriteLine("     Sünnihaigla: Viljandi Haigla");
            }
            else if (birthHospitalNum >= 651 && birthHospitalNum <= 710)
            {
                Console.WriteLine("     Sünnihaigla: Lõuna - Eesti Haigla(Võru), Põlva Haigla");
            }

            Console.WriteLine("     Haiglas antud päeva sünnijärjekorra number: " + IntArrayDouble[9]);
        }
        else if (birthyearNum >= 0 && birthyearNum <= 13)
        {

            Console.WriteLine("TEST KAS LÄKS TSÜKLISSE!!!");
            Console.WriteLine("birthYearNum TEST" + birthyearNum);


            string birthHospital = "" + ArrayID[7] + ArrayID[8] + ArrayID[9];
            int birthHospitalNum = Int32.Parse(birthHospital);

            if (birthHospitalNum >= 1 && birthHospitalNum <= 10)
            {
                Console.WriteLine("     Sünnihaigla: Kuressaare Haigla");
            }
            else if (birthHospitalNum >= 11 && birthHospitalNum <= 19)
            {
                Console.WriteLine("     Sünnihaigla: Tartu Ülikooli Naistekliinik, Tartumaa, Tartu");
            }
            else if (birthHospitalNum >= 21 && birthHospitalNum <= 220)
            {
                Console.WriteLine("     Sünnihaigla: Ida - Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla");
            }
            else if (birthHospitalNum >= 221 && birthHospitalNum <= 270)
            {
                Console.WriteLine("     Sünnihaigla: Ida - Viru Keskhaigla (Kohtla - Järve, endine Jõhvi)");
            }
            else if (birthHospitalNum >= 271 && birthHospitalNum <= 370)
            {
                Console.WriteLine("     Sünnihaigla: Maarjamõisa Kliinikum (Tartu), Jõgeva Haigla");
            }
            else if (birthHospitalNum >= 371 && birthHospitalNum <= 420)
            {
                Console.WriteLine("     Sünnihaigla: Narva haigla");
            }
            else if (birthHospitalNum >= 421 && birthHospitalNum <= 470)
            {
                Console.WriteLine("     Sünnihaigla: Pärnu Haigla");
            }
            else if (birthHospitalNum >= 471 && birthHospitalNum <= 490)
            {
                Console.WriteLine("     Sünnihaigla: Pelgulinna Sünnitusmaja (Tallinn), Haapsalu haigla");
            }
            else if (birthHospitalNum >= 491 && birthHospitalNum <= 520)
            {
                Console.WriteLine("     Sünnihaigla: Järvamaa Haigla (Paide)");
            }
            else if (birthHospitalNum >= 521 && birthHospitalNum <= 570)
            {
                Console.WriteLine("     Sünnihaigla: Rakvere, Tapa haigla");
            }
            else if (birthHospitalNum >= 571 && birthHospitalNum <= 600)
            {
                Console.WriteLine("     Sünnihaigla: Valga Haigla");
            }
            else if (birthHospitalNum >= 601 && birthHospitalNum <= 520)
            {
                Console.WriteLine("     Sünnihaigla: Viljandi Haigla");
            }
            else if (birthHospitalNum >= 651 && birthHospitalNum <= 710)
            {
                Console.WriteLine("     Sünnihaigla: Lõuna - Eesti Haigla(Võru), Põlva Haigla");
            }
        }
        else if (birthyearNum > 13) // Lastele sündinud pärast 2013. a
        {
            string birthHospital = "" + ArrayID[7] + ArrayID[8] + ArrayID[9];
            int birthHospitalNum = Int32.Parse(birthHospital);

            Console.WriteLine("     Antud päeva sünnijärjekorra / taotluse esitamise number: " + birthHospitalNum);
        }
        Console.WriteLine("     Kontrollnumber: " + checkNumber);

        Console.ReadKey();
    }
}
}
