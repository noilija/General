using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLab3V2
{
    abstract public class Auto : IComparable<Auto>
    {
        protected string naziv;
        protected int godina;

        public Auto()
        {
            Naziv = string.Empty;
            Godina = 0;
        }
        public Auto(string naziv, int godina)
        {
            Naziv = naziv;
            Godina = godina;
        }

        public int Godina { get => godina; set => godina = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        

        public abstract double cenaKilometra();
        public virtual void prikaz()
        {

            System.Console.WriteLine("Auto: " + naziv + "\n"
                + "Godina: " + godina);
        }
        public virtual void Upisi(string imeFajla)
        {
            string direktPath = imeFajla;
           // string direktPath =imeFajla + "\\" + naziv + ".txt";
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(naziv + " " + godina);
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
               
            }
           
        }
        public virtual void Citaj(string imeFajla)
        {
            string direktPath = imeFajla;
            //string direktPath =imeFajla + "\\" + naziv + ".txt";
            using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.OpenOrCreate))
                {
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
                }  

        }

        public int CompareTo(Auto other)
        {
            return -this.godina + other.godina;
        }

        public virtual void Upisi2(string imeFajla)
        {
            string direktPath = imeFajla;
            // string direktPath =imeFajla + "\\" + naziv + ".txt";
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                fajlZaUpis.Seek(0, SeekOrigin.End);
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(naziv + "\n" + godina+"\n");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);

            }

        }
        public virtual void Citaj2(string imeFajla)
        {
            string direktPath = imeFajla;
            //string direktPath =imeFajla + "\\" + naziv + ".txt";
            using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));


            }

        }




    }
}
