namespace ClassMetotDemo
{
    class MusteriManager
    {


        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi: " + musteri.Adi + " " + musteri.Soyadi + "\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Adi + " " + musteri.Soyadi + "\n");
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Adi + " " + musteri.Soyadi + "\n");
        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi: " + musteri.Adi + " " + musteri.Soyadi + "\n");
        }
    }
