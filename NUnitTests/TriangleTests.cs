using GeometricFigure;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3, 3, 3, 3.897114317029974d)]

        public void Get_Area_Test(double sideA, double sideB, double sideC, double expectedAreaResult)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            
            Assert.That(expectedAreaResult, Is.EqualTo(triangle.GetArea()).Within(0.0000001));
        }

        [TestCase(3, 3, 3, 4.14578098794425d)]

        public void Change_One_Side_Get_Area_Test(double sideA, double sideB, double sideC, double expectedAreaResult)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            triangle.SideC = 5;

            Assert.That(expectedAreaResult, Is.EqualTo(triangle.GetArea()).Within(0.0000001));
        }

        [TestCase(3, 3, 3, 11.97653956700348d)]

        public void Change_All_Sides_Get_Area_Test(double sideA, double sideB, double sideC, double expectedAreaResult)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            triangle.SetSides(4, 6, 7);

            Assert.That(expectedAreaResult, Is.EqualTo(triangle.GetArea()).Within(0.0000001));
        }

        [TestCase(-7)]
        [TestCase(12)]
        [TestCase(0)]

        public void Change_Incorrect_Side_Exeption_Test(double sideValue)
        {
            var triangle = new Triangle(4, 5, 6);

            Assert.Throws<Exception>(() => triangle.SideC = sideValue);
        }

        [TestCase(30, 40, 50, ExpectedResult = true)]
        [TestCase(0.7, 2.4, 2.5, ExpectedResult = true)]
        [TestCase(3.5, 2.1, 2.8, ExpectedResult = true)]
        [TestCase(0.3, 0.4, 0.5, ExpectedResult = true)]
        [TestCase(6, 9.1, 10.9, ExpectedResult = true)]
        [TestCase(1.5, 11.2, 11.3, ExpectedResult = true)]
        [TestCase(4.4, 11.7, 12.5, ExpectedResult = true)]
        [TestCase(8.8, 10.5, 13.7, ExpectedResult = true)]
        [TestCase(1.7, 14.4, 14.5, ExpectedResult = true)]
        [TestCase(2.4, 14.3, 14.5, ExpectedResult = true)]
        [TestCase(5.1, 14, 14.9, ExpectedResult = true)]
        [TestCase(8.5, 13.2, 15.7, ExpectedResult = true)]
        [TestCase(11.9, 12, 16.9, ExpectedResult = true)]
        [TestCase(5.2, 16.5, 17.3, ExpectedResult = true)]
        [TestCase(1.9, 18, 18.1, ExpectedResult = true)]
        [TestCase(5.7, 17.6, 18.5, ExpectedResult = true)]
        [TestCase(10.4, 15.3, 18.5, ExpectedResult = true)]
        [TestCase(9.5, 16.8, 19.3, ExpectedResult = true)]
        [TestCase(2.8, 19.5, 19.7, ExpectedResult = true)]
        [TestCase(8.4, 18.7, 20.5, ExpectedResult = true)]
        [TestCase(13.3, 15.6, 20.5, ExpectedResult = true)]
        [TestCase(2.1, 22, 22.1, ExpectedResult = true)]
        [TestCase(14, 17.1, 22.1, ExpectedResult = true)]
        [TestCase(6, 22.1, 22.9, ExpectedResult = true)]
        [TestCase(2.8, 19.5, 19.7, ExpectedResult = true)]
        [TestCase(10.5, 20.8, 23.3, ExpectedResult = true)]
        [TestCase(12, 20.9, 24.1, ExpectedResult = true)]
        [TestCase(2.8, 19.5, 19.7, ExpectedResult = true)]
        [TestCase(3.2, 25.5, 25.7, ExpectedResult = true)]
        [TestCase(2.3, 26.4, 26.5, ExpectedResult = true)]
        [TestCase(9.6, 24.7, 26.5, ExpectedResult = true)]
        [TestCase(6.9, 26, 26.9, ExpectedResult = true)]
        [TestCase(11.5, 25.2, 27.7, ExpectedResult = true)]
        [TestCase(16, 23.1, 28.1, ExpectedResult = true)]
        [TestCase(16.1, 24, 28.9, ExpectedResult = true)]
        [TestCase(12.8, 17, 29.3, ExpectedResult = false)]
        [TestCase(51, 42, 39, ExpectedResult = false)]

        public bool Is_Right_Triangle_Test(double sideA, double sideB, double sideC)
        {
            ConstantSettings.Epsilon = 1.0E-11;
            var triangle = new Triangle(sideA, sideB, sideC);
            var IsRight = triangle.IsRightTriangle;

            return IsRight;
        }

        [TestCase(0, 0, 0)]
        [TestCase(5, -3, 5)]
        [TestCase(0, 5, 5)]
        [TestCase(3, 8, 2)]

        public void Incorrect_Side_Exception_Test(double sideA, double sideB, double sideC)
        {
            Assert.Throws<Exception>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(1.0E-16)]
        [TestCase(0.2d)]

        public void Incorrect_Epsilon_Value_Test(double epsilon)
        {
            Assert.Throws<Exception>(()=> ConstantSettings.Epsilon = epsilon);
        }
    }
}