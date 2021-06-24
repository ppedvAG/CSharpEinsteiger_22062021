using System.Collections.Generic;

namespace ppedv.PersonenManager.Model
{
    public interface IDataStore
    {
        List<Mitarbeiter> GetMitarbeiters();

        void SaveAllMitarbeiter(List<Mitarbeiter> mitarbeiter);
    }
}
