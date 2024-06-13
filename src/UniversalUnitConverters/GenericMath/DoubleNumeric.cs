namespace UniversalUnitConverters.GenericMath
{
    /// <summary>
    /// Implementation of INumeric for double type.
    /// </summary>
    /// <see cref="INumeric{T}"/>
    public class DoubleNumeric : INumeric<double>
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;
        public double Convert(decimal value) => (double)value;
    }
}
