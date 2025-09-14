namespace Konu08SiniflarClasses
{
    internal class Program
    {

        internal class Ev
        {
            // Sınıf içerisindeki değişkenler
            internal string sokakAdi;
            internal int kapiNo;
        }

        public class deneme
        {
            // Sınıf içerisindeki değişkenler
            public string urunAdi = "public oge herkes erişebilir.";
            protected class test
            {
                // Sınıf içerisindeki değişkenler
                string urunAdi= "";
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08Sınıflar Classes");
            /*
             Erişim belirteçleri 4 ana sınıfa ayrılır.
                1- Public : Erişim kısıtı yoktur. Her yerden erişilebilir.
                2- Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
                3- Internal : Sadece bulunduğu proje içerisinden erişilebilir.
                4- Protected : Sadece tanımlandığı sınıf ve o sınıftan türeyen sınıflardan erişilebilir.


             */

            Ev ilkEV = new Ev();
            ilkEV.sokakAdi = "Yıldız";
            ilkEV.kapiNo = 34;
            Console.WriteLine($"İlkEv sokak adi = {ilkEV.sokakAdi}");
            Console.WriteLine($"İlkEv kapi no = {ilkEV.kapiNo}");
        }
    }
}
