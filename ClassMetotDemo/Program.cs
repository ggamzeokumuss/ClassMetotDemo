using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Gamze";
            musteri1.LastName = "Okumuş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Ali";
            musteri2.LastName = "Deniz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Ayşe";
            musteri3.LastName = "Özgür";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.FirstName);
                Console.WriteLine(musteri.LastName);
                Console.WriteLine("-----------------------------");


            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-----------LİSTE------------");
            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Liste(musteri3);

            Console.WriteLine("-------------SİLME-------------");
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);


        }
    }
}
