using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Şeftali";
            urun3.Fiyati = 50;
            urun3.Aciklama = "Bursa şeftalisi";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }

            Console.WriteLine("--------Metodlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
           // sepetManager.Ekle();
           // sepetManager.Ekle();
        }
    }
}


