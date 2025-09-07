namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("Merhaba, Dünya!");
            Console.WriteLine();
            Console.Write("Console.");
            Console.Write("Write");
            // Console.Read();
            // Console.ReadLine();

            byte plaka_kodu;
            plaka_kodu = 34;
            Console.WriteLine(plaka_kodu);

            byte birSayi, birSayiDaha;
            birSayi = 0;
            birSayiDaha = 255;
            Console.WriteLine(birSayi);
            Console.WriteLine(birSayiDaha);

            sbyte sbyteturu = 127;
            Console.WriteLine(sbyteturu);

            short kisa = 32767;
            ushort birazUzun = 65535;
            int tamsayi = 1234567890;
            uint uzuntamsayi = 1234567890;
            long dahauzuntamsayi = 1234567890000;
            ulong enuzuntamsayi = 1234567890000000000;

            float kesirliSayi = 4.5f;
            double kesirliSayi2 = 4.5;


            decimal UrunFiyati = 9999;

            char karakter = 'ç';

            string metin = "stirng veri tipi";
            Console.WriteLine(metin); // breakpoint.

            bool islemsonuc = false;
            islemsonuc = true;

            byte? kilo = null;

            var birdegisken = "dfdfhjd";
            var sonuc = false;

            Console.WriteLine(birdegisken.GetType());
            Console.WriteLine(sonuc.GetType());
            Console.WriteLine(metin);
            Console.WriteLine(metin.GetType());


            Console.WriteLine("Object Veri Tipi");
            object nesne = "bu bir nesnedir"; // Bu değişken türüne her türden veri atanabilir.
            Console.WriteLine(nesne + "-Tipi:" + nesne.GetType());
            nesne = 18;
            Console.WriteLine(nesne + "-Tipi:" + nesne.GetType());

            object a = 10; // tam sayı
            object b = 'k'; // karakter
            object c = "metin"; // string
            object d = 12.9f; // float

            Console.WriteLine(a.GetType());

            // c#'ta sabit tanımlama
            const int kdvorani = 20;

            Console.WriteLine(kdvorani);
            Console.WriteLine("Ekrandan değer alma:");
            var deger = Console.ReadLine();

            Console.WriteLine("Ekrandan girilen deger: " + deger);


            




        }
    }
}