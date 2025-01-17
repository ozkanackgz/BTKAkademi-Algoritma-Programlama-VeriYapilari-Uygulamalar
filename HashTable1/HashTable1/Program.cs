using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // baslik okuma
            Console.WriteLine("Başlık Giriniz : ");
            string baslik = Console.ReadLine(); 

            // kucultme
            baslik = baslik.ToLower();

            // HashTable
            var karakterseti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'/','-'},
                {'ğ','g'},
                {'.','-'},
            };

            foreach (DictionaryEntry item in karakterseti)
            { 
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            // ekranda yazdır
            Console.WriteLine(baslik);
            Console.ReadKey();
        }
    }
}
