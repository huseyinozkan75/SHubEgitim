namespace Konu09StructYapilar
{
    public struct Yapi
    {
        // public string ad = "ali"; // struct kulanımında class ta olduğu gibi değişkenlere başlangıç değeri atayamayız.

        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09 Struct Yapılar");
            Yapi ilkyapi = new Yapi(); // struct yapılarında new anahtar kelimesi ile nesne oluşturmak zorundayız.
            ilkyapi.sayi = 10;
            ilkyapi.metin = "Yapi Metni";
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);
        }
    }
}
