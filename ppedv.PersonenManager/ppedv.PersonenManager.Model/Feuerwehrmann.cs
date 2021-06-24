namespace ppedv.PersonenManager.Model
{
    public class Feuerwehrmann : Person, IMenschenretter
    {
        public override int Zahl => 19;

        public override string GetAnrede()
        {
            return "Held";
        }

        public int GetAnzahlGeretteteMenschen()
        {
            return 12;
        }
    }
}
