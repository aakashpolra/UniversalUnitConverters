namespace UniversalUnitConverters.Extensions
{
    /// <summary>
    /// Provides extension methods for unit conversions on numeric types such as int, double, and decimal.
    /// 
    /// Example usage:
    /// <code>
    /// double kilometers = 5.433.MilesToKilometers();
    /// decimal fahrenheit = 25.3m.CelsiusToFahrenheit();
    /// decimal feet = 100.MetersToInternationalFeet();
    /// </code>
    /// </summary>
    public static class UnitConversionExtensions
    {
        // Double extensions
        public static double MilesToKilometers(this double miles) => UnitConverters.MilesToKilometers(miles);
        public static double KilometersToMiles(this double kilometers) => UnitConverters.KilometersToMiles(kilometers);
        public static double CelsiusToFahrenheit(this double celsius) => UnitConverters.CelsiusToFahrenheit(celsius);
        public static double FahrenheitToCelsius(this double fahrenheit) => UnitConverters.FahrenheitToCelsius(fahrenheit);
        public static double CelsiusToKelvin(this double celsius) => UnitConverters.CelsiusToKelvin(celsius);
        public static double KelvinToCelsius(this double kelvin) => UnitConverters.KelvinToCelsius(kelvin);
        public static double MilesToMeters(this double miles) => UnitConverters.MilesToMeters(miles);
        public static double DegreesToRadians(this double degrees) => UnitConverters.DegreesToRadians(degrees);
        public static double RadiansToDegrees(this double radians) => UnitConverters.RadiansToDegrees(radians);
        public static double PoundsToKilograms(this double pounds) => UnitConverters.PoundsToKilograms(pounds);
        public static double PoundsToStones(this double pounds) => UnitConverters.PoundsToStones(pounds);
        public static double StonesToPounds(this double stones) => UnitConverters.StonesToPounds(stones);
        public static double KilogramsToPounds(this double kilograms) => UnitConverters.KilogramsToPounds(kilograms);
        public static double DegreesPerSecondToRadiansPerSecond(this double degrees) => UnitConverters.DegreesPerSecondToRadiansPerSecond(degrees);
        public static double RadiansPerSecondToDegreesPerSecond(this double radians) => UnitConverters.RadiansPerSecondToDegreesPerSecond(radians);
        public static double DegreesPerSecondToHertz(this double degrees) => UnitConverters.DegreesPerSecondToHertz(degrees);
        public static double RadiansPerSecondToHertz(this double radians) => UnitConverters.RadiansPerSecondToHertz(radians);
        public static double HertzToDegreesPerSecond(this double hertz) => UnitConverters.HertzToDegreesPerSecond(hertz);
        public static double HertzToRadiansPerSecond(this double hertz) => UnitConverters.HertzToRadiansPerSecond(hertz);
        public static double KilopascalsToHectopascals(this double kpa) => UnitConverters.KilopascalsToHectopascals(kpa);
        public static double HectopascalsToKilopascals(this double hpa) => UnitConverters.HectopascalsToKilopascals(hpa);
        public static double KilopascalsToPascals(this double kpa) => UnitConverters.KilopascalsToPascals(kpa);
        public static double HectopascalsToPascals(this double hpa) => UnitConverters.HectopascalsToPascals(hpa);
        public static double AtmospheresToPascals(this double atm) => UnitConverters.AtmospheresToPascals(atm);
        public static double PascalsToAtmospheres(this double pascals) => UnitConverters.PascalsToAtmospheres(pascals);
        public static double CoordinatesToMiles(this (double lat1, double lon1, double lat2, double lon2) coordinates) => UnitConverters.CoordinatesToMiles(coordinates.lat1, coordinates.lon1, coordinates.lat2, coordinates.lon2);
        public static double CoordinatesToKilometers(this (double lat1, double lon1, double lat2, double lon2) coordinates) => UnitConverters.CoordinatesToKilometers(coordinates.lat1, coordinates.lon1, coordinates.lat2, coordinates.lon2);
        public static double MetersToInternationalFeet(this double meters) => UnitConverters.MetersToInternationalFeet(meters);
        public static double InternationalFeetToMeters(this double internationalFeet) => UnitConverters.InternationalFeetToMeters(internationalFeet);
        public static double MetersToUSSurveyFeet(this double meters) => UnitConverters.MetersToUSSurveyFeet(meters);
        public static double USSurveyFeetToMeters(this double usFeet) => UnitConverters.USSurveyFeetToMeters(usFeet);

        // Decimal extensions
        public static decimal MilesToKilometers(this decimal miles) => UnitConverters.MilesToKilometers(miles);
        public static decimal KilometersToMiles(this decimal kilometers) => UnitConverters.KilometersToMiles(kilometers);
        public static decimal CelsiusToFahrenheit(this decimal celsius) => UnitConverters.CelsiusToFahrenheit(celsius);
        public static decimal FahrenheitToCelsius(this decimal fahrenheit) => UnitConverters.FahrenheitToCelsius(fahrenheit);
        public static decimal CelsiusToKelvin(this decimal celsius) => UnitConverters.CelsiusToKelvin(celsius);
        public static decimal KelvinToCelsius(this decimal kelvin) => UnitConverters.KelvinToCelsius(kelvin);
        public static decimal MilesToMeters(this decimal miles) => UnitConverters.MilesToMeters(miles);
        public static decimal DegreesToRadians(this decimal degrees) => UnitConverters.DegreesToRadians(degrees);
        public static decimal RadiansToDegrees(this decimal radians) => UnitConverters.RadiansToDegrees(radians);
        public static decimal PoundsToKilograms(this decimal pounds) => UnitConverters.PoundsToKilograms(pounds);
        public static decimal PoundsToStones(this decimal pounds) => UnitConverters.PoundsToStones(pounds);
        public static decimal StonesToPounds(this decimal stones) => UnitConverters.StonesToPounds(stones);
        public static decimal KilogramsToPounds(this decimal kilograms) => UnitConverters.KilogramsToPounds(kilograms);
        public static decimal DegreesPerSecondToRadiansPerSecond(this decimal degrees) => UnitConverters.DegreesPerSecondToRadiansPerSecond(degrees);
        public static decimal RadiansPerSecondToDegreesPerSecond(this decimal radians) => UnitConverters.RadiansPerSecondToDegreesPerSecond(radians);
        public static decimal DegreesPerSecondToHertz(this decimal degrees) => UnitConverters.DegreesPerSecondToHertz(degrees);
        public static decimal RadiansPerSecondToHertz(this decimal radians) => UnitConverters.RadiansPerSecondToHertz(radians);
        public static decimal HertzToDegreesPerSecond(this decimal hertz) => UnitConverters.HertzToDegreesPerSecond(hertz);
        public static decimal HertzToRadiansPerSecond(this decimal hertz) => UnitConverters.HertzToRadiansPerSecond(hertz);
        public static decimal KilopascalsToHectopascals(this decimal kpa) => UnitConverters.KilopascalsToHectopascals(kpa);
        public static decimal HectopascalsToKilopascals(this decimal hpa) => UnitConverters.HectopascalsToKilopascals(hpa);
        public static decimal KilopascalsToPascals(this decimal kpa) => UnitConverters.KilopascalsToPascals(kpa);
        public static decimal HectopascalsToPascals(this decimal hpa) => UnitConverters.HectopascalsToPascals(hpa);
        public static decimal AtmospheresToPascals(this decimal atm) => UnitConverters.AtmospheresToPascals(atm);
        public static decimal PascalsToAtmospheres(this decimal pascals) => UnitConverters.PascalsToAtmospheres(pascals);
        public static decimal CoordinatesToMiles(this (decimal lat1, decimal lon1, decimal lat2, decimal lon2) coordinates) => UnitConverters.CoordinatesToMiles(coordinates.lat1, coordinates.lon1, coordinates.lat2, coordinates.lon2);
        public static decimal CoordinatesToKilometers(this (decimal lat1, decimal lon1, decimal lat2, decimal lon2) coordinates) => UnitConverters.CoordinatesToKilometers(coordinates.lat1, coordinates.lon1, coordinates.lat2, coordinates.lon2);
        public static decimal MetersToInternationalFeet(this decimal meters) => UnitConverters.MetersToInternationalFeet(meters);
        public static decimal InternationalFeetToMeters(this decimal internationalFeet) => UnitConverters.InternationalFeetToMeters(internationalFeet);
        public static decimal MetersToUSSurveyFeet(this decimal meters) => UnitConverters.MetersToUSSurveyFeet(meters);
        public static decimal USSurveyFeetToMeters(this decimal usFeet) => UnitConverters.USSurveyFeetToMeters(usFeet);

        // Int extensions
        public static decimal MilesToKilometers(this int miles) => UnitConverters.MilesToKilometers((decimal)miles);
        public static decimal KilometersToMiles(this int kilometers) => UnitConverters.KilometersToMiles((decimal)kilometers);
        public static decimal CelsiusToFahrenheit(this int celsius) => UnitConverters.CelsiusToFahrenheit((decimal)celsius);
        public static decimal FahrenheitToCelsius(this int fahrenheit) => UnitConverters.FahrenheitToCelsius((decimal)fahrenheit);
        public static decimal CelsiusToKelvin(this int celsius) => UnitConverters.CelsiusToKelvin((decimal)celsius);
        public static decimal KelvinToCelsius(this int kelvin) => UnitConverters.KelvinToCelsius((decimal)kelvin);
        public static decimal MilesToMeters(this int miles) => UnitConverters.MilesToMeters((decimal)miles);
        public static decimal DegreesToRadians(this int degrees) => UnitConverters.DegreesToRadians((decimal)degrees);
        public static decimal RadiansToDegrees(this int radians) => UnitConverters.RadiansToDegrees((decimal)radians);
        public static decimal PoundsToKilograms(this int pounds) => UnitConverters.PoundsToKilograms((decimal)pounds);
        public static decimal PoundsToStones(this int pounds) => UnitConverters.PoundsToStones((decimal)pounds);
        public static decimal StonesToPounds(this int stones) => UnitConverters.StonesToPounds((decimal)stones);
        public static decimal KilogramsToPounds(this int kilograms) => UnitConverters.KilogramsToPounds((decimal)kilograms);
        public static decimal DegreesPerSecondToRadiansPerSecond(this int degrees) => UnitConverters.DegreesPerSecondToRadiansPerSecond((decimal)degrees);
        public static decimal RadiansPerSecondToDegreesPerSecond(this int radians) => UnitConverters.RadiansPerSecondToDegreesPerSecond((decimal)radians);
        public static decimal DegreesPerSecondToHertz(this int degrees) => UnitConverters.DegreesPerSecondToHertz((decimal)degrees);
        public static decimal RadiansPerSecondToHertz(this int radians) => UnitConverters.RadiansPerSecondToHertz((decimal)radians);
        public static decimal HertzToDegreesPerSecond(this int hertz) => UnitConverters.HertzToDegreesPerSecond((decimal)hertz);
        public static decimal HertzToRadiansPerSecond(this int hertz) => UnitConverters.HertzToRadiansPerSecond((decimal)hertz);
        public static decimal KilopascalsToHectopascals(this int kpa) => UnitConverters.KilopascalsToHectopascals((decimal)kpa);
        public static decimal HectopascalsToKilopascals(this int hpa) => UnitConverters.HectopascalsToKilopascals((decimal)hpa);
        public static decimal KilopascalsToPascals(this int kpa) => UnitConverters.KilopascalsToPascals((decimal)kpa);
        public static decimal HectopascalsToPascals(this int hpa) => UnitConverters.HectopascalsToPascals((decimal)hpa);
        public static decimal AtmospheresToPascals(this int atm) => UnitConverters.AtmospheresToPascals((decimal)atm);
        public static decimal PascalsToAtmospheres(this int pascals) => UnitConverters.PascalsToAtmospheres((decimal)pascals);
        public static decimal CoordinatesToMiles(this (int lat1, int lon1, int lat2, int lon2) coordinates) => UnitConverters.CoordinatesToMiles((decimal)coordinates.lat1, (decimal)coordinates.lon1, (decimal)coordinates.lat2, (decimal)coordinates.lon2);
        public static decimal CoordinatesToKilometers(this (int lat1, int lon1, int lat2, int lon2) coordinates) => UnitConverters.CoordinatesToKilometers((decimal)coordinates.lat1, (decimal)coordinates.lon1, (decimal)coordinates.lat2, (decimal)coordinates.lon2);
        public static decimal MetersToInternationalFeet(this int meters) => UnitConverters.MetersToInternationalFeet((decimal)meters);
        public static decimal InternationalFeetToMeters(this int internationalFeet) => UnitConverters.InternationalFeetToMeters((decimal)internationalFeet);
        public static decimal MetersToUSSurveyFeet(this int meters) => UnitConverters.MetersToUSSurveyFeet((decimal)meters);
        public static decimal USSurveyFeetToMeters(this int usFeet) => UnitConverters.USSurveyFeetToMeters((decimal)usFeet);
    }
}
