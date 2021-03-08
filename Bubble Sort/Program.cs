using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] data)
        {
            bool needsSorting = true;

            for (int i = 0; i < data.Length - 1 && needsSorting; i++)
            {
                needsSorting = false;

                for (int j = 0; j < data.Length - 1 - i; j++)
                {

                    if (data[j] > data[j + 1])
                    {

                        needsSorting = true;

                        int tmp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = tmp;
                    }
                }


            }
        }

        static int[] GenerateData(int Storlek)
        {
            Random tal = new Random();
            int[] data = new int[Storlek];

            for (int i = 0; i < data.Length; i++)
                data[i] = tal.Next(data.Length);

            return data;
        }

        static void Main(string[] args)
        {
            int[] Storleks = new int[] { 10, 1000, 100000 };

            for (int i = 0; i < Storleks.Length; i++)
            {
                Console.WriteLine("Längden av Talet : " + Storleks[i]);
                int[] data = GenerateData(Storleks[i]);

                Console.WriteLine("Talen är sorterade");
                DateTime startTid = DateTime.Now;
                BubbleSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Sorteringstiden: {0:0.00} ms.\n", deltaTid.TotalMilliseconds);

            }
        }
    }
}
