using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace HalloWelt
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //? -> €
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-sw");



            Console.WriteLine("Hello World!");

            string text = "Die ist ein Text";
            Console.WriteLine(text);


            int eineZahl = 14;
            Console.WriteLine($"Das ist eine Zahl: {eineZahl:0000} {DateTime.Now:dddd, dd.MM.yyyy}");

            double zahlMitKomma = 324.4235324324;
            Console.WriteLine($"Zahl mit Komma: {zahlMitKomma:###.000}");
            double zahlMitKommeGerundetAuf2Stellen = Math.Round(zahlMitKomma, 2);

            decimal geld = 35342.324m;
            Console.WriteLine($"Geld: {geld:c}");
            Console.WriteLine($"Geld: {geld.ToString("c", new CultureInfo("en-US"))}");


            Console.WriteLine("Gibt mir eine Zahl:");
            string eingabe = Console.ReadLine();

            //dirkt parse
            int eingabeAlsZahl = int.Parse(eingabe);
            Console.WriteLine($"Das doppelte ist: {eingabeAlsZahl * 2}");

            //try-parse ist cooler
            if (int.TryParse(eingabe, out int eingabeAlsZahlTryParse))
                Console.WriteLine($"Das doppelte ist: {eingabeAlsZahlTryParse * 2}");
            else
                Console.WriteLine("Eingabe wurde nicht als Zahl erkannt");


            double eineDouble = eineZahl; //implizites casting
            int einInt = (int)eineDouble; //explizites casting

            EinfacheMethode();
            MethodeMitEinemParameter("Fred");

            int summe = Sum(12, 456);
            int summe2 = Sum(12, 456, 45);
            int summe3 = Sum("Hallo", 22);

            int summe4 = Sum(12, 456, 45, 444, 4, 4, 4, 4, 5, 55, 5, 5);
        }


        private static int Sum(params int[] zahlen)
        {
            return zahlen.Sum();
        }
        private static int Sum(int v1, int v2)
        {
            return Sum(v1, v2, 0);
        }

        private static int Sum(string v1, int v2)
        {
            return 3;
        }

        private static int Sum(int v1, int v2, int v3 = 0)
        {
            return v1 + v2 + v3;
        }

        private static void MethodeMitEinemParameter(string name)
        {
            Console.WriteLine($"Hallo {name}");
        }

        private static void EinfacheMethode()
        {
            Console.WriteLine("Hallo ich bin eine Methode");
        }

        enum Pommesgrößen
        {
            Klein,
            Mittel,
            Groß
        }
    }
}
