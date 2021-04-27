using NUnit.Framework;
using NUnitAreaCalculations;

namespace Tests
{
    public class Tests
    {
        Shapes<IShape> shapes = new Shapes<IShape>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircle()
        {
            this.shapes.Clear();
            this.shapes.Add(new Circle(3));
            Assert.AreEqual(28.26, shapes.GetTotalArea());
        }

        [Test]
        public void TestRectagle()
        {
            this.shapes.Clear();
            shapes.Add(new Rectangle(10, 5.1));
            Assert.AreEqual(51, shapes.GetTotalArea());
        }

        [Test]
        public void TestTriangle()
        {
            this.shapes.Clear();
            shapes.Add(new Triangle(10, 5.1));
            Assert.AreEqual(25.5, shapes.GetTotalArea());
        }

        [Test]
        public void TestSquare()
        {
            this.shapes.Clear();
            shapes.Add(new Square(3.3));
            Assert.AreEqual(10.89, shapes.GetTotalArea());
        }


        [Test]
        public void TestCircleAndRectagle()
        {
            this.shapes.Clear();
            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(10, 5.1));
            Assert.AreEqual(79.26, shapes.GetTotalArea());
        }

        [Test]
        public void TestAllShape()
        {
            this.shapes.Clear();
            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(10, 5.1));
            shapes.Add(new Square(3.3));
            shapes.Add(new Triangle(10, 5.1));
            Assert.AreEqual(115.65, shapes.GetTotalArea());
        }
    }
}