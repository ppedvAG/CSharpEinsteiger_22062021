using ppedv.PersonenManager.Data.JSON;
using ppedv.PersonenManager.Data.XML;
using ppedv.PersonenManager.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ppedv.PersonenManager.UI_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Mitarbeiter> mitarbeiters = new List<Mitarbeiter>();
            mitarbeiters.Add(new Mitarbeiter() { Vorname = "Fred", Nachname = "Feuerstein" });
            mitarbeiters.Add(new Mitarbeiter() { Vorname = "Wilma", Nachname = "Feuerstein" });
            mitarbeiters.Add(new Mitarbeiter() { Vorname = "Barney", Nachname = "Geröllheimer" });
            mitarbeiters.Add(new Mitarbeiter() { Vorname = "Betty", Nachname = "Geröllheimer" });

            dataGridView1.DataSource = mitarbeiters;
        }

        private IDataStore datastore = new XmlClient();

        private void button2_Click(object sender, EventArgs e)
        {
            datastore.SaveAllMitarbeiter(dataGridView1.DataSource as List<Mitarbeiter>);
            MessageBox.Show("ok");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = datastore.GetMitarbeiters();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                datastore = new XmlClient();
            else if(radioButton2.Checked)
                datastore = new JsonClient();

        }
    }
}
