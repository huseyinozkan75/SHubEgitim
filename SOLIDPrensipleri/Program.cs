namespace SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Prensipleri");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek, yeniden kullanılabilir, " +
                "sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("S - Single Responsibility(Tek Sorumluluk Prensibi)");
            Console.WriteLine("\t 1 sınıf veya metodun sadece 1 sorumluluğunun olması gerekir.");

            Console.WriteLine("O - Open-Closed Principle");
            Console.WriteLine("\t Bir sınıf ya da metot var olan özelliklerini korumalı değişikliğe izin vermemelidir.");
            Console.WriteLine("L - Liskov Substitution Principle");
            Console.WriteLine("Kodlarımızda herhangi bir değişiklik yapmaya gerek olmadan alt sınıfları türedikleri" +
                "üst sınıfların yerine kullanabilmeliyiz.");
            Console.WriteLine("I - Interface Segregation Principle");
            Console.WriteLine("Sorumlulukların hepsini tek bir arayüzde toplamak yerine özelleştirilmiş birden fazla arayüz kullanmalıyız.");
            Console.WriteLine("D - Dependency Inversion Principle");
            Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. Özellikle üst seviye sınıflar" +
                " alt seviye sınıflara bağlı olmamalıdır. ");


        }
    }
}
