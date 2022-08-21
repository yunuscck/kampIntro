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
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Yunus Çiçek";
            kurs1.IzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Emre Çiçek";
            kurs2.IzlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmeni = "Enes Yıldırım";
            kurs3.IzlemeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Kadirhan Harput";
            kurs4.IzlemeOrani = 100;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "Carbon";
            kurs5.Egitmeni = "Google";
            kurs5.IzlemeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };

            foreach (Kurs kurs in kurslar)
            {
                kurs.GetKursName();
                kurs.GetEgitmenName();

            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlemeOrani { get; set; }


        public void GetKursName()
        {
            Console.Write(KursAdi + " ");
        }

        public void GetEgitmenName()
        {
            Console.WriteLine(Egitmeni);
        }
    }
}
