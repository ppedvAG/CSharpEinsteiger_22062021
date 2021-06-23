using System;

namespace HalloKlassen
{
    class Program
    {
        static int zahl = 23;

        static void Main(string[] args)
        {
            //Console.WriteLine(new DateTime(2000, 8, 31).AddMonths(6));

            Console.WriteLine("Hello World!");

            Console.WriteLine(zahl);
            Verdoppeln(zahl);
            Console.WriteLine(zahl);

            { //scope
                var ran = new Random();

            }

            Fahrzeug meinFahrzeug = null; //deklaration
            meinFahrzeug = new Fahrzeug(); //instanzierung
            meinFahrzeug.Modell = "B45";
            meinFahrzeug.Farbe = "gelb";
            meinFahrzeug.PS = 128;
            meinFahrzeug.SetHersteller("Baudi");

            Fahrzeug fahrzeugMitTollenCtor = new Fahrzeug("Bord", "OLO", "blau", 100);

            Fahrzeug anderesFahrzeug = new Fahrzeug(new DateTime(2000, 1, 1)); //deklaration und instanzierung in einer Zeile
                                                                               //var anderesFahrzeug2 = new Fahrzeug(); //das gleiche in kürzer
                                                                               //anderesFahrzeug.hersteller = "Besla";
            anderesFahrzeug.SetHersteller("Besla");
            anderesFahrzeug.Modell = "S1";
            //anderesFahrzeug.Farbe = "rot";
            anderesFahrzeug.PS = 348;
            anderesFahrzeug.Wochentag = DayOfWeek.Monday;


            ZeigeFahrzeug(meinFahrzeug);
            meinFahrzeug.MachAutoRosa();
            ZeigeFahrzeug(meinFahrzeug);

            ZeigeFahrzeug(anderesFahrzeug);

            Auto auto = new Auto();
            auto.AnzahlReifen = 4;
            auto.Farbe = "blau";
            ZeigeFahrzeug(auto);
            ZeigeAuto(auto);
            //ZeigeAuto(meinFahrzeug);

            Schiff schiff = new Schiff() { NebelHorn = true };

        }

        static void Verdoppeln(int einezahl)
        {
            zahl = 12;
            einezahl = einezahl * 2;
        }


        static void ZeigeFahrzeug(Fahrzeug einFahrzeug)
        {
            Console.WriteLine($"FAHRZEUG: {einFahrzeug.GetHersteller() } {einFahrzeug.Modell} {einFahrzeug.Farbe} {einFahrzeug.PS}");
        }

        static void ZeigeAuto(Auto einAuto)
        {
            Console.WriteLine($"AUTO: {einAuto.GetHersteller() } {einAuto.Modell} {einAuto.Farbe} {einAuto.AnzahlReifen}");
        }
    }

}
