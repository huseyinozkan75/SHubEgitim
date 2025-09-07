using System.Net.WebSockets;

namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu04 Karar Yapıları!");
            /*
            Console.WriteLine("Bir Sayı Giriniz: ");

            var sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0) // eğer sayı 0'dan büyükse 
            {  
                Console.WriteLine("Sayı Pozitif");
            }
            else if (sayi < 0) // eğer sayı 0'dan küçükse
            { 
                Console.WriteLine("Sayı Negatif"); 
            }
            else
            {
                Console.WriteLine("Sayı sıfır");
            }
            */

            /*
            Console.WriteLine("Kullanıcı Adını Giriniz: ");
            string kullaniciAdi =  Console.ReadLine(); 
            
            Console.WriteLine("Şifrenizi Giriniz: ");
            string sifre =  Console.ReadLine(); 

            if (kullaniciAdi == "admin" && sifre == "gamer12")
            {
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine("Hoşgeldin Pusat");
            } else
            {
                Console.WriteLine("Giriş Başarısız");
                Console.WriteLine("Kullanıcı adı veya şifrenizi kontrol ederek tekrar deneyiniz!");
            }

            */

            int saat = DateTime.Now.Hour;
            if (saat < 18)
            {
                Console.WriteLine("İyi günler, saat: " + saat); // birden fazla kod satırı yazacaksak 
                // süslü parantez içerisine yazıyoruz.
            }
            else 
            {
                Console.WriteLine("İyi akşamlar, saat: " + saat); // tek satır yazacaksak süslü paramtez 
                // kullanmayabiliriz.
            }

            Console.WriteLine("switch case yapısı ile akış kontrolü");
            int ay = DateTime.Now.Month;

            switch (ay) // ay değişkeninin değerini kontrol et.
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ");
                    break;
                default:
                    Console.WriteLine("Hata oluştu!");
                    break;
            }





        }
    }
}
