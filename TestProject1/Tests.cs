using ConsoleApplication1;
using NUnit.Framework;


namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int side1 = 2;
            int side2 = 4;
            Rectangle rect = new Rectangle(side1, side2);
            Assert.AreEqual(8, rect.Area);
            Assert.AreEqual(12, rect.Perimeter);
        }

        [Test]
        public void Test2()
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 4);
            Point C = new Point(3, 0);
            Figure figure = new Figure(A, B, C);
            Assert.AreEqual(4, figure.LengthSide(A, B));
        }
    }
}