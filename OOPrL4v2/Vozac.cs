using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPrL4v2
{
    struct Kategorije
    {
        // dozvoljene
        public VozackeKategorije kategorije;
        public DateTime kategorijeDatumOd;
        public DateTime kategorijeDatumDo;

        // zabrana upravljanja 
        //public VozackeKategorije zabranjeneKategorije;
        //public DateTime zabranjeneDatumOd;
        //public DateTime zabranjeneDatumDo;
    }
    

    internal class Vozac
    {
        #region Atributi
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private DateTime vazenjeDozvoleOd;
        private DateTime vazenjeDozvoleDo;
        private int brojVozacke;
        private string mestoIzdavanja;
        private char pol;
        private List<Kategorije> kategorije;
        private List<Kategorije> zabranjeneKategorije;
        private string putanjaSlike;
        #endregion

        #region Svojstva
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public DateTime VazenjeDozvoleOd { get => vazenjeDozvoleOd; set => vazenjeDozvoleOd = value; }
        public DateTime VazenjeDozvoleDo { get => vazenjeDozvoleDo; set => vazenjeDozvoleDo = value; }
        public int BrojVozacke { get => brojVozacke; set => brojVozacke = value; }
        public string MestoIzdavanja { get => mestoIzdavanja; set => mestoIzdavanja = value; }
        public char Pol { get => pol; set => pol = value; }
        public string PutanjaSlike { get => putanjaSlike; set => putanjaSlike = value; }
        #endregion

        public Vozac()
        {
            ime = "";
            prezime = "";
            datumRodjenja = DateTime.Now;
            vazenjeDozvoleOd = DateTime.Now;
            vazenjeDozvoleDo = DateTime.Now;
            brojVozacke = 0;
            mestoIzdavanja = "";
            pol = 'n';
            kategorije = new List<Kategorije>(20);
            zabranjeneKategorije = new List<Kategorije>(20);
        }

        #region Kategorije - Operacije
        public void obrisiKategoriju(int br)
        {
            kategorije.RemoveAt(br);
        }
        public void obrisiZabranjenuKategoriju(int br)
        {
           zabranjeneKategorije.RemoveAt(br);
        }
        public void dodajKategoriju(Kategorije kat)
        {
            kategorije.Add(kat);
        }
        public void zabraniKategoriju(Kategorije kat)
        {
            zabranjeneKategorije.Add(kat);
        }
        #endregion



    }
}
