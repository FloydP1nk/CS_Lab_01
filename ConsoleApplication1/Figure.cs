using System;

namespace ConsoleApplication1


{
    public class Figure
    {
        public string Name { get; set; }
        // private Point _a, _b, _c, _d, _e;
        private Point[] points;

        public Figure(Point a, Point b, Point c)
        {
            points = new Point[3];
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }

        public Figure(Point a, Point b, Point c, Point d) 
        {
            points = new Point[4];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[5];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            points[4] = e;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(A.X - B.X), 2) +
                             Math.Pow(Math.Abs(A.Y - B.Y), 2)); // V((xa - xb)^2 + (ya - yb)^2)
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine("Название фигуры: " + Name);
            Console.WriteLine("Периметр фигуры: " + perimeter);
        }
    }
}