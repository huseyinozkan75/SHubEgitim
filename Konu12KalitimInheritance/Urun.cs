
namespace Konu12KalitimInheritance
{
    public class Urun : OrtakOzellikler
    {
        public string? TeknikOzellikler { get; set; } // soru işareti null olabilir anlamında
        public decimal Fiyat { get; set; }
        public int Kdv { get; set; }
        public int Iskonto  { get; set; }
    }
}
