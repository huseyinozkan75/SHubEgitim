namespace Konu08SiniflarClasses
{
    public class Urun
    {
        // class içinde değişken-field kullanımı
        internal int Id;
        internal string Adi;
        internal decimal Fiyati;

        // class içinde property kullanımı
        public string UrunAciklamasi { get; set; } // property oluşturmanın kısayolu: prop + tab + tab
        public string Markasi { get; set; }
        public  bool Durum { get; set; }
        public  int  KategoriID{ get; set; }

        public Kategori? Kategori { get; set; } // 

    }
}
