using System.Numerics;

internal class Buoi2
{
    public static void Baitap01()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        do
        {
            Console.Write("Nhập độ C:");

            double celsius;

            string input = Console.ReadLine()!;

            bool ketqua = double.TryParse(input, out celsius);

            if (ketqua == true && celsius > -273)
            {
                double kelvin = celsius + 273;

                double fahrenheit = celsius * 18.0 / 10.0 + 32;

                Console.WriteLine($"Output: kelvin = {kelvin}, fahrenheit = {fahrenheit}");

                break;
            }
            else
            {
                Console.WriteLine("Bạn nhập sai rồi!");
            }

        } while (true);
    }

    public static void Baitap02()
    {
        Console.Write("Nhap ban kinh:");

        double radius = double.Parse(Console.ReadLine()!);

        double surface = 4 * Math.PI * Math.Pow(radius, 2);

        double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine($"Output: Surface: {surface:F2},volume :{volume:F2}");
    }

    public static void Baitap03()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");

        int num1 = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Nhập số thứ hai: ");

        int num2 = Convert.ToInt32(Console.ReadLine()!);

        Console.WriteLine(); 

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Không thể chia cho 0.");
        }
    }
}
