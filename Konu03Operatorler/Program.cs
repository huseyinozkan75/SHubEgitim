namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03 Operatörler!");
            Console.WriteLine("1-Aritmetik Operatörler");
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi1 = {sayi1} sayi2 = {sayi2} sayi3 = {sayi3}"); // string tırnağın
            // önüne $ işareti koyarak string interpolasyonu yapıyoruz. 
            Console.WriteLine("1234" + sayi3); // string ile int arasında + işlemi yapıldığında toplama yerine 
            // birleştirme işlemi yapılır.
            Console.WriteLine();
            Console.WriteLine("Hesaplama İşlemleri: ");
            Console.WriteLine("sayi1 + sayi2 = " + (sayi1 + sayi2));
            Console.WriteLine("sayi1 - sayi2 = " + (sayi1 - sayi2));
            Console.WriteLine("sayi1 * sayi2 = " + (sayi1 * sayi2));
            Console.WriteLine("sayi1 / sayi2 = " + (sayi1 / sayi2));
            Console.WriteLine("sayi1 % sayi2 = " + (sayi1 % sayi2));
            
            Console.WriteLine();
            Console.WriteLine("Artırım ve Azaltım Operatörleri");
            sayi2++; // Değişken değerini artırır.
            Console.WriteLine("sayi2: " + sayi2);
            sayi2--; // değişken değerini azaltır
            Console.WriteLine("sayi2: " + sayi2);
            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri");
            Console.WriteLine("sayi1 += sayi2 = " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2 = " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2 = " + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2 = " + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2 = " + (sayi1 %= sayi2));
            Console.WriteLine();
            Console.WriteLine("İlişkisel Operatörler"); // Birden fazla değeri karşılaştırıp 
                                                        // aralarındaki durumu öğrenmek için kullanırız.

            Console.WriteLine($"Sayılar sayi1 = {sayi1} sayi2 = {sayi2} sayi3 = {sayi3}");
            Console.WriteLine("sayi1 == sayi2: " + (sayi1 == sayi2));
            Console.WriteLine("sayi1 != sayi2: " + (sayi1 != sayi2));
            Console.WriteLine("sayi1 > sayi2: " + (sayi1 > sayi2));
            Console.WriteLine("sayi1 < sayi2: " + (sayi1 < sayi2));
            Console.WriteLine("sayi1 >= sayi2: " + (sayi1 >= sayi2));
            Console.WriteLine("sayi1 <= sayi2: " + (sayi1 <= sayi2));
            Console.WriteLine();
            Console.WriteLine("Ternary Operatörü"); // eğer karşılaştırma için 2 değer kullanılacaksa
            // karşılaştırmanın kısayolu olarak kullanabiliriz.
            Console.WriteLine("Ternary. " + ((sayi1 == sayi2) ? $"sayi1({sayi1}) sayi2({sayi2}) ye esit " : 
                $"sayi1({sayi1}) sayi2({sayi2}) ye esit değil"));

            Console.WriteLine();
            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & operatörü");
            Console.WriteLine("& operatörü her iki şartın da sağlanmasını ister.");
            Console.WriteLine("(sayi1 == sayi2) && (sayi1 < sayi2): " + ((sayi1 == sayi2) && (sayi1 < sayi2)) );

            Console.WriteLine("Veya || operatörü");
            Console.WriteLine("|| operatörü her iki şarttan birinin sağlanmasını ister.");
            Console.WriteLine("(sayi1 == sayi2) || (sayi1 < sayi2): " + ((sayi1 == sayi2) || (sayi1 < sayi2)));
            Console.WriteLine();







        }
    }
}
