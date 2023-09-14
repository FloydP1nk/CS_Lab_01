using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1
            Console.WriteLine("1 Задание");
            Console.WriteLine("------------------------");
            Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных C#:");

            Console.WriteLine(
                $"sbyte: минимальное значение = {sbyte.MinValue}, максимальное значение = {sbyte.MaxValue}");
            Console.WriteLine($"byte: минимальное значение = {byte.MinValue}, максимальное значение = {byte.MaxValue}");
            Console.WriteLine(
                $"short: минимальное значение = {short.MinValue}, максимальное значение = {short.MaxValue}");
            Console.WriteLine(
                $"ushort: минимальное значение = {ushort.MinValue}, максимальное значение = {ushort.MaxValue}");
            Console.WriteLine($"int: минимальное значение = {int.MinValue}, максимальное значение = {int.MaxValue}");
            Console.WriteLine($"uint: минимальное значение = {uint.MinValue}, максимальное значение = {uint.MaxValue}");
            Console.WriteLine($"long: минимальное значение = {long.MinValue}, максимальное значение = {long.MaxValue}");
            Console.WriteLine(
                $"ulong: минимальное значение = {ulong.MinValue}, максимальное значение = {ulong.MaxValue}");

            Console.WriteLine(
                $"float: минимальное значение = {float.MinValue}, максимальное значение = {float.MaxValue}");
            Console.WriteLine(
                $"double: минимальное значение = {double.MinValue}, максимальное значение = {double.MaxValue}");
            Console.WriteLine(
                $"decimal: минимальное значение = {decimal.MinValue}, максимальное значение = {decimal.MaxValue}");

            Console.WriteLine(
                $"char: минимальное значение = {(int)char.MinValue}, максимальное значение = {(int)char.MaxValue}");

            Console.WriteLine(
                $"DateTime: минимальное значение = {DateTime.MinValue}, максимальное значение = {DateTime.MaxValue}");
            // 2
            Console.WriteLine("------------------------");
            Console.WriteLine("2 Задание");
            Console.WriteLine($"enter side1");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"enter side2");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Area: {rectangle.Area} Perimetr: {rectangle.Perimeter}");

            Console.WriteLine("------------------------");
            Console.WriteLine("3 Задание");
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 4);
            Point point3 = new Point(3, 0);
            Figure triangle = new Figure(point1, point2, point3);
            triangle.Name = "Треугольник";
            triangle.PerimeterCalculator();
        }
    }
}