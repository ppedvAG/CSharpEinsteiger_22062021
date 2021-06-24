using ppedv.PersonenManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ppedv.PersonenManager.Data.XML
{
    public class XmlClient : IDataStore
    {
        public string FilePath { get; set; } = "Mitarbeiter.xml";

        public List<Mitarbeiter> GetMitarbeiters()
        {
            using (var sr = new StreamReader(FilePath))
            {
                var serial = new XmlSerializer(typeof(List<Mitarbeiter>));
                return (List<Mitarbeiter>)serial.Deserialize(sr);
            }
        }

        public void SaveAllMitarbeiter(List<Mitarbeiter> mitarbeiter)
        {
            using (var sw = new StreamWriter(FilePath))
            {
                var serial = new XmlSerializer(typeof(List<Mitarbeiter>));
                serial.Serialize(sw, mitarbeiter);

                //sw.Flush();
                // sw.Close();
                //sw = null;
            } //--> //sw.Dispose();
        }
    }
}
