internal class Buoi3
{
    public static void Baitap01()
    {
        Console.Write("Nhap so nguyen a:");

        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap so nguyen b:");

        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine(a + b);

        Console.WriteLine(a - b);

        Console.WriteLine(a * b);

        Console.WriteLine(a / b);
    }

    public static void Baitap02()
    {
        do
        {
            Console.Write("Nhap so nguyen y thuoc [-5;5]: ");

            int y;

            string input = Console.ReadLine()!;

            bool ketqua = int.TryParse(input, out y);

            if (ketqua == true && (y >= -5 && y <= 5))
            {
                int x = y * y + 2 * y + 1;

                Console.WriteLine($"x = y2 + 2y + 1 = {x}");

                break;

            }
            else
            {
                Console.WriteLine("Ban nhap sai roi!");
            }

        } while (true);
    }

    public static void Baitap03()
    {
        Console.Write("Nhap khoang cach (m): ");

        double khoangCach_m = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Nhap gio: ");

        double gio = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Nhap phut: ");

        double phut = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Nhap giay: ");

        double giay = double.Parse(Console.ReadLine()!);

        double tongthoigian = gio + phut / 60 + giay / 3600;

        double khoangcach_km = khoangCach_m / 1000;

        double khoangcach_mile = khoangCach_m / 1609;

        double vantoc_kmh = khoangcach_km / tongthoigian;

        double vantoc_mileh = khoangcach_mile / tongthoigian;

        Console.WriteLine($"van toc (km/h): {vantoc_kmh}");

        Console.WriteLine($"van toc (mile/h): {vantoc_mileh}");

    }

    static void Baitap4()
    {
        Console.Write("Nhap ban kinh cua hinh cau: ");

        double bankinh = double.Parse(Console.ReadLine()!);

        double dientich = 4 * Math.Pow(bankinh, 2) * Math.PI;

        double thetich = 4 / 3 * Math.Pow(bankinh, 3) * Math.PI;

        Console.WriteLine($"Dien tich hinh cau: {dientich}");

        Console.WriteLine($"The tich hin cau: {thetich}");

    }

    static void Baitap5()
    {
        Console.Write("Nhap vao mot ky tu: ");

        char c = Console.ReadLine()![0];

        int ascii_a = (int)c;

        if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i')
        {
            Console.WriteLine("a la so nguyen am");

        }
        else if (ascii_a >= 65 && ascii_a <= 122)
        {

            Console.WriteLine("a la phu am");

        }
        else if (ascii_a >= 48 && ascii_a <= 57)
        {
            Console.WriteLine("a la so nguyen");

        }
        else if (ascii_a >= 33 && ascii_a <= 46)
        {
            Console.WriteLine("a la ky tu dac biet");

        }
        else
        {
            Console.WriteLine(" a la cac ki tu con lai");
        }
    }
}