using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPrL4v2
{
    internal class ListaVozaca
    {
        List<Vozac> vozaci;

        internal List<Vozac> Vozaci { get => vozaci; set => vozaci = value; }

        public ListaVozaca(int brojVozaca)
        {
            Vozaci = new List<Vozac>(brojVozaca);

          
        }
        public ListaVozaca()
        {
            Vozaci = new List<Vozac>(5);
        }

        public void dodajVozaca(Vozac vozac) 
        { 
            Vozaci.Add(vozac);
        }

        public Vozac vratiVozaca(int br)
        {
            if (Vozaci.Count != 0)
                return Vozaci[br];
            else throw new Exception("Prazna lista");
        }

        public void prikaz()
        {
            string ss = "";
            foreach(Vozac vo in vozaci)
            {
                ss += vo.Ime+ " ";
            }
            MessageBox.Show(ss);

        }


    }
}
