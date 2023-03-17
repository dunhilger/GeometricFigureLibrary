using GeometricFigure.Interfaces;

namespace GeometricFigure
{
    /// <summary>
    /// Класс для создания экземпляра треугольника
    /// </summary>
    public class Triangle : IGeometricFigure
    {
        /// <summary>
        /// Создание экземпляра <see cref="Triangle"> 
        /// </summary>
        /// <param name="sideA">Сторона треугольника</param>
        /// <param name="sideB">Сторона треугольника</param>
        /// <param name="sideC">Сторона треугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SetSides(sideA, sideB, sideC);
            IsRightTriangle = IsTriangleRight();
        }

        /// <summary>
        /// Позволяет одновременно изменить размеры сторон существующего треугольника с их последующей проверкой 
        /// </summary>
        /// <param name="sideA">Сторона треугольника</param>
        /// <param name="sideB">Сторона треугольника</param>
        /// <param name="sideC">Сторона треугольника</param>
        public void SetSides(double sideA, double sideB, double sideC)
        {
            if (IsSideValid(sideA) && IsSideValid(sideB) && IsSideValid(sideC))
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }

            CheckTrianglePossible();
        }

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideA
        {
            get => _sideA;
            set
            {
                if (IsSideValid(value))
                {
                    _sideA = value;
                }

                CheckTrianglePossible();
            }
        }
        private double _sideA;

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideB
        {
            get => _sideB;
            set
            {
                if (IsSideValid(value))
                {
                    _sideB = value;
                }

                CheckTrianglePossible();
            }
        }
        private double _sideB;

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideC
        {
            get => _sideC;
            set
            {
                if (IsSideValid(value))
                {
                    _sideC = value;
                }

                CheckTrianglePossible();
            }
        }
        private double _sideC;

        /// <summary>
        /// Прямоугольный треугольник
        /// </summary>
        public bool IsRightTriangle { get; private set; }

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            var p = GetPerimeter() / 2d;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        private bool IsTriangleRight()
        {
            var area = GetArea();

            return Math.Abs(area - _sideA * _sideB / 2) <= ConstantSettings.Epsilon ||
                   Math.Abs(area - _sideA * _sideC / 2) <= ConstantSettings.Epsilon ||
                   Math.Abs(area - _sideB * _sideC / 2) <= ConstantSettings.Epsilon;
        }

        private double GetPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        private void CheckTrianglePossible()
        {
            if (_sideA + _sideB <= _sideC || _sideB + _sideC <= _sideA || _sideA + _sideC <= _sideB)
            {
                throw new Exception("Triangle not possible");
            }
        }

        private static bool IsSideValid(double value)
        {
            if (value > 0)
            {
                return true;
            }

            throw new Exception($"Side value {value} is incorrect");
        }
    }
}