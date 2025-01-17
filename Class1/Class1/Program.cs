using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{

    public class OgretimElemani
    {
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        public OgretimElemani() 
        {
            
        }

        public OgretimElemani(int sicilno, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilno;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public override string ToString()
        {
            return $"{SicilNo,-5} " + $"{Adi,-10} " + $"{Soyadi,-10} "
                + string.Format("{0, -8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var liste1 = new List<OgretimElemani>()
                {
                   new OgretimElemani(100, "Ahmet", "Yalçın", true),
                   new OgretimElemani(101, "Aylin", "Dağ", false),
                   new OgretimElemani(102, "Mehmet", "Yıldız", true),
                   new OgretimElemani(103, "Servet", "Aydoğdu", true),
                   new OgretimElemani(104, "Leyla", "Aydın", false),
                   new OgretimElemani(105, "Selim", "Asilhan", true)

                };

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr  => Console.WriteLine(ogr));
            Console.WriteLine();

            var liste2 = liste1;
            Console.WriteLine("Liste 2");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
