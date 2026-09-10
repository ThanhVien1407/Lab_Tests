using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Xml;

internal class Program
{
    static bool laSNT(int k)
    {
    
        if (k < 2) return false;
        for (int i = 2; i <= Math.Sqrt(k); i++) {
            if (k % i == 0) return false;
        }
        return true;
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số dòng n:");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột m:");
        int m = int.Parse(Console.ReadLine()!);

        int[,] matrix = new int[n, m];

        Console.WriteLine("----Nhập ma trận----");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Phần tử [{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine()!);

            }
        }

        Console.WriteLine("-----Các số nguyên tố trong ma trận-----");
        bool coSNT = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m;j++)
            {
                if (laSNT(matrix[i,j]))
                {
                    Console.WriteLine(matrix[i,j] + " Là số nguyên tố");
                    coSNT = true;
                }
            }
        }
        if (!coSNT) Console.Write("Không có số nguyên tố nào");

    }
}