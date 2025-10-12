namespace Konu08SiniflarClasses
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
    }

    internal class Ev
    {
        // Sınıf içerisindeki değişkenler
        internal string sokakAdi;
        internal int kapiNo;
    }

    public class deneme
    {
        // Sınıf içerisindeki değişkenler
        public string urunAdi = "public öğeye herkes erişebilir.";
        protected class test // Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.  
        {
            // Sınıf içerisindeki değişkenler
            string urunAdi = "";
        }
    }
    internal class Program
    {
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

            #region Örnek1

            Ev ilkEV = new Ev(); // soyut bir yapı olan ev sınıfından somut bir nesne olan ilkEv'i oluşturduk.
            ilkEV.sokakAdi = "Yıldız";
            ilkEV.kapiNo = 34;
            Console.WriteLine($"İlkEv sokak adi = {ilkEV.sokakAdi}");
            Console.WriteLine($"İlkEv kapi no = {ilkEV.kapiNo}");

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "Deniz";
            yazlikEv.kapiNo = 42;
            Console.WriteLine($"Yazlık Ev sokak adi = {yazlikEv.sokakAdi}");
            Console.WriteLine($"Yazlık Ev kapi no = {yazlikEv.kapiNo}");

            Ev koyEvi = new()
            {
                kapiNo = 43,
                sokakAdi = "Mehmet Ağa sok"
            };

            Console.WriteLine($"Köyevi sokak adi = {koyEvi.sokakAdi}");
            Console.WriteLine($"Köyevi kapi no = {koyEvi.kapiNo}");
            #endregion

            #region Örnek2
            Kullanici kullanici = new()
            {
                Adi = "Hüseyin",
                Soyadi = "Özkan",
                Id = 1,
                KullaniciAdi = "hozkan",
                Sifre = "hozkan123"
            };

            Console.WriteLine("Kullanıcı Adı: ");
            var kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Sifre: ");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else 
            {
                Console.WriteLine("Giriş Başarısız!");
            }

            #endregion

            #region Örnek3
            Araba araba = new() { 
                Id = 1,
                Model = "Astra"
,
            };
            #endregion

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
            Console.WriteLine("Statik Degisken: " + SiniftaMetotKullanimi.StaticDegisken); // static degiskenler sınıf adı sınıfadi.sınıfdediskeni ile çağrılır.
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

        class Kullanici
        {
            internal int Id;
            internal string KullaniciAdi;
            internal string Sifre;
            internal string Email;
            internal string Adi;
            internal string Soyadi;
        }

        class Araba 
        {
            internal int Id;
            internal string Marka;
            internal string Model;
            internal string KasaTipi;
            internal string YakitTipi;
            internal string VitesTipi;
            internal string Renk;
        }


    }
}
