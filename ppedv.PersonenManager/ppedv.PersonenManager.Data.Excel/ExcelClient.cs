using ClosedXML.Excel;
using ppedv.PersonenManager.Model;
using System.Collections.Generic;

namespace ppedv.PersonenManager.Data.Excel
{
    public class ExcelClient : IDataStore
    {
        public string FilePath { get; set; } = "Mitarbeiter.xlsx";
        public List<Mitarbeiter> GetMitarbeiters()
        {
            using (var workbook = new XLWorkbook(FilePath))
            {
                IXLWorksheet sheet;
                List<Mitarbeiter> mList = new List<Mitarbeiter>();
                if (workbook.Worksheets.TryGetWorksheet("Mitarbeiter", out sheet))
                {
                    int row = 1;
                    while (!string.IsNullOrWhiteSpace(sheet.Cell(row, 1).Value.ToString()))
                    {
                        var m = new Mitarbeiter();
                        m.Vorname = sheet.Cell(row, 1).Value.ToString();
                        m.Nachname = sheet.Cell(row, 2).Value.ToString();
                        m.Beruf = sheet.Cell(row, 3).Value.ToString();
                        
                        mList.Add(m);
                        row++;
                    }                                        
                }                                            
                return mList;                                
                                                             
            }                                                
        }

        public void SaveAllMitarbeiter(List<Mitarbeiter> mitarbeiter)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet sheet;
                if (!workbook.Worksheets.TryGetWorksheet("Mitarbeiter", out sheet))
                {
                    sheet = workbook.Worksheets.Add("Mitarbeiter");
                }

                for (int i = 0; i < mitarbeiter.Count; i++)
                {
                    sheet.Cell(i + 1, 1).Value = mitarbeiter[i].Vorname;
                    sheet.Cell(i + 1, 2).Value = mitarbeiter[i].Nachname;
                    sheet.Cell(i + 1, 3).Value = mitarbeiter[i].Beruf;
                }
                workbook.SaveAs(FilePath);
            }
        }
    }
}
