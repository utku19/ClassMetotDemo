using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1221321;
            musteri1.Adi = "Utku";
            musteri1.Soyadi = "Gök";
            musteri1.Yas = 24;
            musteri1.KullanimSuresiAy = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1312325;
            musteri2.Adi = "Tutku";
            musteri2.Soyadi = "Gök";
            musteri2.Yas = 31;
            musteri2.KullanimSuresiAy = 36;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1341214;
            musteri3.Adi = "Ataberk";
            musteri3.Soyadi = "Kurumoğlu";
            musteri3.Yas = 24;
            musteri3.KullanimSuresiAy = 12;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Liste(musteriler);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);

            
            

        }
    }
}
