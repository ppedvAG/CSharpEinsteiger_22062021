namespace ppedv.PersonenManager.Model
{
    public class Arzt : Person,IMenschenretter
    {
        public string Fachrichtung { get; set; }

        public override int Zahl
        {
            get
            {
                return 12;
            }
        }


        public override string GetAnrede()
        {
            return "Dr. ";
        }

        public int GetAnzahlGeretteteMenschen()
        {
            return 93;
        }
    }
}
