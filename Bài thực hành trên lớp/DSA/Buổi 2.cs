using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DSA
{
    internal class Buoi2
    {
        public interface HinhHoc
        {
            double Dientich();
            double Chuvi();
            void Inra();
        }
        public class ChuNhat : HinhHoc
        {
            public double cd { get; set; }
            public double cr { get; set; }

            public double Chuvi()
            {
                return (cd + cr) * 2;
            }
            public double Dientich()
            {
                return cd * cr;
            }
            public void Inra()
            {
                Console.WriteLine($"Chữ Nhật : {Chuvi()} - {Dientich()}");
            }
        }
        public class Vuong : HinhHoc
        {
            public double c { get; set; }

            public double Chuvi()
            {
                return c * 4;
            }
            public double Dientich()
            {
                return c * c;
            }
            public void Inra()
            {
                Console.WriteLine($"Vuông : {Chuvi()} - {Dientich()}");
            }
        }
        public static void ThucHanh()
        {
            List<HinhHoc> ds = new List<HinhHoc>();

            ds.Add(new ChuNhat() { cd = 4, cr = 3 });
            ds.Add(new Vuong() { c = 6 });

            foreach (HinhHoc pt in ds)
            {
                if (pt.Dientich() >= 20)
                {
                    pt.Inra();
                }
            }
        }


        public static void BaiTap01()
        {
            int[,] a =
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9 , 10, 11, 12 }
            };

            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        tong += a[i, j]; 
                    }
                }
            }
            Console.WriteLine(tong);
        }

        public static void BaiTap02()
        {
            int[] a = { 5, 3, 6, 4 };

            int n = a.Length;

            int[,] c = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j ++)
                {
                    c[i, j] = a[i] - a[j];
                }
            }
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        public static void BaiTap03()
        {
            int n = 6;

            int[,] a = new int[n, n];

            a[0, 0] = 1;

            Console.WriteLine(a[0, 0]);
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0) a[i, j] = 1;
                    else a[i, j] = a[i - 1, j] + a[i - 1, j - 1];
                    if (a[i, j] != 0) Console.Write($"{a[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void BaiTap04()
        {

            int[] a = {1, 2, 3, 4, 6, 7 };

            int k = 3;

            int x = 5;

            //Thêm phần tử x sau vị trí thứ k
            int[] b = new int[a.Length + 1];

            for (int i = 0; i <= k; i++)
            {
                b[i] = a[i];
            }
            b[k + 1] = x;

            for (int i = k + 1; i < a.Length; i++)
            {
                b[i + 1] = a[i];
            }

            foreach (int gt in b)
            {
                Console.Write(gt +" ");
            }
            Console.WriteLine();

            // Xóa phần tử ở vị trí thứ k
            int[] c = new int[a.Length - 1];

            for (int i = 0; i < k; i++)
            {
                c[i] = a[i];
            }
            for (int i = k + 1; i < a.Length; i++)
            {
                c[i - 1] = a[i];
            }
            foreach (int gt in c)
            {
                Console.Write(gt + " ");
            }
            Console.WriteLine();

            //Xóa phần tử ở vị trí k (cách 2)
            int[] d = new int[a.Length - 1];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == k) continue;
                d[j] = a[i];
                j++;
            }
            foreach (int gt in d)
            {
                Console.Write(gt + " ");
            }
        }
        
    }
}
