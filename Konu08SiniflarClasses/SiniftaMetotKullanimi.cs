using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08SiniflarClasses
{
    public class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        public SiniftaMetotKullanimi() // kurucu metot - constructor oluşturmanın kısayolu: ctor + tab + tab    
        {
            Console.WriteLine();
            kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştrır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı ad kullanılarak oluşturulur.";
            Console.WriteLine();
            Console.WriteLine(kurucuMetot);
        }

        public bool LoginKontrol(string kullaniciAdi, string sifre) 
        {
            if (kullaniciAdi == "admin" && sifre == "123456")
            {
                return true;
            }
                
            return false;

        }

        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static string StaticDegisken = "Static değişkenler sınıf adı ile çağrılırlar ve sınıfın her yerinden erişilebilirler.";
        public string DinamikDegisken = "Dinamik değişkenler ise sınıftan bir nesne oluşturulduktan sonra o nesne üzerinden erişilebilirler.";
    }
}
