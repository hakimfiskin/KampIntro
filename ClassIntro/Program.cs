using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Hakim Fışkın";
            kurs2.IzlenmeOrani = 95;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Betül Ürkmez";
            kurs3.IzlenmeOrani = 83;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = ".NET";
            kurs4.Egitmen = "Selim Fışkın";
            kurs4.IzlenmeOrani = 76;

            //Console.WriteLine(kurs1.KursAdi + " by " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " by " + kurs.Egitmen + " (%" + kurs.IzlenmeOrani + " Tamamlandı)" );
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
