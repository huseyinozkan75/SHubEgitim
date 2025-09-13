namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu05Metotlar");
            Console.WriteLine();

            ToplamaYap(10, 20);
            int sonuc = ToplamaYap(10, 20, 30);
            Console.WriteLine("Hesaplanmış Fiyat: " + sonuc);

            Console.WriteLine();
            Console.WriteLine("Mail adresiniz: ");
            var email = Console.ReadLine();

            var mailGonderildimi = MailGonder(email);

            if (mailGonderildimi == true)
            {
                Console.WriteLine("Mail gönderildi.");
            }
            else
            {
                Console.WriteLine("Mail gönderilemedi.");
            }
        }

        static void ToplamaYap(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
        }

        static int  ToplamaYap(int sayi1, int sayi2, int sayi3) 
        {
            return sayi1 + sayi2 + sayi3;
        }

        static bool MailGonder(string mailAdresi)
        {
            if (!string.IsNullOrWhiteSpace(mailAdresi))
            {
                return true;
            }

            return false;
        }
    }
}
