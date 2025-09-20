namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum 
    {
        private string BolumAdi; // dışarıdan erişilemez

        public string GetBolumAdi() // getter metodu
        {
            return BolumAdi;
        } // Geriye private BolumAdi değişkenini döndüren metot.

        public void SetBolumAdi(string istenenEgitim) // setter metodu
        {
            if (istenenEgitim == "Grafik Tasarim")
            {
                Console.WriteLine("Kurumumuzda " + istenenEgitim + " Eğitimi Verilmemektedir!");
            }
            else
                BolumAdi = istenenEgitim; // Mutator (setter) seçilen eğitimi BolumAdi değişkenine atar. Seçilen eğitim onaylandı.

        } // dışarıdan BolumAdi değişkenine değer atamak için metot.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13KapsüllemeEncapsulation");

            Bolum bolum = new Bolum();
            Console.WriteLine("Eğitim almak istediğiniz bölümü giriniz: ");
            var bolumAdi = Console.ReadLine();

            // Metot ile kapsülleme
            Console.WriteLine("Metot ile Kapsülleme");
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Seçtiğiniz bölüm: " + bolum.GetBolumAdi());

            // Property ile kapsülleme
            Console.WriteLine();
            Console.WriteLine("Property ile kapsülleme");
            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = bolumAdi; // set bloğu çalışır
            Console.WriteLine("Seçtiğiniz bölüm: " + fakulte.Bolum); // get bloğu çalışır

        }
    }

    public class Fakulte
    {
        private string bolum;
        public string Bolum
        { 
            get 
            { 
                return bolum; 
            }
            set 
            {
                if (value == "Grafik Tasarim")
                {
                    Console.WriteLine("Kurumumuzda " + value + " Eğitimi Verilmemektedir!");
                }
                else
                    bolum = value;
            } 

        }

    }
}
