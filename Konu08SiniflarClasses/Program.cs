namespace Konu08SiniflarClasses
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
    }
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
                string urunAdi = "";
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

            #region Örnek 5
            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("admin", "123456");
            if (sonuc) // if de bu sekilde kullanırsak sonuc == true yu kontrol eder.
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else 
            {
                Console.WriteLine("Giriş Başarısız!");
            }

            var toplamSonuc = metotKullanimi.ToplamaYap(10, 8);
            Console.WriteLine("Statik Degisken: " +  SiniftaMetotKullanimi.StaticDegisken); // static degiskenler sınıf adı sınıfadi.sınıfdediskeni ile çağrılır.
            Console.WriteLine("Dinamik Degisken: " + metotKullanimi.DinamikDegisken);

            #endregion

            #region Ornek6
            User user = new()
            {
                Id = 1,
                CreateDate = DateTime.Now,
                Email = "admin@user.co",
                Password = "123456"
            };


            var KullaniciGirisSonuc = user.KullaniciGiris(user.Email, user.Password);
            Console.WriteLine("KullaniciGirissonuc = " + KullaniciGirisSonuc);
            #endregion
        }


    }
}
