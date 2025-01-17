using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedSet Küme İşlemleri
            // var A = new SortedSet<int>() {1,2,3,4};
            var A = new SortedSet<int>(RastgeleSayiUret(10));
            // var B = new SortedSet<int>() {1,2,5,6};
            var B = new SortedSet<int>(RastgeleSayiUret(3));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion 

            // Union
            
            // A.UnionWith(B);
            // A.IntersectWith(B);
            // A.ExceptWith(B);
            // A.IsSubsetOf(B)
            A.SymmetricExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\n\n kesisim disindaki elemanlar");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("\ntoplam sayisi : {0}",A.Count);
            Console.ReadKey();
        }

        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 10));
            return list;
        }

        private static void SortedSetOrnek()
        {
            // SortedSet
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanlari bulmak
            var benzersizSayiListesi =
                new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("Benzersiz {0} sayi var. ",
                benzersizSayiListesi.Count);
            Console.ReadKey();
        }
    }
}
