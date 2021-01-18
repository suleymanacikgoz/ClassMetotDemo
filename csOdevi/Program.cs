using System;

namespace csOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Ali";
            musteri1.musteriSoyadi = "Yazıcı";
            musteri1.musteriID = 53;
            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Gökhan";
            musteri2.musteriSoyadi = "Aydın";
            musteri2.musteriID = 74;
            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Süleyman";
            musteri3.musteriSoyadi = "Açıkgöz";
            musteri3.musteriID = 37;

            Musteri[] musteriListesi = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musterilistesi = new MusteriManager();

            musterilistesi.musteriListele(musteriListesi);


           


        }

        
    }
}
