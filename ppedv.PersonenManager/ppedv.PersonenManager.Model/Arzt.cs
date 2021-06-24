namespace ppedv.PersonenManager.Model
{
    public class Arzt : Person
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
    }
}
