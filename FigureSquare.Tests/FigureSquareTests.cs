namespace FigureSquare.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetCircleSquareTest1()
        {
            Circle circle = new Circle(5);
            double expected = 25 * Math.PI;
            double actual = circle.GetSquare();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetCircleSquareTest2()
        {
            Circle circle = new Circle(25.35);
            double expected = 25.35 * 25.35 * Math.PI;
            double actual = circle.GetSquare();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetTriangleSquareTest1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double p = (3 + 4 + 5) / 2;
            double expected = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));
            double actual = triangle.GetSquare();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetTriangleSquareTest2()
        {
            Triangle triangle = new Triangle(5.24, 7.76, 9.24);
            double p = (5.24 + 7.76 + 9.24) / 2;
            double expected = Math.Sqrt(p * (p - 5.24) * (p - 7.76) * (p - 9.24));
            double actual = triangle.GetSquare();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroRadius()
        {
            Assert.That(() => new Circle(0), Throws.Exception);
        }

        [Test]
        public void NegativeRadius()
        {
            Assert.That(() => new Circle(-4), Throws.Exception);
        }

        [Test]
        public void ZeroValueTriangle()
        {
            Assert.That(() => new Triangle(0, 4, 6), Throws.Exception);
        }

        [Test]
        public void NegativeValueTriangle()
        {
            Assert.That(() => new Triangle(5, -7, 6), Throws.Exception);
        }
    }
}