# C-_Harjutused

Ülesanne 1
Kirjuta programm, mis sind tervitab.


Ülesanne 2
Koosta programm on öeldud tehte 3 + 8 / (4 - 2) * 4 vastuse?
+Kuidas mõjutab sulgude kasutamine/kasutamata jätmine c# tööd?
+Katseta erinevaid kombinatsioone paralleelselt ning lisa ka selgitavad tekstid, et väljund oleks arusaadav.


Ülesanne 2.1
Ruudu sees asub ring. Ringi raadius on 3.
Leia ja väljasta ekraanile ruudu pindala, ruudu ümbermõõt, ringi pindala, ringi ümbermõõt.

Ülesanne 2.2
Koosta programm, mis arvutab välja Maa ümbermõõdu ekvaatori kohal 2-eurostes müntides ehk teisisõnu: kui palju 2-euroseid münte tuleb panna üksteise kõrvale, et rida ulatuks ümber Maa. Kasuta teadmist, et Maa raadius ekvaatori kohal on 6378 km. 

Algandmed (Maa raadius, mündi läbimõõt jne) omista programmi alguses sisukate nimedega muutujatele. Kuna ümbermõõdu arvutamiseks tuleb kasutada  PI-d (3,14...), siis võid selle (umbkaudse) väärtuse otse programmi kirjutada.  
Püüdke välja mõelda viise, kuidas juhuslikest vigadest valemis hoiduda (teisendamised, ümardamise täpsus jne). Võimalusel võrrelge tulemusi teistega. Kui on erinevusi, leidke ühiselt põhjused.
Kas programm on piisavalt hästi kirjutatud, et algandmete muutumise korral (näiteks juhul, kui on vaja arvutada Marsi ümbermõõtu 1-eurostes müntides) on parandusi selge ja lihtne teha?



Ülesanne 3

Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
kill-koll kill-koll killadi-koll kill-koll kill-koll killadi-koll kill-koll kill-koll killkoll
kill-koll


Kas kasutasid muutujaid? Millistel juhtudel oleks muutujate kasutamine kindlasti otstarbekas?


Ülesanne 4
Koosta programm, mis väljastaks järgmised laulusõnad:

Rong see sõitis tsuhh tsuhh tsuhh,
piilupart oli rongijuht.
Rattad tegid rat tat taa,
rat tat taa ja tat tat taa.
Aga seal rongi peal,
kas sa tead, kes olid seal?


Kuidas lahendasid ülesande? Kas seda saaks teha kuidagi paremini? Kui lihtne oleks sellest programmist teha uus, kui
soovitakse hoopis järgmist laulu?

Rong see sõitis tuut tuut tuut,
piilupart oli rongijuht.
Rattad tegid kill koll koll,
kill koll koll ja kill koll kill.


....Sisend, väljund, tingimus....

Ülesanne 5
Koosta programm, mis küsib kasutajalt ristküliku lähiskülgede pikkused ning väljastab ekraanile ristküliku ümbermõõdu ja pindala.


Ülesanne 6
Koosta programm, mis küsib kasutajalt nime ja vanust ja väljastab ekraanile nimelise tervituse koos tekstiga, mis ütleb, kas
tegemist on kooliealise (7-18-aastase) inimesega.


Ülesanne 7
Koosta lihtne kalkulaator. Kasutajalt küsitakse kaks arvu ja tehtemärk ning seejärel kuvatakse tehe koos vastusega.
Nt.
Sisestage esimene arv: 2
Sisestage teine arv: 3
Sisestage tehe: +
Tulemus: 2+3=5


Ülesanne 8
Eelmise ülesande alusel koostage programm M-Koer (Matemaatiline Koer), millele antakse samuti ette kaks arvu ja tehtemärk,
kuid vastus ei kirjutata mitte arvulisel kujul, vaid esitatakse "haukudes". Igaks juhuks: tsükleid kasutada pole vaja.
Sisestage esimene arv: 2
Sisestage teine arv: 3
Sisestage tehe: +
Tulemus: auh auh auh auh auh

Ülesanne 9
Koosta programm, mis küsib kasutajalt temperatuuri Celsiuse kraadides ja väljastab tulemuse Fahrenheiti kraadides.
Kuidas muuta programmi nii, et võimalik oleks teisendamine nii üht- kui teistpidi? Proovi.

