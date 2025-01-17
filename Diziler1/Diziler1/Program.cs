using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] matris = new double[,]
            {
                {1,2,3 },
                {2,3,4 },
                {3,4,5 },
            };

            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                        matris[i, j] = -1;

                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;


                    toplam += matris[i, j];


                    Console.Write($"{matris[i,j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Toplam : {toplam} ");

            Console.ReadKey();
        }

        private static void DiziOrnegi1()
        {
            Console.WriteLine("Dizi boyutunu giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);

            foreach (int s in sayilar)
            {
                Console.WriteLine(s);
            }
        }
    }
}
