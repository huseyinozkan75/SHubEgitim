namespace Konu11Enumlar
{
    internal class Program
    {

        enum Aylar: byte // byte, sbyte, short, ushort, int, uint, long veya ulong olabilir. Koleksiyondaki numaraların veri tipini belirler.
        {
            Ocak=1,
            Subat,
            Mart,
            Nisan,
            Mayis,
            Haziran,
            Temmuz,
            Agustos,
            Eylul,
            Ekim,
            Kasim,
            Aralik
        }

        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı
        }

        enum Meyveler : int
        {
            Elma = 3, Armut = 7, Çilek = 1

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu11Enumlar");
            // Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
            /*
            * Enum tipler üzerindeki kısıtlar
            * 1-Enum blokunda metot tanımlanamaz
            * 2-Arayüz(Interface) kullanamazlar
            * 3-enum blokunda property kullanılmaz
            */

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;

            Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma}={b}, {Meyveler.Çilek}={c}");

            Ornek1(SiparisDurum: 1);
            Ornek1(3);


        }

        static void Ornek1(int SiparisDurum)
        {
            if (SiparisDurum == (int) SiparisDurumu.Hazırlanıyor)
            {
                Console.WriteLine("Siparişiniz hazırlanıyor.");
            }
            else if (SiparisDurum == (int) SiparisDurumu.Hazırlandı)
            {
                Console.WriteLine("Siparişiniz hazırlandı.");
            }
            else if (SiparisDurum == (int) SiparisDurumu.KargoBekleniyor)
            {
                Console.WriteLine("Siparişiniz kargo bekleniyor.");
            }
            else if (SiparisDurum == (int) SiparisDurumu.Kargolandı)
            {
                Console.WriteLine("Siparişiniz kargolandı.");
            }
        }


    }
}
