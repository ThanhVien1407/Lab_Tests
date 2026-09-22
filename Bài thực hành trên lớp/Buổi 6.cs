using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Bài_thực_hành_trên_lớp
{
    internal class Buoi6
    {
        public static void TaoMang(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");

                a[i] = int.Parse(Console.ReadLine()!);
            }
        }
        public static void InMang(int[] a)
        {
            foreach (int c in a)
            {
                Console.Write($"{c}, ");
            }
        }
        static void TaoMangRandom(int[] a)
        {
            Random rnd = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 50);
            }
        }
        static bool IsPrime(int so)
        {
            if (so < 2) return false;

            for (int i = 2; i < Math.Sqrt(so); i++)
            {
                if (so % i == 0) return false;
            }
            return true;
        }
        static void InNguyenTo(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPrime(a[i]))
                {
                    Console.Write($"{a[i]}, ");
                }
            }
        }
        public static void Bai()
        {
            int[] mang;
            mang = new int[3]; //instantiation (memory allocation) 

            int[] mang1 = new int[2]; //initialization

            int[] mang2 = new int[2] { 1, 2 };

            int[] mang3 = { 1, 2, 3 };

            Console.Write("Nhap so phan tu co trong mang: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] Mang = new int[n];

            TaoMang(Mang);

            Console.Write("Mang sau khi nhap: ");

            InMang(Mang);

            Console.WriteLine();

            Console.Write("Cac so nguyen to trong mang:");

            InNguyenTo(Mang);      
        }



        static int[] XoaBangChiSo(int[] Mang, int ChiSo)
        {
            if (ChiSo < 0 || ChiSo >= Mang.Length)
            {
                Console.WriteLine("Vi tri xoa khong hop le");

                return Mang;

            }
            int[] ans = new int[Mang.Length - 1];

            int j = 0;

            for (int i = 0; i < Mang.Length; i++)
            {
                if (i == ChiSo) continue;

                ans[j] = Mang[i];

                j++;
            }
            return ans;
        }   
        public static void BaiTap04()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] Mang = new int[n];

            TaoMang(Mang);

            Console.Write("Chon chi so phan tu can xoa trong mang: ");

            int ChiSo = int.Parse(Console.ReadLine()!);

            Mang = XoaBangChiSo(Mang, ChiSo);

            Console.Write($"Mang sau khi xoa chi so {ChiSo}: ");

            Console.WriteLine(String.Join(",", Mang));
        }




        static void TimTrungLap(int[] Mang)
        {
            HashSet<int> DaThay = new HashSet<int>();

            HashSet<int> TrungLap = new HashSet<int>();

            foreach (int num in Mang)
            {
                if (!DaThay.Add(num))
                {
                    TrungLap.Add(num);
                }
            }
            if (TrungLap.Count > 0)
            {
                Console.WriteLine("Cac gia tri bi trung lap:" + string.Join(",", TrungLap));

            } else
            {
                Console.WriteLine("Khong co gia tri trung lap nao");
            }

        }
        public static void BaiTap07()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] Mang = new int[n];

            TaoMang(Mang);

            TimTrungLap(Mang);
        }



        static int[] XoaTrungLap(int[] Mang)
        {
            int n = Mang.Length;

            int[] temp = new int[n];

            int newSize = 0;

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < newSize; j++)
                {
                    if (Mang[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    temp[newSize] = Mang[i];

                    newSize++;
                }
            }
            int[] result = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }
        public static void BaiTap08()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] Mang = new int[n];

            TaoMang(Mang);

            Mang = XoaTrungLap(Mang);

            Console.WriteLine(String.Join(",", Mang));
        }
    }
}
