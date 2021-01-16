using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";*/
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs",
                "Java","Python" ,"C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR bitti");

            foreach (string kurs in kurslar)//dizi elemanlarını tek tek dolaşmaya yarar.Buradaki kurs alias
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
