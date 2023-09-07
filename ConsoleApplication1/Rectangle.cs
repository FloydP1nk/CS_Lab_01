namespace ConsoleApplication1
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        private double CalculateArea()
        {
            return _side1 * _side2;
        }

        private double CalculatePerimeter()
        {
            return (_side1 + _side2) * 2;
        }

        // свойства
        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}