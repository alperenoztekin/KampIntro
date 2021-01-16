using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type Safety:tip güvenliği değişkenin önüne veri türü yazmak demek
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45; //ondalıklı sayılar
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 1.75;
            double dolarBugun = 1.78;

            /*if (sistemeGirisYapmisMi==true)
            {
            Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yap");
            }
            */
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Oku");
            }

            //Console.WriteLine(kategoriEtiketi);

        }
    }
}
