namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu06Diziler");

            // Dizi Oluşturma
            // int[]  sayilar;
            int[] ogrenciler = new int[6]; // 6 elemanlı bir dizi  
            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 600;

            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            ogrenciler[5] = 700;
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);

            string[] isimler = new string[5]; // 5 elemanlı bir dizi
            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Ayşe";
            isimler[3] = "Fatma";
            isimler[4] = "Zeynep";

            Console.WriteLine("isimler[4]: " + isimler[4]);
            Console.WriteLine();

            int[] ogrenciler2 = { 90, 80, 70, 60, 50 }; // 5 elemanlı bir dizi
            Console.WriteLine();

            Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]);
            ogrenciler2[3] = 550;
            Console.WriteLine("Seçilen öğrenci no: " + ogrenciler2[3]);

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };
            Console.WriteLine("kategoriler1" + kategoriler[1]);
            kategoriler[1] = "Elektrikli Ev Aletleri";
            Console.WriteLine("kategoriler1" + kategoriler[1]);
            Console.WriteLine();
        }
    }
}
