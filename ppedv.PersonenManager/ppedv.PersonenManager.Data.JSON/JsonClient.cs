using Newtonsoft.Json;
using ppedv.PersonenManager.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace ppedv.PersonenManager.Data.JSON
{
    public class JsonClient : IDataStore
    {
        public string FilePath { get; set; } = "Mitarbeiter.json";

        public List<Mitarbeiter> GetMitarbeiters()
        {
            using (var sr = new StreamReader(FilePath))
            {
                return JsonConvert.DeserializeObject<List<Mitarbeiter>>(sr.ReadToEnd());
            }
        }

        public void SaveAllMitarbeiter(List<Mitarbeiter> mitarbeiter)
        {
            using (var sr = new StreamWriter(FilePath))
            {
                var json = JsonConvert.SerializeObject(mitarbeiter, Formatting.Indented);
                sr.Write(json);
            }
        }
    }
}
