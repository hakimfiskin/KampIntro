using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati + " TL");
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Kırmızı Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Kırmızı Karpuz", 32, 132);
        }
    }
}
