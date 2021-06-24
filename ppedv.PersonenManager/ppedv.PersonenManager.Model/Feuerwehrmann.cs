using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.PersonenManager.Model
{
   public class Feuerwehrmann : Person
    {
        public override int Zahl => 19;

        public override string GetAnrede()
        {
            return "Held ";
        }
    }
}
