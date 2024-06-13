namespace UniversalUnitConverters.GenericMath
{
    /// <summary>
    /// <para>Interface defining basic arithmetic operations for a numeric type.</para>
    /// <para>
    /// Note: Generic math is available in .NET 7 onwards but this library targets .NET Standard for wider compatibility.
    /// </para>
    /// </summary>
    /// <typeparam name="T">The numeric type (e.g. double, float, decimal etc.)</typeparam>
    public interface INumeric<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
        T Convert(decimal value);
    }
}