Täiendused:
* Kasutajalt küsitakse Celsiuse õue temperatuuri, keskmise tuule kiirust ja õhuniiskust - ning arvutatakse tajutavtemperatuur.
Võrdle kindlasti erinevate ilmajaamade tulemusi tajutava temperatuuride kohta (nt. http://www.ilmateenistus.ee/?ide=2&shownews=110 ja http://ilm.ee/)
Loe lisaks Riigi Ilmateenistuse kodulehelt tajutava temperatuuri arvutamise kohta.

Tajutav temperatuur.
Tajutav temp = T+(0.33*(RH/100*6.105*exp(17.27*T/(237.7+T))))-(0.70*Ws)-4
T – hetketemperatuur °C 2m kõrgusel
V/Ws – keskmine tuule kiirus m/s 10m kõrgusel
RH – õhuniiskus %

 static void Main()
    {
        Console.Write("Sisesta C. temperatuur: ");
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
        double tuul =  T + (0.33 * (((RH/100 * 6.105 *  Math.Exp(17.27 * T / (237.7 + T)))) - (0.7 * Ws))) - 4;
        double tuul2 = T + (0.33 * (RH / 100 * 6.105 * Math.Exp(17.27 * T / (237.7 + T)))) - (0.70 * Ws) - 4;
        Console.Write("Seega tajutav temperatuur on: " + tuul+ "vana arvutus tuleb seega" + tuul2);

        Console.ReadKey();
    }


Ülesanne 9.1 
Eestis kasutatav isikukood koosneb üheteistkümnest numbrist. Tutvu isikukoodi struktuuriga (https://et.wikipedia.org/wiki/Isikukood) ja kirjuta programm, mis analüüsib isikukoode ja väljastab võimalikult rohkem infot selle kohta (sünnikuupäev, sugu jne). Isikukoodi käsitlege kui sümbolite kogumit ehk sõnet (kuigi see koosneb numbritest), analüüsimiseks kasutage sõneoperatsioone (vt. käsiraamat). Kuna isikukoode on keeruline testimise ajal korduvalt sisestada, on alguses mõistlik sisestada erinevad isikukoodid ning kommenteerida vastavalt vajadusele ülearused välja, näiteks järgnevalt kasutatakse teisel real olevat isikukoodi: 
#isikukood = "60201302715"
isikukood = "48008082727"
#isikukood = "31212230156"
[...]

Hiljem võib lisada isikukoodi küsimise kasutajalt. 
Täiendusi:
* Vastavalt toodud isikukoodi tutvustavale artiklile võrdle esimest kümmet numbrit ja viimast numbrit (nn. kontrollnumbrit), et teha selgeks, kas isikukood on üldse kehtiv.
* Koosta funktsioon, mis ise automaatselt koostab kehtivaid isikukoode. Võimatud on näiteks isikukoodid vale kontrollnumbriga, kuid ka sellised, mis viitavad olematule kuupäevale (algusega "3950230...", mis tähendaks 30. veebruari) vms. Vali kas "ohutu" tee (ette on antud piirid, mis kehtivad igal juhul) või loo sisemised sõltuvused (stiilis "kui kuu on aprill, siis maksimaalsete päevade arv on 30").


Ülesanne 10
Eelmises peatükis koostasime programme, kus algandmed olid programmi teksti jäigalt sisse kirjutatud. Vali neist 2 (sobivaimad
on ilmselt viimased) ning lisa neile vajalike sisendandmete küsimine. Kuna tegemist on olukorraga, kus kasutaja võib andmete
sisestamisel eksida (sisestada vale tüüpi andmeid, mis annavad programmi töötamisel vea, näiteks kirjutada arvu asemel teksti),
püüa mõelda (ja internetist otsida) võimalusi, kuidas selliseid vigu vältida.



Tsükkel, plokkskeem

Ülesanne 11
Koosta programm, mis küsib kasutajalt nime ja tervitab teda nimeliselt 5 korda ja lisab ka tervituse järjekorranumber.
Palun sisesta oma nimi:
>> Siim
Ole tervitatud, Siim, 1. korda.
Ole tervitatud, Siim, 2. korda.
Ole tervitatud, Siim, 3. korda.
Ole tervitatud, Siim, 4. korda.
Ole tervitatud, Siim, 5. korda.


Ülesanne 12
Koosta programm, mis küsib kasutajalt 10 korda arve ja väljastab seejärel nende arvude summa.
Täienda seda programmi nii, et kasutajalt küsitakse arve seni, kuni kasutaja enam uut arvu ei sisesta, vaid vajutab lihtsalt
sisestusklahvi.
Proovige seda ülesannet lahendada nii while- kui for-tsükliga.


Ülesanne 13
Koosta programm, mis aitab lastel treenida liitmist. Programm peaks pakkuma välja juhuslike arvudega liitmistehteid ning ootama kasutajalt vastust. Kui vastus on õige, kiitma kasutajat, kui aga vale, andma õige vastuse ja esitama uue tehte. Järjest esitatavate tehete hulk võib olla programmis ette antud (näiteks 10), samuti võib olla ette antud piirid, kui suuri arve kasutajalt küsitakse (näiteks 1 kuni 50). Programm peaks pidama arvestust ka õigete vastuste üle ning väljastama pärast viimast tehet tulemuse. 

Näiteks:
Tere! Õpime arvutama. Esitan 10 liitmistehet, püüa vastata õigesti.
5 + 16 = 
>> 21
Tubli, õige vastus! 
18 + 23 =
>> 39
Sinu vastus polnud õige. Õige vastus on 41.
[...]
2 + 5 = 
>> 7
Tubli, õige vastus!
See oli viimane ülesanne. Kogusid 10-st punktist 7.

Täiendusi vabal valikul:
Programm lubab kasutajal alguses sisestada, mitut tehet soovitakse.
Esitatavate arvude piirid saab kasutaja ette anda (maksimum või nii miinimum kui maksimum).
* Küsitakse mitte ainult liitmistehteid, vaid ka teisi (lahutamine, korrutamine, jagamine).
* Vastavalt lõpptulemusele reageeritakse erinevalt: "Ülihea!", "Olid tubli!", "Korralik keskmine tulemus!", "Püüad järgmisel korral rohkem." vms.


Ülesanne 14
Täienda eelmist programmi selliselt, et kasutajal oleks arvu arvamiseks 5 korda, s. t. kui viie korra jooksul ära ei arvata, ütleb
arvuti, et kaotasid, ning teatab õige arvu.

Ülesanne 15
Väljasta ekraanile arvud 1-10 (iga arv eraldi real). Täienda programmi selliselt, et väljastustulemuseks oleks korrutustabel.


Ülesanne 16
Koosta programm, mis küsib kasutajalt arvu N ja väljastab O-tähtedest koosneva ruudu suuruses NxN. Seejärel muutke
programmi nii, et ruudu diagonaalidel olevad märgid oleksid X-d, näiteks:
X O O O O O O O X
O X O O O O O X O
O O X O O O X O O
O O O X O X O O O
O O O O X O O O O
O O O X O X O O O
O O X O O O X O O
O X O O O O O X O
X O O O O O O O X

... või (paarisarvulise N-i puhul):
X O O O O O O O O X
O X O O O O O O X O
O O X O O O O X O O
O O O X O O X O O O
O O O O X X O O O O
O O O O X X O O O O
O O O X O O X O O O
O O X O O O O X O O
O X O O O O O O X O
X O O O O O O O O X
Tühikuid võid lisada vastavalt oma soovile.

Ülesanne 17
On selge, et auto kiiruse tõstmine vähendab sõidule kuluvat aega ehk ma jõuame varem sihtpunkti. Kui palju me aga ajas
võidame? Koostage programm, mis küsib käivitamisel läbitava vahemaa pikkust (kilomeetrites, see kehtib kogu programmitöö
aja), seejärel aga küsib kasutajalt korduvalt kiirust (km/h) ning väljastab selle põhjal korrektse lausega sõiduks kuluva aja ja
erinevuse eelmisest tulemusest. Kui kasutaja uut kiirust ei sisesta, vaid vajutab lihtsalt sisestusklahvile, siis katkestatakse tsükkel
ja tänatakse kasutajat.



