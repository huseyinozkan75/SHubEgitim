using System.Net.WebSockets;

namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07 Döngüler");
            Console.WriteLine("1- For döngüsü:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"i değişkeninin değeri : {i} ");
            }

            Console.WriteLine("2- While döngüsü:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"j değişkeninin değeri : {j} ");
                j++;
            }

            Console.WriteLine("3- Do & While döngüsü:");
            int toplam = 7;
            do {
                Console.WriteLine($"toplam değişkeninin değeri : {toplam}");
                toplam--;
            } while (toplam < 5) ;



            Console.WriteLine("3-Foreach döngüsü");
            string[] kategoriler = { "Bilgisayar", "Telefon", "Tablet" };
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
