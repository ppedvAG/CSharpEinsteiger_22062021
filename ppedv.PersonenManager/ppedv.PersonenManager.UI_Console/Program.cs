using ppedv.PersonenManager.Model;
using System;

namespace ppedv.PersonenManager.UI_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Person person = new Person() { Vorname = "Fred", Nachname = "Feuerstein" };
            Arzt doc = new Arzt() { Vorname = "Dr. ", Nachname = "Arcula", Fachrichtung = "Blut" };
            Mitarbeiter mitarbeiter = new Mitarbeiter() { Vorname = "Boris", Nachname = "Becker", Beruf = "Tennis" };
            Feuerwehrmann fm = new Feuerwehrmann() { Vorname = "Fred", Nachname = "Durst"  };

            //ZeigePerson(person);
            ZeigePerson(doc);
            ZeigePerson(mitarbeiter);
            ZeigePerson(fm);

            Console.ReadLine();
        }

        static void ZeigePerson(Person person)
        {
            Console.WriteLine($"{person.GetAnrede()}  {person.Vorname} {person.Nachname} [{person.Zahl}]");
            Console.WriteLine($"Was ist es: {person.SagMirWasDuBist()}");
            if(person is Mitarbeiter m)
                Console.WriteLine($"Was ist es: {m.SagMirWasDuBist()}");


            //Variante 1: Old-School (2003-2005)
            if (person is Arzt) //typprüfung
            {
                Arzt personAlsArzt = (Arzt)person; //casting
                Console.WriteLine($"\tDas ist ein Arzt mit der Fachrichtung {personAlsArzt.Fachrichtung}");
            }

            //Variant 2: Boxing (ab 2005--)
            Arzt personAlsArzt2 = person as Arzt;
            if (personAlsArzt2 != null)
            {
                Console.WriteLine($"\tDas ist ein Arzt mit der Fachrichtung {personAlsArzt2.Fachrichtung}");
            }

            //Variante 3: Pattern-Matching (2015--)
            if(person is Arzt personAlsArzt3)
            {
                Console.WriteLine($"\tDas ist ein Arzt mit der Fachrichtung {personAlsArzt3.Fachrichtung}");
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
