using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Adi = "Beyza";
            musteri1.Soyadi = "Baltacı";
            musteri1.Sehir = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1234;
            musteri2.Adi = "Belgin";
            musteri2.Soyadi = "Kaya";
            musteri2.Sehir = "Ankara";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Guncelleme(musteri1);
            musteriManager.Guncelleme(musteri2);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);


        }
    }
}
