using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DSA
{
    internal class Buoi3
    {
        public static void Test()
        {
            //Stack
            int[] a = new int[] { 3, 4, 8 };

            Stack<int> sa = new Stack<int>(a); //Khoi tao

            Stack<int> s = new Stack<int>(new int[] { 4, 7, 9 }); // another way to khoi tao

            s.Push(6); s.Push(2);

            foreach (int so in s)
            {
                Console.Write(so + " ");
            }
            Console.WriteLine(1);
            //Queue
            Queue<int> q = new Queue<int>();

            q.Enqueue(1); q.Enqueue(2); q.Enqueue(3);

            Queue qd = new Queue(32, 2);
            
            foreach (int so in q)
            {
                Console.Write(so + " ");
            }
        }
        public static void BaiTap01()
        {
            int[] a = {24, 10, 27, 36, 14, 20, 17, 30 };

            Queue<int>[] queue = new Queue<int>[10];
            for (int i = 0; i < 10; i++)
            {
                queue[i] = new Queue<int>();
            }

            foreach (int num in a)
            {
                int donvi = num % 10;
                queue[donvi].Enqueue(num);
            }
            int index = 0;

            for (int i = 0; i < 10; i++)
            { 
                while (queue[i].Count > 0)
                {
                    a[index++] = queue[i].Dequeue();
                }
            }
            Console.WriteLine("Sau lần 1 (hàng đơn vị): " + string.Join(", ", a));

            foreach (int num in a)
            {
                int hangchuc = (num / 10) % 10;
                queue[hangchuc].Enqueue(num);
            }

            index = 0;
            for (int i = 0; i < 10; i++)
            {
                while (queue[i].Count > 0)
                {
                    a[index++] = queue[i].Dequeue();
                }
            }
            // In kết quả cuối cùng
            Console.WriteLine("Dãy số sau khi sắp xếp: " + string.Join(", ", a));
        }
        public static void BaiTap02Queue()
        {
            int[] a = { 24, 7, 10, 427, 4476, 36, 4, 14, 20, 17, 30, 1144 };

            Queue<int>[] queue = new Queue<int>[10];
            for (int i = 0; i < 10; i++)
            {
                queue[i] = new Queue<int>();
            }

            int max_val = a.Max();

            int exp = 1;

            while (max_val / exp > 0)
            {
                foreach (int so in a)
                {
                    int digit = (so / exp) % 10;
                    queue[digit].Enqueue(so);
                }
                int index = 0;

                for (int i = 0; i < 10; i++)
                {
                    while (queue[i].Count > 0)
                    {
                        a[index++] = queue[i].Dequeue();
                    }
                }
                exp *= 10;
            }
            Console.WriteLine("Dãy số sau khi sắp xếp (Dung Queue) :");
            Console.WriteLine(string.Join(", ", a));
        }
        public static void BaiTap02Stack()
        {
            int[] arr = { 24, 7, 10, 427, 4476, 36, 4, 14, 20, 17, 30, 1144 };
            Stack<int>[] stackTemp = new Stack<int>[10];
            Stack<int>[] stackMain = new Stack<int>[10];

            for (int i = 0; i < 10; i++)
            {
                stackTemp[i] = new Stack<int>();
                stackMain[i] = new Stack<int>();
            }

            int max = arr.Max();

            foreach (int num in arr) if (num > max) max = num;

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                foreach (int num in arr)
                {
                    int digit = (num / exp) % 10;
                    stackTemp[digit].Push(num);
                }

                for (int i = 0; i < 10; i++)
                {
                    while (stackTemp[i].Count > 0)
                    {
                        stackMain[i].Push(stackTemp[i].Pop());
                    }
                }
                int index = 0;
                for (int i = 0; i < 10; i++)
                {
                    while (stackMain[i].Count > 0)
                    {
                        arr[index++] = stackMain[i].Pop();
                    }
                }
            }
            Console.WriteLine("Sau khi sap xep (dung stack):" + String.Join(", ", arr));
        }
        public static void BaiTap03()
        {
            static int DoUuTien(char op)
            {
                if (op == '+' || op == '-') return 1;
                if (op == '*' || op == '/') return 2;
                return 0;
            }
            static string InfixToPostFix(string infix)
            {
                string result = "";
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < infix.Length; i++)
                {
                    char c = infix[i];

                    if (c == ' ') continue;

                    if (char.IsDigit(c))
                    {
                        result += c + " ";

                    } else if (c == '(')
                    {
                        stack.Push(c);

                    } else if (c == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            result += stack.Pop() + " ";
                        }
                        if (stack.Count > 0 && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                    } else
                    {
                        while (stack.Count > 0 && DoUuTien(stack.Peek()) >= DoUuTien(c))
                        {
                            result += stack.Pop() + " ";
                        }
                        stack.Push(c);
                    }
                }
                while (stack.Count > 0)
                {
                    result += stack.Pop() + " ";
                }
                return result.Trim();
            }
            string exp1 = "(3 + 4)*5 - 2*3 + 7"; 
            string exp2 = "5 * (6 - (2*3 + 7) * 4) + (8 - 1) * 3"; 

            Console.WriteLine("=== BÀI 3: CHUYỂN BIỂU THỨC SANG BALAN NGHỊCH ==="); //Biểu diễn theo hậu tố

            Console.WriteLine($"Cau 1: {exp1}\n=> Postfix: {InfixToPostFix(exp1)}\n"); 

            Console.WriteLine($"Cau 2: {exp2}\n=> Postfix: {InfixToPostFix(exp2)}\n"); 
        }
        public static void BaiTap04()
        {
            static double GiaiBaLanNghich(string postfix)
            {
                Stack<double> stack = new Stack<double>();
                string[] nums = postfix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string num in nums)
                {
                    if (double.TryParse(num, out double so))
                    {
                        stack.Push(so);
                    }
                    else
                    {
                        double b = stack.Pop();
                        double a = stack.Pop();

                        switch (num)
                        {
                            case "+":
                                stack.Push(a + b); break;
                            case "-":
                                stack.Push(a - b); break;
                            case "*":
                                stack.Push(a * b); break;
                            case "/":
                                stack.Push(a / b); break;
                        }
                    }
                }
                return stack.Pop();
            }
            Console.WriteLine("=== BÀI 4: GIẢI BALAN NGHỊCH ===");
            string p1 = "4 3 + 5 * 3 2 * - 7 +"; 
            string p2 = "3 2 * 7 + 4 * 6 - 5 * 1 8 - 3 * +";

            Console.WriteLine($"Cau 1 ({p1}) = {GiaiBaLanNghich(p1)}"); 
            Console.WriteLine($"Cau 2 ({p2}) = {GiaiBaLanNghich(p2)}"); 
        }
    }
}
