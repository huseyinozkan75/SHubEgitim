namespace Konu14InterfacesArayuzler
{
    internal class Program
    {
        public interface IOrnekArayuz // class yerine interface yazıyoruz
        {
            public int Id { get; set; }
        }

        interface IDemo
        {
            void Goster(); // interface içinde gövdesiz metot tanımlanır
        }

        interface icerebilecekleri:IDemo // interface başka bir interface'i miras alabilir
        {
            public int sayi1 { get; set; }
            public int sayi { get; set; }
            public static int sayi2{ get; set; }

            void Topla();
            int ToplamaYap();
        }

        class ArayuzKullanimi : icerebilecekleri // interface'i miras alıyoruz
        {
            public int sayi1 { get; set; }
            public int sayi { get; set; }

            public void Goster()
            {
                Console.WriteLine("Void Göster Metodu");
            }

            public void Topla()
            {
                Console.WriteLine("Void Topla Metodu");
            }

            public int ToplamaYap()
            {
                Console.WriteLine("Int ToplamaYap Metodu");
                return sayi + sayi1;
            }

            public int Id { get; set; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Konu14InterfacesArayuzler");
            ArayuzKullanimi arayuzKullanimi = new ArayuzKullanimi();
            arayuzKullanimi.sayi = 5;
            arayuzKullanimi.sayi1 = 10;
            arayuzKullanimi.Goster();
            arayuzKullanimi.Topla();
            Console.WriteLine("Toplama sonucu: " + arayuzKullanimi.ToplamaYap());

            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Bilgisayar",
                Aciklama = "Bilgisayar ile ilgili ürünler",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            Console.WriteLine($"Kategori Id: {kategori.Id}, Create Date = {kategori.CreateDate}" +
                $", UpdateDate = {kategori.UpdateDate}");
        }
    }
}
