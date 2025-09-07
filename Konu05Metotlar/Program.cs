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
        }

        static void ToplamaYap(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
        }

        static int  ToplamaYap(int sayi1, int sayi2, int sayi3) {
            return sayi1 + sayi2 + sayi3;
        }
    }
}
