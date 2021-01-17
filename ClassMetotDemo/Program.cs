using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyad = "Demir";
            musteri1.TelefonNo = "05***********";
            musteri1.Email = "ahmet*****@gmail.com";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Mehmet";
            musteri2.Soyad = "Balamir";
            musteri2.TelefonNo = "05***********";
            musteri2.Email = "mehmet*****@gmail.com";

            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.Adi = "Himmet";
            musteri3.Soyad = "Emir";
            musteri3.TelefonNo = "05***********";
            musteri3.Email = "himmet*****@gmail.com";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-------------Sistemimize Hoşgeldiniz------------");
            
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);

            musteriManager.MusteriListeleme(musteriler);

            musteriManager.MusteriSilme(musteri2);

        }
    }
}
