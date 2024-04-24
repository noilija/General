using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLab3V2
{
    class AutoSUS : Auto
    {
        private double potrosnja;
        private double cenaGoriva;

        public AutoSUS()
        {
            Potrosnja = 0.0f;
            CenaGoriva = 0.0f;
        }
        public AutoSUS(string naziv, int godina, double potrosnja, double cenaGoriva) :
            base(naziv, godina)
        {

            Potrosnja = potrosnja;
            CenaGoriva = cenaGoriva;

        }

        public double Potrosnja { get => potrosnja; set => potrosnja = value; }
        public double CenaGoriva { get => cenaGoriva; set => cenaGoriva = value; }

        public override double cenaKilometra()
        {
            return potrosnja * cenaGoriva * 1.1 * (DateTime.Now.Year - godina);
        }
        public override void Citaj(string imeFajla)
        {
            string direktPath = imeFajla + "\\" + naziv + ".txt";
            base.Citaj(direktPath);
                using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.OpenOrCreate))
                {
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
                }
        }
        public override void Upisi(string imeFajla)
        {
            string direktPath = imeFajla + "\\" + naziv + ".txt";
            base.Upisi(direktPath);
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(potrosnja + " "
                + cenaGoriva);
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
        }
        public override void prikaz()
        {
            System.Console.WriteLine(this.GetType());
            base.prikaz();
            System.Console.WriteLine("Potrosnja " + potrosnja );
            Console.WriteLine("CenaGoriva: " + cenaGoriva );
            Console.WriteLine("CenaPoKilometru " + cenaKilometra() + "\n");
        }

        public override void Citaj2(string imeFajla)
        {
            //string direktPath = imeFajla + "\\" + naziv + ".txt";
            string direktPath = imeFajla;
            base.Citaj(direktPath);
            using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            }
        }
        public override void Upisi2(string imeFajla)
        {
            // string direktPath = imeFajla + "\\" + naziv + ".txt";

            string direktPath = imeFajla;
            base.Upisi(direktPath);
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                fajlZaUpis.Seek(0, SeekOrigin.End);
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(potrosnja + "\n"
                + cenaGoriva+"\n");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
        }
    }
}
