using System;
using System.Collections.Generic;
using System.Text;

namespace engin1
{
    class MusteriManager
    {
        public void Ekle(musteri musteri)
        {
            Console.WriteLine("ID: " + musteri.Id + " Adı - Soyadı: " + musteri.Ad + musteri.Soyad + " olan müşteri sisteme eklenmiştir.");
            Console.WriteLine("-------******------******");
        }
        public void Listele(musteri[] musteri)
        {
            foreach (musteri musteritem in musteri)
            {

                Console.WriteLine("ID: " + musteritem.Id + " Adı - Soyadı: " + musteritem.Ad + musteritem.Soyad);

            }
            Console.WriteLine("-------******------******");
        }
        public void Sil(musteri musteri)
        {
            Console.WriteLine("ID: " + musteri.Id + " Adı - Soyadı: " + musteri.Ad  + musteri.Soyad + " olan müşteri sistemden silinmiştir.");

        }

    }
}
