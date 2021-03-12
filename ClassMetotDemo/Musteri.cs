using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Salih";
            int yas = 44;

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Salih";
            musteri1.Soyadi = "Kara";
            musteri1.Yasi = 44;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Onur";
            musteri2.Soyadi = "Yakup";
            musteri2.Yasi = 23;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Zeynep";
            musteri3.Soyadi = "Zafer";
            musteri3.Yasi = 29;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteriListele in musteriler)
            {
                Console.WriteLine("Ad: " + musteriListele.Adi);
                Console.WriteLine("Soyad: " + musteriListele.Soyadi);
                Console.WriteLine("Yaş " + musteriListele.Yasi);

                metodlar.Listele(musteriListele);

            }

            foreach (Musteri MusteriEkle in musteriler)
            {
                metodlar.Ekle(MusteriEkle);
            }

            foreach (Musteri MusteriSil in musteriler)
            {
                metodlar.Sil(MusteriSil);
            }

            foreach (Musteri MusteriGüncelle in musteriler)
            {
                metodlar.Güncelle(MusteriGüncelle);
            }
        }
    }
}
