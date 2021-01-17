using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkleme(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi + " adlı müşterinin kaydı eklendi ");
            Console.WriteLine("-------------------------");

        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : "  + musteri.Soyad);
                Console.WriteLine("Müşteri Telefon Numarası : "  + musteri.TelefonNo);
                Console.WriteLine("Müşteri Emaili : "  + musteri.Email);
                Console.WriteLine("---------------------");
            } 

        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(musteri.Adi +  " adlı müşterinin kaydı silindi ");


        }
    }
}
