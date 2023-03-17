namespace GeometricFigure
{
    public static class ConstantSettings
    {
        private static double epsilon = 1.0E-12;

        public static double Epsilon
        {
            get { return epsilon; }
            set 
            {
                if (IsEpsilonValid(value))
                {
                    epsilon = value;
                }
                else
                {
                    throw new Exception($"Epsilon value {value} is not correct");
                }        
            }
        }

        private static bool IsEpsilonValid(double epsilonValue)
        {
            return epsilonValue >= 1.0E-15 && epsilonValue <= 1.0E-5;
        }
    }
}
