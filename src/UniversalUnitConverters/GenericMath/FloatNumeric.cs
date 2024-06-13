namespace UniversalUnitConverters.GenericMath
{
    /// <summary>
    /// Implementation of INumeric for float type.
    /// </summary>
    /// <see cref="INumeric{T}"/>
    public class FloatNumeric : INumeric<float>
    {
        public float Add(float a, float b) => a + b;
        public float Subtract(float a, float b) => a - b;
        public float Multiply(float a, float b) => a * b;
        public float Divide(float a, float b) => a / b;
        public float Convert(decimal value) => (float)value;
    }
}
