using System.Net.WebSockets;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17HataYonetimi: ");
            Console.WriteLine();
            Console.WriteLine("Kdv hesaplamak için fiyat giriniz: ");
            var fiyat = Console.ReadLine();
            // KDVHesapla(double.Parse(fiyat));

            try // try yaz 2 kere tab'a bas
            {
                KDVHesapla(double.Parse(fiyat)); // try bloğunda bulunan kodların çalıştırılması denenir.
                                                 // Bir hata oluşursa catch bloğuna atlar.
            }
            catch (Exception hata)                   // catch bloğunda hata yakalanır ve burada işlenir.
            {
                Console.WriteLine("Hata oluştu. Lütfen sadece sayısal değer giriniz!");
                // throw;  // throw hata fırlatır.
                // oluşan hatayı veritabanına loglama  ve kullanıcıya mail atma gibi işlemler burada yapılabilir.
                Console.WriteLine(hata.Message); // hata mesajını gösterir.
            }
            finally
            {
                Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa " +
                    "bu blokta çalıştıabiliriz. Kullanımı zorunlu değildir."); // finally bloğu her durumda çalışır.
                Console.WriteLine("Kdv hesaplamak için fiyat giriniz: ");
                var fiyat2 = Console.ReadLine();
                KDVHesapla(double.Parse(fiyat2));
            }


        }

        static void KDVHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat: " + fiyat);
            Console.WriteLine("Kdv: " + (fiyat * 0.20));
            Console.WriteLine("Kdv dahil toplam tutar: " + (fiyat + (fiyat * 0.20)));
        }
    }
}
