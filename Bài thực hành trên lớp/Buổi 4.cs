using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_thực_hành_trên_lớp
{
    internal class Buoi4
    {
        public static void Baitap01()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập cạnh a: ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");

            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Đây là tam giác cân");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("Ba cạnh nhập vào không tạo thành một tam giác hợp lệ");
            }
        }

        public static void Baitap02()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int tong = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");

                int so = int.Parse(Console.ReadLine()!);

                tong += so;
            }

            double trungbinh = tong / 10;

            Console.WriteLine($"Tổng (Sum) các số là: {tong}");

            Console.WriteLine($"Trung bình cộng (Average) là: {trungbinh}");
        }

        public static void Bai03()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một số nguyên: ");

            int n = int.Parse((Console.ReadLine()!));

            Console.WriteLine($"Bảng cửu chương của {n}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        public static void Baitap04()
        {
            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int dem = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(dem + " ");

                    dem++;
                }
                Console.WriteLine();
            }

            int count = 1;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write(new string(' ', (n - i) * 2));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{count,-3}");

                    count++;
                }
                Console.WriteLine();
            }
        }

        public static void Baitap05()
        {
            Console.Write("Nhap so nguyen n: ");

            int n = int.Parse(Console.ReadLine()!);

            double tong = 0d;

            for (int i = 1; i <= n; i++)
            {
                tong += 1.0d / i;
            }

            Console.WriteLine($"sum = {tong:F2}");
        }
        public static void Baitap06()
        {
            Console.Write("Nhập số tự nhiên n:");

            int n = int.Parse(Console.ReadLine()!);

            int tong = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }

            if (tong == n)
            {
                Console.WriteLine($"{n} là perfect number");

            } else
            {
                Console.WriteLine($"{n} không phải là perfect number");
            }
        }

        public static void Baitap07()
        {
            Console.Write("Nhập số tự nhiên n:");

            int n = int.Parse(Console.ReadLine()!);

            bool songuyento = true;

            if (n < 2)
            {
                songuyento = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    songuyento = false;
                    break;
                }
            }
            if (songuyento)
            {
                Console.WriteLine($"{n} là số nguyên tố");

            } else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố");
            }

        }
    }
}
