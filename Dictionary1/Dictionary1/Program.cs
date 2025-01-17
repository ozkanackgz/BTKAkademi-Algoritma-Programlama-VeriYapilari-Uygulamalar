using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsöz",7500)},
                {120, new Personel("Ahmet","Can",9000)}
            };

            personelListesi.Add(100, new Personel("Zeynep","Coşkun",5000));
            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }

        private static void DictionaryTemelleri()
        {
            // Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332, "Konya"},
                {424, "Elazığ"},
                {466, "Art"},

            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            // Erişme
            telefonKodlari[466] = "Artvin";

            // ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi. ");
            }

            // ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }

            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
