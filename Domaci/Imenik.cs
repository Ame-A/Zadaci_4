using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{

    public class Imenik
    {
        public string Ime { get; set; }
        public string Broj { get; set; }
        public string Datum_Dod { get; set; }

        public Imenik() { }

        public Imenik(string i, string b)
        {
            Ime = i;
            Broj = b;
            Datum_Dod = DateTime.Now.ToString("dd:MM:yy - HH:mm");
        }
    }
}
