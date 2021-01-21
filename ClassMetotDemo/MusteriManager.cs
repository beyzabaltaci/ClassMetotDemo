using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın" +" "+ musteri.Id +" " + musteri.Adi + " "+ musteri.Soyadi +" " + "kaydınız tamamlanmıştır.");
        }
        public void Guncelleme(Musteri musteri)
        {
            Console.WriteLine("Sayın" + " " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + "güncellemeniz tamamlanmıştır.");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Sayın" + " " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + "isimli kaydın silme işlemi tamamlanmıştır.");
        }
    }
}
