using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Bài_thực_hành_trên_lớp
{
    internal class Buoi5
    {
        public static bool isPangram(string s)
        {
            s = s.ToLower();

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!s.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static void BaiTap01()
        {
            Console.Write("Nhập xâu kí tự cần kiểm tra: ");

            string s = Console.ReadLine()!;

            if (Buoi5.isPangram(s))
            {
                Console.WriteLine("la chuoi Pangram");

            }
            else
            {
                Console.WriteLine("khong la chuoi Pangram");
            }
        }
    }
}
