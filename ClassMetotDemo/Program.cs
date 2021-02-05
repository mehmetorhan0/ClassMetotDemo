using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sonuc;
            Customer musteri;
            CustomerManager customermanager;
            Customer[] musteriler = new Customer[] { };
            int i = 0;
            do
            {
                musteri = new Customer();
                musteri.id = i + 1;
                Console.Write("Müşteri Adı:");
                musteri.Ad = Console.ReadLine();
                Console.Write("Müşteri Soyadı:");
                musteri.Soyad = Console.ReadLine();

                customermanager = new CustomerManager();
                customermanager.Ekle(musteri);
                Array.Resize(ref musteriler, musteriler.Length + 1);
                musteriler[i] = musteri;

                i++;
                Console.Write("Başka müşteri var mı? Evet/Hayır: ");
                sonuc = Console.ReadLine().ToLower();

            } while (sonuc == "evet");
            Console.WriteLine("Ekleme Bitti");

            Console.Write("Müşteriler Listelensin mi? Evet/Hayır : ");
            string listSonuc = Console.ReadLine().ToLower();

            if (listSonuc == "evet")
            {
                customermanager.Listele(musteriler);
            }
            Console.Write("Silmek istediğiniz müşterinin adını giriniz:");
            var silmusteri = Console.ReadLine();
            for (int x = 0; x < musteriler.Length; x++)
            {
                if (musteriler[x].Ad == silmusteri)
                {
                    Customer SilenecekMusteri = musteriler[x];
                    customermanager.Sil(SilenecekMusteri);
                }
            }
        }
    }
}
