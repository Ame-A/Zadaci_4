using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Domaci
{
    public class Metode
    {
        static public bool Provera(ObservableCollection<Imenik> Lista,string br, out Imenik i)
        {
            foreach (Imenik broj in Lista)
            {
                if (broj.Broj == br)
                {
                    i = broj;
                    return true;
                }
            }
            i = null;
            return false;
        }

        static public bool ProveraBroja(string br)
        {
            return Regex.IsMatch(br, @"^[0-9]+$");
        }

    }
}
