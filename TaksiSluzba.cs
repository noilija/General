using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using PJLab3V2;

namespace PJLab3V2
{
    internal class TaksiSluzba
    {
        private string nazivSluzbe;
        private int brojKilometara;
        private double ukupnaCena;
        private List<Auto> vozila;
        private int top;

        public int this[int i]
        {
            get => vozila[i].Godina;
            set => vozila[i].Godina = value;
        }

        public TaksiSluzba()
        {

            nazivSluzbe = string.Empty;
            brojKilometara = 0;
            ukupnaCena = 0;
            top = 0;
            //vozila=new ;

        }
        public TaksiSluzba(string naziv, int brojK,
                            double cena)
        {
            nazivSluzbe = naziv;
            brojKilometara = brojK;
            ukupnaCena = cena;
            top = 0;
            vozila = new List<Auto>();

        }
        public string NazivSluzbe { get => nazivSluzbe; set => nazivSluzbe = value; }
        public int BrojKilometara { get => brojKilometara; set => brojKilometara = value; }
        public double UkupnaCena { get => ukupnaCena; set => ukupnaCena = value; }

        public void dodajAuto(Auto a1)
        {
            vozila.Add(a1);
            top++;

        }
        public void prikazSluzbe()
        {
            System.Console.WriteLine("-----------------");
            Console.WriteLine(nazivSluzbe + " " +
            brojKilometara + " " + ukupnaCena.ToString());
            Console.WriteLine("Prosek " + ukupnaCena / brojKilometara + "\n");

            for (int i = 0; i < vozila.Count(); i++)
                vozila[i].prikaz();
        }
        public void izbaciPreskupaVozila()
        {
            double prosek = ukupnaCena / brojKilometara;
            for (int i = 0; i < vozila.Count; i++)
            {
                if (vozila[i].cenaKilometra() > prosek)
                {
                    vozila.RemoveAt(i--);

                }
            }
        }
        public void sortiraj()
        {
            vozila.Sort();
        }

        public void proveriBaterije()
        {
            foreach (Auto a in vozila)
            {
                if (a is EAuto)
                {
                    EAuto auto = (EAuto)a;
                    if (auto.DatumIsteka < DateTime.Now)
                    {
                        throw new PotencijalnaEksplozija("EKSPLOZIJA !!");

                    }
                }
            }

        }
        public void upisiUFajl(string putanja)
        {
            string direktPath = putanja + "\\" + nazivSluzbe + ".txt";
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(nazivSluzbe + "\n" + brojKilometara
                    + "\n"+ ukupnaCena+"\n");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);

            }
            foreach (Auto a in vozila)
            {
                a.Upisi2(direktPath);
            }
        }
        public void CitajFajl(string putanja)
        {
            string direktPath = putanja + "\\" + nazivSluzbe + ".txt";
            //string direktPath =imeFajla + "\\" + naziv + ".txt";
            using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            }
            //foreach (Auto a in vozila)
           // {
              //  a.Citaj2(direktPath);
           // }
        }
    }
}