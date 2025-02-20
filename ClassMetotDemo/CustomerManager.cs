﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine(musteri.Ad + " Eklendi ");
        }
        public void List(Customer[] musteriler)
        {
            foreach (Customer item in musteriler)
            {
                Console.WriteLine(string.Format("Müşteri id:{0} - Müşteri Adı: {1} - MüşteriSoyadı:{2} ", item.id, item.Ad, item.Soyad));
            }
        }
        public void Delete(Customer musteri)
        {
            Console.WriteLine(string.Format("Silenen müşteri bilgileri -- Musteri Id:{0} Adı:{1} - Soyadı:{2} ", musteri.id, musteri.Ad, musteri.Soyad));
        }
    }
}
