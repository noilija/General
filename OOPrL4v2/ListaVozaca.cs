using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPrL4v2
{
    internal class ListaVozaca
    {
        List<Vozac> vozaci;

        public ListaVozaca(int brojVozaca)
        {
            vozaci = new List<Vozac>(brojVozaca);

          
        }

        public void dodajVozaca(Vozac vozac) 
        { 
            vozaci.Add(vozac);

        }

    }
}
