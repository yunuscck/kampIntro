using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yunus";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmeni = "Yunus Çiçek";
            kurs1.IzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmeni = "Emre Çiçek";
            kurs2.IzlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Pyhton";
            kurs3.Egitmeni = "Enes Yıldırım";
            kurs3.IzlemeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C++";
            kurs4.Egitmeni = "Kadirhan Harput";
            kurs4.IzlemeOrani = 100;

            Kurs kurs5 = new Kurs();
            kurs5.kursAdi = "Carbon";
            kurs5.Egitmeni = "Google";
            kurs5.IzlemeOrani = 100;


            //Console.WriteLine(kurs1.kursAdi + " - " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };

            foreach (Kurs kurs in kurslar)
            {
                //Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmeni);
                kurs.GetKursName();

            }
        }

    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlemeOrani { get; set; }


        public void GetKursName()
        {
            Console.WriteLine(kursAdi);
        }
    }
}
