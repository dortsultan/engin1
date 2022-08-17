using System;

namespace engin1
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager mManager = new MusteriManager();

            musteri Musteri1 = new musteri();
            Musteri1.Id = 11;
            Musteri1.Ad = "Kamil";
            Musteri1.Soyad = " ÖZEL";

            musteri Musteri2 = new musteri();
            Musteri2.Id = 10000002;
            Musteri2.Ad = "Orkun";
            Musteri2.Soyad = " DİNÇ";

            musteri Musteri3 = new musteri();
            Musteri3.Id = 1065663;
            Musteri3.Ad = "Özgür";
            Musteri3.Soyad = " DEMİRAY";

            musteri[] MusteriArray = new musteri[] { Musteri1, Musteri2, Musteri3 };

            mManager.Ekle(Musteri3);
            mManager.Listele(MusteriArray);
            mManager.Sil(Musteri2);



        }
    }
}
