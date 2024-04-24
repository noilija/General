using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLab3V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Auto a1 = new EAuto("Tesla", 2019, 23.2, 42.2,
                new DateTime(2022, 4, 20, 0, 0, 0));
            Auto a1t = new EAuto("Toyota", 2009, 21, 39.2,
                new DateTime(2025, 4, 20, 0, 0, 0));

            Auto a2 = new AutoSUS("Opel Zafira", 2003, 7.2, 220);
            Auto a3 = new AutoSUS("BMW", 2010, 9, 240);

            TaksiSluzba ts1 = new TaksiSluzba("CoolTaksi", 15, 100234);

            ts1.dodajAuto(a1);
            ts1.dodajAuto(a2);
            ts1.dodajAuto(a3);
            ts1.dodajAuto(a1t);
           
            ts1.prikazSluzbe();
            TaksiSluzba ts2 = ts1;
            ts2.sortiraj();
            ts2.prikazSluzbe();

            try
            {
                ts2.proveriBaterije();
            }
            catch (PotencijalnaEksplozija e)
            {
                Console.WriteLine(e.ToString());
            }
            ts2.izbaciPreskupaVozila();

            

            string path = "D:\\Ilija\\Faks\\uni\\SEM2\\PJ\\Vezbanje\\C#\\PJLab3V2\\FAJLOVI";
            ts2.upisiUFajl(path);
            ts2.CitajFajl(path);


            //a1.Upisi(path);
            //a1.Citaj(path);

            //a2sus.Upisi(path);
            //a2sus.Citaj(path);


            //string p = "D:\\Ilija\\Faks\\uni\\SEM2\\PJ\\Vezbanje\\C#\\PJLab3V2\\bin\\Debug\\net7.0" + "\\" + "A#A.txt";
            //Console.WriteLine(@"D:\Ilija\Faks\uni\SEM2\PJ\Vezbanje\C#\PJLab3V2\bin\Debug\net7.0\A#A.txt" + "\\" + "A#A.txt");
            //using (FileStream fajlZaCitanje = new FileStream(p, FileMode.OpenOrCreate))
            //{
            //    int velicina = (int)fajlZaCitanje.Length;
            //    byte[] nizBajtova = new byte[velicina];
            //    fajlZaCitanje.Read(nizBajtova, 0, velicina);
            //    Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            //}

            ts1.prikazSluzbe();


        }
    }
}
