using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miray Demir

          GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Miray";
            musteri1.Soyadi = "Demir";
            musteri1.TcNo = "12121212";



            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1215421";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "5454545";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




            


            //Gerçek müsteri - Tüzel müşteri
        }
    }
}
