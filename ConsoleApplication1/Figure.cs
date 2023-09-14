using System;

namespace ConsoleApplication1


{
    public class Figure
    {
        public string Name { get; set; }
        private Point[] points;

        public Figure()
        {
            points = new Point[5];
        }

        public Figure(Point a, Point b, Point c) : this()
        {
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            points[3] = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
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
            int last=0;
            for (int i = 0; i < points.Length-1; ++i)
            {
                if (points[i] != null && points[i + 1] == null)
                {
                    last = i;
                    break;
                }

                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[0], points[last]);

            Console.WriteLine("Название фигуры: " + Name);
            Console.WriteLine("Периметр фигуры: " + perimeter);
        }
    }
}