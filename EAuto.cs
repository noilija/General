using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PJLab3V2
{
    class EAuto : Auto
    {
        private double kolicinaEn;
        private double cenaEn;
        private DateTime datumIsteka;

        public EAuto()
        {
            KolicinaEn = 0;
            CenaEn = 0;
            DatumIsteka = DateTime.Now;
        }
        public EAuto(string naziv, int godina, double kolicinaEn,
                      double cenaEn, DateTime datumIsteka)
            : base(naziv, godina)
        {
            KolicinaEn = kolicinaEn;
            CenaEn = cenaEn;
            DatumIsteka = datumIsteka;
        }

        public double KolicinaEn { get => kolicinaEn; set => kolicinaEn = value; }
        public double CenaEn { get => cenaEn; set => cenaEn = value; }
        public DateTime DatumIsteka { get => datumIsteka; set => datumIsteka = value; }

        public override double cenaKilometra()
        {
            return kolicinaEn * cenaEn * 1.05 * (-Godina + DateTime.Now.Year);
        }
        public override void Citaj(string imeFajla)
        {
            //string direktPath = imeFajla;
            string direktPath =imeFajla + "\\" + naziv + ".txt";
            base.Citaj(direktPath);
                using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.Open))
                {
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
                }
            
        }
        public override void Upisi(string imeFajla)
        {
            //string direktPath = imeFajla;
            string direktPath =imeFajla + "\\" + naziv + ".txt";
            base.Upisi(direktPath);
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(kolicinaEn + " "
                + cenaEn + " | " + datumIsteka);
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
        }
        public override void prikaz()
        {
            
            System.Console.WriteLine(this.GetType());
            base.prikaz();
            System.Console.WriteLine("KolicinaEnergije: " + kolicinaEn);
            Console.WriteLine("CenaEnergije: " + cenaEn );
            Console.WriteLine("DatumIstekaBaterija: " + datumIsteka );
            Console.WriteLine("CenaPoKilometru " + cenaKilometra() + "\n");

        }


        public override void Citaj2(string imeFajla)
        {
            string direktPath = imeFajla;
            //string direktPath = imeFajla + "\\" + naziv + ".txt";
            base.Citaj(direktPath);
            using (FileStream fajlZaCitanje = new FileStream(@direktPath, FileMode.Open))
            {

                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            }

        }
        public override void Upisi2(string imeFajla)
        {
            string direktPath = imeFajla;
            //string direktPath = imeFajla + "\\" + naziv + ".txt";
            base.Upisi(direktPath);
            using (FileStream fajlZaUpis = new FileStream(@direktPath, FileMode.OpenOrCreate))
            {
                fajlZaUpis.Seek(0, SeekOrigin.End);
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes(kolicinaEn + "\n"
                + cenaEn + "\n" + datumIsteka + "\n");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
        }




    }
}
