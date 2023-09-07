namespace ConsoleApplication1
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public double GetX
        {
            get { return _x; }
        }

        public double GetY
        {
            get { return _y; }
        }
    }
}