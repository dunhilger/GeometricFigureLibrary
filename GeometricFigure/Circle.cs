using GeometricFigure.Interfaces;

namespace GeometricFigure
{
    /// <summary>
    /// Класс для создания экземпляра круга
    /// </summary>
    public class Circle : IGeometricFigure
    {
        /// <summary>
        /// Создание экземпляра <see cref="Circle">
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (IsRadiusValid(radius))
            {
                _radius = radius;
            }         
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        private double _radius;

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius
        {
            get { return _radius; }

            set 
            {
                if (IsRadiusValid(value))
                {
                    _radius = value;
                }
            }
        }

        private static bool IsRadiusValid(double radius)
        {
            if (radius > 0)
            {
                return true;    
            }
            else
            {
                throw new Exception($"value {radius} is not correct");
            }
        }
    }
}
