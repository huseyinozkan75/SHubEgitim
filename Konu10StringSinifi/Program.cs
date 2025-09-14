using System.Net.WebSockets;

namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter = 'a';
            string metinlericin = "yanyana karakterlerden oluşan veri tipidir.";
            // Ornek1();
            // StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfgd\n";//buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For döngüsü");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]); // s değişkeninin i. indexteki  karakterini yazdırır.
            }

            Console.WriteLine("Forach döngüsü");
            foreach (var item in s)
            {
                Console.WriteLine(item); // s değişkeninin içindeki tüm karakterleri tek tek yazdırır.
            }

        }
        static void StringMetotlari()
        {
            string metin = "Stringin birçok metodu vardır";
            Console.WriteLine("metinin karakter sayısı(metin.length)" + metin.Length);

            var klon = metin.Clone(); // metin değişkeninin bir kopyasını oluşturur.
            Console.WriteLine("metnin klonu: " + klon);
            Console.WriteLine();

            metin = "My name is Ali";
            Console.WriteLine(metin + " EndsWith i: " + metin.EndsWith("i"));
            Console.WriteLine(metin + " EndsWith r: " + metin.EndsWith("r"));
            Console.WriteLine();

            Console.WriteLine(metin + " StartsWith S: " + metin.StartsWith("S"));
            Console.WriteLine(metin + " StartsWith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + " StartsWith M: " + metin.StartsWith("M"));

            Console.WriteLine();


            Console.WriteLine(metin + "Index of name" + metin.IndexOf("name"));
            Console.WriteLine(metin + "Index of Name" + metin.IndexOf("Name"));
            Console.WriteLine(metin + "LastIndex of i" + metin.LastIndexOf("i"));
            Console.WriteLine();

            Console.WriteLine(metin + " Insert 0" + metin.Insert(0, "Merhaba: "));
            Console.WriteLine(metin);
            Console.WriteLine();
            Console.WriteLine(metin + "Substring 2: " + metin.Substring(2));
            Console.WriteLine(metin + "Substring 2, 5:" + metin.Substring(2, 5));
            Console.WriteLine();

            Console.WriteLine(metin + " ToLower: " + metin.ToLower() );
            Console.WriteLine(metin + " ToUpper: " + metin.ToUpper() );
            Console.WriteLine(metin + "metin.Tolower().Replace: " + metin.ToLower().Replace(" ", "-"));

            Console.WriteLine(metin + " Remove 2: " + metin.Remove(2));
            Console.WriteLine(metin + " Remove 2, 5: " + metin.Remove(2, 5));




        }

        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Bursa,Adana,Antalya,Çankırı";
            string[] sehirlerArray = sehirler.Split(','); // virgül karakterine göre parçala ve diziye at
            Console.WriteLine("4. Şehir: " + sehirlerArray[3]);

            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir: " + item);
            }

            Console.WriteLine();
        }
    }
}
