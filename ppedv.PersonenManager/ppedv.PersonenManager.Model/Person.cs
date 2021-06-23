using System;

namespace ppedv.PersonenManager.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime GebDatum { get; set; }
    }
}
