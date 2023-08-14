namespace AreaCalculatorTest
{
    [TestClass]
    public class AreaCalculatorTest
    {
        const string inputFormatException = "Input string was not in a correct format";
        Circle circle;
        Triangle triangle;

        [TestMethod]
        public void getAreaOfCircleMethod_InputNegative_ThrowArgumentException()
        {
            double rad = -1;

            try
            {
                circle = new Circle(rad);
                var result = circle.getArea();
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, Circle.lengthArgumentException);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void getAreaOfCircleMethod_InputNotDigits_ThrowArgumentException()
        {
            string rad = "test";

            try
            {
                circle = new Circle(Convert.ToDouble(rad));
            }
            catch (FormatException e)
            {
                StringAssert.Contains(e.Message, inputFormatException);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void getAreaOfCircleMethod_WithValidValue()
        {
            double rad = 3;
            double expected = 28.274333882308138;
            circle = new Circle(rad);
            var actual = circle.getArea();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(-3, 4, 5)]
        [DataRow(3, -4, 5)]
        [DataRow(3, 4, -5)]
        [DataRow(-3, -4, 5)]
        [DataRow(3, -4, -5)]
        public void getAreaOfTriangleMethod_InputNegative_ThrowArgumentException(double side1, double side2, double side3)
        {
            try
            {
                triangle = new Triangle(side1, side2, side3);
                var result = triangle.getArea();

            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, Triangle.lengthArgumentException);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        [DataRow(1, 4, 5)]
        [DataRow(4, 1, 5)]
        [DataRow(4, 5, 1)]
        public void getAreaOfTriangleMethod_NotExistingTriangle_ThrowArgumentException(double side1, double side2, double side3)
        {
            try
            {
                triangle = new Triangle(side1, side2, side3);
                var result = triangle.getArea();

            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, Triangle.existingTriangleExeption);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        public void getAreaOfTriangleMethod_WithValidValue(double side1, double side2, double side3)
        {
            double expected = 6;

            triangle = new Triangle(side1, side2, side3);
            var actual = triangle.getArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(5, 4, 3)]
        [DataRow(4, 5, 3)]
        public void getAreaOfTriangleMethod_ifTriangleIsRight(double side1, double side2, double side3)
        {
            triangle = new Triangle(side1, side2, side3);
            var actual = triangle.isTriangleRight();

            Assert.IsTrue(actual);
        }
    }
}