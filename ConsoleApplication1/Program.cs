using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"enter side1");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"enter side2");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);
            //var rect2 = new Rectangle(side1, side2);
            double area = rect.Area;
            double perimeter = rect.Perimeter;
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}