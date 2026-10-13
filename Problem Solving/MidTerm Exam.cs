using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_tập_1
{
    /// <summary>
    /// Đề bài:
        /*Viết các hàm thực hiện các yêu cầu sau
        1. Hoán đổi giá trị của hai số.
        2. Kiểm tra một số có phải là một ước số của một số khác hay không. (các số đề cập trong câu
        hỏi là số nguyên dương)
        3. Tính tổng của các tham số, với số tham số không xác định trước.
        4. Phát sinh một mảng có N số nguyên ngẫu nhiên, với N nhập từ bàn phím.
        5. In ra một mảng các số nguyên, các phần tử phân cách bởi dấu phẩy.
        6. Nhập một số X, tìm xem số X có tồn tại trong mảng hay không. Nếu có trả về vị trí xuất hiện
        sau cùng của X, không có thì trả về -1.
        7. In ra các phần tử trong mảng là số hoàn thiện.
        Hướng dẫn: Số hoàn thiện là một số nguyên dương mà tổng các ước số nguyên dương
        của nó (các số nguyên dương bị nó chia hết ngoại trừ nó) bằng chính nó.
        8. Kiểm tra các phần tử trong mảng đã được sắp xếp giảm dần chưa. Nếu có thì trả về true, còn
        không trả về false.
        9. Sắp xếp các phần tử mảng theo thứ tự tăng dần (không dùng hàm do C# cung cấp sẵn).
        10. Viết một menu cho phép lựa chọn các hàm và thực thi. (hàm main)
        *** Các giả định khác để chương trình hoàn chỉnh có thể được thêm vào một cách hợp lý.*/
    /// </summary>

    internal class MidTerm_Exam
    {
        //1. Hoán đổi giá trị của hai số.
        static void HoanDoi(ref int a, ref int b)
        {
            int temp = a;

            a = b;

            b = temp;
        }
        static void Question01()
        {
            Console.Write("Nhập số tự nhiên a: ");

            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số tự nhiên b: ");

            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Trước khi hoán đổi: ");

            Console.WriteLine($"a = {a}");

            Console.WriteLine($"b = {b}");

            HoanDoi(ref a ,ref b);

            Console.WriteLine("Sau khi hoán đổi: ");

            Console.WriteLine($"a = {a}");

            Console.WriteLine($"b = {b}");
        }

        //2. Kiểm tra một số có phải là một ước số của một số khác hay không. (các số đề cập trong câu hỏi là số nguyên dương)
        static void KiemTraUocSo(int a, int b)
        {
            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine($"{b} là ước số của {a}");

                }
                else
                {
                    Console.WriteLine($"{b} không phải là ước số của {a}");
                }
            }
            else if (a < b)
            {
                if (b % a == 0)
                {
                    Console.WriteLine($"{a} là ước số của {b}");

                }
                else
                {
                    Console.WriteLine($"{a} không phải là ước số của {b}");
                }
            } else if (a == b)
            {
                Console.WriteLine($"{a} và {b} là ước số của nhau");
            }
        }
        static void Question02()
        {
            Console.Write("Nhập số nguyên dương a: ");

            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số nguyên dương b: ");

            int b = int.Parse(Console.ReadLine()!);

            KiemTraUocSo(a, b);
        }

        //3. Tính tổng của các tham số, với số tham số không xác định trước
        static int TongKhongXacDinh(int[] a)
        {
            int tong = 0;

            foreach (int so in a)
            {
                tong += so;
            }
            return tong;
        }
        static void Question03()
        {
            Console.Write("Nhập số phần tử trong mảng cần tính tổng: ");

            int n = int.Parse(Console.ReadLine()!);

            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"phần tử thứ {i}: ");
                mang[i] = int.Parse(Console.ReadLine()!);
            }
            Console.Write($"Tổng các phần tử trong mảng: {TongKhongXacDinh(mang)}");

        }

        //4. Phát sinh một mảng có N số nguyên ngẫu nhiên, với N nhập từ bàn phím

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Chọn bài để chạy (1 - 10): ");

            int ChonBai = int.Parse(Console.ReadLine()!);

            switch (ChonBai)
            {
                case 1:
                    Question01();
                    break;

                case 2:
                    Question02();
                    break;

                case 3:
                    Question03();
                    break;

                default:
                    Console.WriteLine("Bạn nhập sai, vui lòng nhập lại (từ 1 - 10): ");
                    break;
            }
        }
    }
}
