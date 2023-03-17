using GeometricFigure;

namespace NUnitTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(8, 201.0619298297468d)]

        public void Get_Area_Test(double radius, double expectedAreaResult)
        {
            var circle = new Circle(radius);

            Assert.That(expectedAreaResult, Is.EqualTo(circle.GetArea()).Within(0.0000001));
        }

        [TestCase(23, 113.0973355292325d)]

        public void Change_Radius_Get_Area_Test(double radius, double expectedAreaResult)
        {
            var circle = new Circle(radius);
            circle.Radius = 6;

            Assert.That(expectedAreaResult, Is.EqualTo(circle.GetArea()).Within(0.0000001));
        }

        [TestCase(-7)]

        public void Change_Incorrect_Radius_Exeption_Test(double radius)
        {
            var circle = new Circle(3);

            Assert.Throws<Exception>(() => circle.Radius = radius);
        }
    }
}
