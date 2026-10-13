using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT
{
    internal class Buoi7
    {
        public static void BaiTap01()
        {
            string[][] names = new string[3][];

            names[0] = new string[1] { "Vien" };

            names[1] = new string[2];

            names[2] = new string[] { "Khanh", "Nhan", "Tung" };

            int[][] jaggedArray = {

                new int[] { 1, 2, 3 },

                new int[] { 100 },

                new int[] { 4, 5, 6 }
            };


        }
        static void TaoMangV2(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void InMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
