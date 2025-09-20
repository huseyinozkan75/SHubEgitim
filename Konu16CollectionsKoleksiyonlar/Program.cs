using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.WebSockets;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu16-Collections-Koleksiyonlar");
            // Ornek1();
            // Ornek2();
            // Ornek3();
            // Ornek4();
            Ornek5();
        }
        static void Ornek1()
        {
            // ArrayList
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("İki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            arrayList.Add('A');
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine( "Arraylist ilk eleman: " + arrayList[0]); // listede ilk elemana erişim.



            //Console.WriteLine("ArrayList Count: " + arrayList.Count);
            //Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity);
            //arrayList.Remove(3.14);
            //arrayList.RemoveAt(0);
            //Console.WriteLine("ArrayList Count after removal: " + arrayList.Count);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
        }

        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("istanbul");
            arrayList.Add("ankara");
            arrayList.Add("izmir");
            arrayList.Add("bursa");
            arrayList.Add("antalya");
            arrayList.Add("adana");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList de sıralama yapabiliriz");
            arrayList.Sort(); // a-z sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList de tersten sıralama");
            arrayList.Reverse(); // tersten sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }

        static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("istanbul");
            strings.Add("ankara");
            strings.Add("izmir");
            // strings.Add(34); // StringCollection sadece string veri tipi alır.
            Console.WriteLine("String Collection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }



        }

        static void Ornek4()
        { 
            var dictionary = new StringDictionary();

            dictionary.Add("istanbul", "34");
            dictionary.Add("ankara", "06");
            dictionary.Add("izmir", "35");
            dictionary.Add("bursa", "16");
            dictionary.Add("antalya", "07");
            dictionary.Add("adana", "01");

            Console.WriteLine();

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("dictionary.Keys");

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            Console.WriteLine("dictionary.Values");

            foreach (var value in dictionary.Values)
            {
                Console.WriteLine("Value: " + value);
            }




        }
        static void Ornek5()
        {
            Dictionary<string, string> dictionary = new(); // hangi veri tipinden oluşacağını bizim
                                                           // belirlediğimiz liste sistemi.
            dictionary.Add("book", "kitap");
            dictionary.Add("18", "çankırı");
            dictionary.Add("34", "istanbul");
            Console.WriteLine(dictionary["book"]);

            Dictionary<int, string> dictionary2 = new(); // hangi veri tipinden oluşacağını bizim
                                                           // belirlediğimiz liste sistemi.
            dictionary2.Add(1, "Adana");
            dictionary2.Add(18, "Çankırı");
            dictionary2.Add(34, "İstanbul");

            Console.WriteLine();

            Console.WriteLine("dictionary2 values");

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();


            Console.WriteLine("dictionary2 keys");

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }

        }

    }
}
