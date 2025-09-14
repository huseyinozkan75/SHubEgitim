using System.Security.Cryptography.X509Certificates;

namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;

        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }


    class Otomobil : Arac // iki nokta üstüste araç dediğimizde araç sınıfında içerikler otomobil sınıfında kullanılabilir
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }

    class Tren : Arac
    {
        public string Model { get; set; }
        public string VagonSayisi { get; set; }
    }

    class Gemi : Arac
    {
        public string Uzunluk { get; set; }
        public string KamaraSayisi { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance");

            Arac arac1 = new();

            arac1.AracTuru = string.Empty;
            arac1.KornaCal();


            Otomobil oto1 = new();
            oto1.AracTuru = "Otomobil"; // Arac sınıfından gelen özellik
            oto1.Marka = "TOGG";
            oto1.Model = "T10x";
            Console.WriteLine("oto1.aracturu: " + oto1.AracTuru);
            oto1.KornaCal(); // KornaCal metodu Arac sınıfından geldi.

            Console.WriteLine();
            Kategori kategori = new()
            {
                ID = 1,
                Name = "Elektronik",
                UstMenudeGoster = true
            };

            if (kategori.UstMenudeGoster)
            {
                Console.WriteLine(kategori.Name);
            }

            Console.WriteLine();

            Urun urun = new()
            {
                ID = 1,
                Name = "Telefon",
                Fiyat = 15000,
                Kdv = 20,
            };

            Console.WriteLine("Ürün Açıklamalari: ");
            Console.WriteLine($"Ürün Adı: {urun.Name}, Fiyat: {urun.Fiyat}");

            // Polimorfizm - Çok biçimlilik

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz(); // her bir nesne kendi Ciz metodunu çağırır.
            }
        }

        public class Cizici
        {
            public virtual void Ciz() // virtual anahtar kelimesi bu metodun override edilebileceğini belirtir.
            {
                Console.WriteLine("Çizici...");
            }
        }

        public class DogruCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde base sınıfın metodunu çağırır.
            {
                Console.WriteLine("Doğru çizildi.");
                // base.Ciz(); // base anahtar kelimesi base sınıfı temsil eder.
            }

        }

        public class DaireCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde base sınıfın metodunu çağırır.
            {
                Console.WriteLine("Daire çizildi.");
                // base.Ciz(); // base anahtar kelimesi base sınıfı temsil eder.
            }
        }

        public class KareCiz : Cizici
        {
            public override void Ciz() // override boşluk dediğimizde base sınıfın metodunu çağırır.
            {
                Console.WriteLine("Kare çizildi.");
                // base.Ciz(); // base anahtar kelimesi base sınıfı temsil eder.
            }
        }

    }
}
