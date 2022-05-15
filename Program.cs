using System;

namespace ClassMetotDemo16Ocak2021Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriYasi = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Veli";
            musteri2.MusteriYasi = 35;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

           
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteriler);



        }
    }
}
