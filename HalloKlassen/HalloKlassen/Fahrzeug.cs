using System;

namespace HalloKlassen
{
    class Auto : Fahrzeug
    {
        public int AnzahlReifen { get; set; }
    }

    class Fahrrad : Fahrzeug
    {
        public bool Klingel { get; set; }
    }

    class Tandem : Fahrrad
    {

    }

    class Schiff : Fahrzeug
    {
        public bool NebelHorn { get; set; }
    }

    class Fahrzeug
    {
        //properties / felder
        private string _hersteller; // feld

        public string GetHersteller() //getter funktion
        {
            return _hersteller;
        }

        internal void SetHersteller(string hersteller) //setter
        {
            if (hersteller != "vw")
                _hersteller = hersteller;
        }

        private string modell; //feld

        public string Modell //full-property
        {
            get
            {
                return modell;
            }
            internal set
            {
                modell = value;
            }
        }

        public int PS { get; set; } //auto-property

        public double KW { get { return PS * 1.6; } }

        private string farbe; //backing field
        public string Farbe
        {
            get { return farbe; }
            set
            {
                if (value != "pink")
                    farbe = value;
            }
        }

        public DayOfWeek Wochentag { get; set; }

        private int anzahlTüren;

        public int AnzahlTüren
        {
            get => anzahlTüren;
            set => anzahlTüren = value < 0 ? 0 : value;
        }

        public DateTime Baujahr { get; private set; }
        //methoden / funktionen
        public void MachAutoRosa()
        {
            Farbe = "rosa";
        }

        //ctor == nix rückgabe + name von der Klasse
        public Fahrzeug() : this(new DateTime(1990, 1, 1)) //default konstruktor
        {
            Farbe = "weiss"; //default werte festlegen
        }

        public Fahrzeug(DateTime baujahr)
        {
            Baujahr = baujahr;
        }
        public Fahrzeug(string hersteller, string modell, string farbe, int ps)
        {
            this._hersteller = hersteller;
            Modell = modell;
            Farbe = farbe;
            PS = ps;
        }

        ~Fahrzeug() //destruktor
        {

        }
    }

}
