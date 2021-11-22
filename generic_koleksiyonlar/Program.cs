using System;
using System.Collections.Generic;

namespace generic_koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilistesi = new List<int>();


            //Listeye Eleman Ekleme

            sayilistesi.Add(14);
            sayilistesi.Add(1);
            sayilistesi.Add(27);
            sayilistesi.Add(39);
            sayilistesi.Add(1);
            sayilistesi.Add(65);

            List<string> renkler = new List<string>();

            renkler.Add("kırmızı");
            renkler.Add("sarı");
            renkler.Add("mavi");
            renkler.Add("sarı");
            renkler.Add("turuncu");

            //Foreach ve List.ForEach kullanımı

            foreach (var sayi in sayilistesi)
            {
                Console.WriteLine(sayi);
                Console.WriteLine(sayilistesi[0]);

            }

            renkler.ForEach(x => Console.WriteLine(x));
            sayilistesi.ForEach(x => Console.WriteLine(x));

            //Liste.Count kullanımı
            Console.WriteLine(renkler.Count);
            Console.WriteLine(sayilistesi.Count);

            //List.Remove
            renkler.Remove("sarı");
            sayilistesi.Remove(1);
            renkler.ForEach(x => Console.WriteLine(x));
            sayilistesi.ForEach(x => Console.WriteLine(x));

            //List.RemoveAt(0) indexi belli olan sayıyı silme
            renkler.RemoveAt(0);
            sayilistesi.RemoveAt(0);
            renkler.ForEach(x => Console.WriteLine(x));
            sayilistesi.ForEach(x => Console.WriteLine(x));

            //Liste.Contains liste içinde arama, döüşü true
            if (sayilistesi.Contains(1))
                Console.WriteLine("1 aramada mevcut");

            if (renkler.Contains("sarı"))
                Console.WriteLine("sarı aramada mevcut");

            //Eleman ile indexe erişme List.BinarySearch
            Console.WriteLine(renkler.BinarySearch("sarı"));
            Console.WriteLine(renkler.BinarySearch("turuncu"));
            Console.WriteLine(renkler.BinarySearch("mavi"));

            //Diziyi listeye çevirme
            string[] hayvanlar = { "aslan", "kaplan", "fil" };
            List<string> hayvanlistesi = new List<string>(hayvanlar);
            hayvanlistesi.ForEach(x => Console.WriteLine(x));
            foreach (var x in hayvanlar)
            {
                Console.WriteLine(x);
            }
            //Liste temizleme List.Clear()
            hayvanlistesi.Clear();
            hayvanlistesi.ForEach(x => Console.WriteLine(x));
        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;

        private int yas;

    }
}
