using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.FirstName + " "+musteri.LastName);
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :" + musteri.FirstName + " " + musteri.LastName );
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :" + musteri.FirstName + " " + musteri.LastName);
        }

        
    }
}
