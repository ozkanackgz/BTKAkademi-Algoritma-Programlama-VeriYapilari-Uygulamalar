using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    // Tanımlama
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)
        {
            Console.WriteLine("Otomatik Çalıştı.");
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; }   // Property - Özellik
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // struct - Kullanma
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 10;
            ogr.Adi = "Ahmet";
            ogr.Soyadi = "Yılmaz";
            ogr.Cinsiyet = true;

            // Alternatif Kullanma
            var ogr2 = new Ogrenci()
            {
                Numara = 20,
                Adi = "Fatma",
                Soyadi = "Dağ",
                Cinsiyet = false,

            };

            // Alternatif Kullanma2

            var ogr3 = new Ogrenci(30, "Mehmet", "Avşar", true);

            Console.WriteLine($"{ogr.Numara} " + $"{ogr.Adi} {ogr.Soyadi} " + $"{ogr.Cinsiyet}");
            Console.WriteLine($"{ogr2.Numara} " + $"{ogr2.Adi} {ogr2.Soyadi} " + $"{ogr2.Cinsiyet}");
            Console.WriteLine($"{ogr3.Numara} " + $"{ogr3.Adi} {ogr3.Soyadi} " + $"{ogr3.Cinsiyet}");

            Console.ReadKey();
        }
    }
}
