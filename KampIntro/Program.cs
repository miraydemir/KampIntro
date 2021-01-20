using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - KEndini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //or false  sistemegirisyapmismibibak diyor aslında!!
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }




            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
