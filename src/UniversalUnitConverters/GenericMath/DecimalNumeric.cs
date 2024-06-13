namespace UniversalUnitConverters.GenericMath
{
    /// <summary>
    /// Implementation of INumeric for decimal type.
    /// </summary>
    /// <see cref="INumeric{T}"/>
    public class DecimalNumeric : INumeric<decimal>
    {
        public decimal Add(decimal a, decimal b) => a + b;
        public decimal Subtract(decimal a, decimal b) => a - b;
        public decimal Multiply(decimal a, decimal b) => a * b;
        public decimal Divide(decimal a, decimal b) => a / b;
        public decimal Convert(decimal value) => value;
    }
}
