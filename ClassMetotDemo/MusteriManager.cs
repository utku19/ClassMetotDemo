using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("\n Id No : " + musteri.Id + " \n Adı : " + musteri.Adi + " \n Soyadı : " + musteri.Soyadi + " \n Yaş : " + musteri.Yas + " \n Aylık Süre : " + musteri.KullanimSuresiAy);
            Console.WriteLine("Müşteri eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(" \n Id No : " + musteri.Id + " \n Adı : " + musteri.Adi + " \n Soyadı : " + musteri.Soyadi + " \n Yaş : " + musteri.Yas + " \n Aylık Süre : " + musteri.KullanimSuresiAy);
            Console.WriteLine("Müşteri Silindi");
        }

        public void Liste(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(" \n Id No : " + musteri.Id + " \n Adı : " + musteri.Adi + " \n Soyadı : " + musteri.Soyadi + " \n Yaş : " + musteri.Yas + " \n Aylık Süre : " + musteri.KullanimSuresiAy);
            }
            Console.WriteLine("Tüm müşteri bilgileri");

        }
    }
}
