using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo16Ocak2021Odev
{
    class MusteriManager
    {


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi+" İsimli Müşteri Eklendi! "+"Id No : "+musteri.Id);
        }

        public void Listele(Musteri[] musteriler)
        {

            Console.WriteLine("Müşteri Listesi ; ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri ID: " + musteri.Id + " Musteri Adı: " + musteri.MusteriAdi +
                    " Musteri Yaşı: " + musteri.MusteriYasi);
            }

            
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine( "Id No: " + musteri.Id+" olan "+musteri.MusteriAdi + " İsimli Müşteri Silindi! ");
        }

    }



   

}
