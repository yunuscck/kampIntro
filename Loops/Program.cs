using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "Pyhton";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs", "java", "Pyhton", "C++" };



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("----FOR BİTTİ----");
            
            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }





            Console.WriteLine("sayfa sonu - footer");



















            // ;  <  >


        }
    }
}