namespace ppedv.PersonenManager.Model
{
    public class Mitarbeiter : Person
    {
        public string Beruf { get; set; }

        public override int Zahl => -3;

        public override string GetAnrede()
        {
            return "Mr./Mrs.";
        }

        public override string SagMirWasDuBist()
        {
            return "Ich bin ein Mitarbeiter";
        }
    }
}
