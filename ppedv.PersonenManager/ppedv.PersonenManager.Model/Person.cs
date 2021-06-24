using System;

namespace ppedv.PersonenManager.Model
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime GebDatum { get; set; }

        public abstract int Zahl { get;  }

        public abstract string GetAnrede();

        public virtual string SagMirWasDuBist()
        {
            return "Ich bin eine Person";
        }
    }
}
