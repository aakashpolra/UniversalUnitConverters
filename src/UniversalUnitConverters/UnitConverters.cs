using System;

namespace UniversalUnitConverters
{
    public static class UnitConverters
    {
        private static class Constants
        {
            // Trigonometric and Geometric constants
            public const decimal Pi = 3.1415926535897932384626433833m; // 28 decimal places
            public const decimal TwoPi = 2 * Pi;
            public const decimal TotalDegrees = 360m;
            public const decimal DegreesToRadians = Pi / 180;

            // Distance constants
            public const decimal MilesToKilometers = 1.609344m;
            public const decimal MilesToMeters = 1609.344m;
            public const decimal KilometersToMiles = 1.0m / MilesToKilometers;

            // Weight constants
            public const decimal PoundsToKg = 0.45359237m;
            public const decimal PoundsToStones = 0.07142857m;
            public const decimal StonesToPounds = 14m;
            public const decimal KgToPounds = 2.2046226218487757m;

            // Pressure constants
            public const decimal AtmospherePascals = 101325m;

            // Temperature constants
            public const decimal CelsiusToKelvin = 273.15m;

            // Earth radius constant
            public const decimal MeanEarthRadiusInKilometers = 6371m;

            // Foot definitions
            public const decimal InternationalFootDefinition = 0.3048m;
            public const decimal UsSurveyFootDefinition = 1200m / 3937;
        }

        // Distance conversions
        /// <summary>
        /// Converts miles to kilometers.
        /// </summary>
        public static decimal MilesToKilometers(decimal miles) => miles * Constants.MilesToKilometers;

        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        public static decimal KilometersToMiles(decimal kilometers) => kilometers * Constants.KilometersToMiles;

        /// <summary>
        /// Converts miles to meters.
        /// </summary>
        public static decimal MilesToMeters(decimal miles) => miles * Constants.MilesToMeters;

        /// <summary>
        /// Converts degrees to radians.
        /// </summary>
        public static decimal DegreesToRadians(decimal degrees) => degrees * Constants.DegreesToRadians;

        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        public static decimal RadiansToDegrees(decimal radians) => radians / Constants.DegreesToRadians;

        // Weight conversions
        /// <summary>
        /// Converts pounds to kilograms.
        /// </summary>
        public static decimal PoundsToKilograms(decimal pounds) => pounds * Constants.PoundsToKg;

        /// <summary>
        /// Converts pounds to stones.
        /// </summary>
        public static decimal PoundsToStones(decimal pounds) => pounds * Constants.PoundsToStones;

        /// <summary>
        /// Converts stones to pounds.
        /// </summary>
        public static decimal StonesToPounds(decimal stones) => stones * Constants.StonesToPounds;

        /// <summary>
        /// Converts kilograms to pounds.
        /// </summary>
        public static decimal KilogramsToPounds(decimal kilograms) => kilograms * Constants.KgToPounds;

        // Temperature conversions
        /// <summary>
        /// Converts Celsius to Fahrenheit.
        /// </summary>
        public static decimal CelsiusToFahrenheit(decimal celsius) => celsius * 1.8m + 32.0m;

        /// <summary>
        /// Converts Fahrenheit to Celsius.
        /// </summary>
        public static decimal FahrenheitToCelsius(decimal fahrenheit) => (fahrenheit - 32.0m) / 1.8m;

        /// <summary>
        /// Converts Celsius to Kelvin.
        /// </summary>
        public static decimal CelsiusToKelvin(decimal celsius) => celsius + Constants.CelsiusToKelvin;

        /// <summary>
        /// Converts Kelvin to Celsius.
        /// </summary>
        public static decimal KelvinToCelsius(decimal kelvin) => kelvin - Constants.CelsiusToKelvin;

        // Speed conversions
        /// <summary>
        /// Converts degrees per second to radians per second.
        /// </summary>
        public static decimal DegreesPerSecondToRadiansPerSecond(decimal degrees) => HertzToRadiansPerSecond(DegreesPerSecondToHertz(degrees));

        /// <summary>
        /// Converts radians per second to degrees per second.
        /// </summary>
        public static decimal RadiansPerSecondToDegreesPerSecond(decimal radians) => HertzToDegreesPerSecond(RadiansPerSecondToHertz(radians));

        /// <summary>
        /// Converts degrees per second to Hertz.
        /// </summary>
        public static decimal DegreesPerSecondToHertz(decimal degrees) => degrees / Constants.TotalDegrees;

        /// <summary>
        /// Converts radians per second to Hertz.
        /// </summary>
        public static decimal RadiansPerSecondToHertz(decimal radians) => radians / Constants.TwoPi;

        /// <summary>
        /// Converts Hertz to degrees per second.
        /// </summary>
        public static decimal HertzToDegreesPerSecond(decimal hertz) => hertz * Constants.TotalDegrees;

        /// <summary>
        /// Converts Hertz to radians per second.
        /// </summary>
        public static decimal HertzToRadiansPerSecond(decimal hertz) => hertz * Constants.TwoPi;

        // Pressure conversions
        /// <summary>
        /// Converts kilopascals to hectopascals.
        /// </summary>
        public static decimal KilopascalsToHectopascals(decimal kpa) => kpa * 10.0m;

        /// <summary>
        /// Converts hectopascals to kilopascals.
        /// </summary>
        public static decimal HectopascalsToKilopascals(decimal hpa) => hpa / 10.0m;

        /// <summary>
        /// Converts kilopascals to pascals.
        /// </summary>
        public static decimal KilopascalsToPascals(decimal kpa) => kpa * 1000.0m;

        /// <summary>
        /// Converts hectopascals to pascals.
        /// </summary>
        public static decimal HectopascalsToPascals(decimal hpa) => hpa * 100.0m;

        /// <summary>
        /// Converts atmospheres to pascals.
        /// </summary>
        public static decimal AtmospheresToPascals(decimal atm) => atm * Constants.AtmospherePascals;

        /// <summary>
        /// Converts pascals to atmospheres.
        /// </summary>
        public static decimal PascalsToAtmospheres(decimal pascals) => pascals / Constants.AtmospherePascals;

        // Distance calculations
        /// <summary>
        /// Calculates the distance between two coordinates in miles.
        /// </summary>
        public static decimal CoordinatesToMiles(decimal lat1, decimal lon1, decimal lat2, decimal lon2) => KilometersToMiles(CoordinatesToKilometers(lat1, lon1, lat2, lon2));

        /// <summary>
        /// Calculates the distance between two coordinates in kilometers.
        /// </summary>
        public static decimal CoordinatesToKilometers(decimal lat1, decimal lon1, decimal lat2, decimal lon2)
        {
            if (lat1 == lat2 && lon1 == lon2)
                return 0;

            var dLat = DegreesToRadians(lat2 - lat1);
            var dLon = DegreesToRadians(lon2 - lon1);

            lat1 = DegreesToRadians(lat1);
            lat2 = DegreesToRadians(lat2);

            var dLat2 = Math.Sin((double)(dLat / 2)) * Math.Sin((double)(dLat / 2));
            var dLon2 = Math.Sin((double)(dLon / 2)) * Math.Sin((double)(dLon / 2));

            var a = dLat2 + dLon2 * Math.Cos((double)lat1) * Math.Cos((double)lat2);
            var c = 2 * Math.Asin(Math.Sqrt(a));

            return Constants.MeanEarthRadiusInKilometers * (decimal)c;
        }

        // Foot conversions
        /// <summary>
        /// Converts meters to international feet.
        /// </summary>
        public static decimal MetersToInternationalFeet(decimal meters) => meters / Constants.InternationalFootDefinition;

        /// <summary>
        /// Converts international feet to meters.
        /// </summary>
        public static decimal InternationalFeetToMeters(decimal internationalFeet) => internationalFeet * Constants.InternationalFootDefinition;

        /// <summary>
        /// Converts meters to US survey feet.
        /// </summary>
        public static decimal MetersToUSSurveyFeet(decimal meters) => meters / Constants.UsSurveyFootDefinition;

        /// <summary>
        /// Converts US survey feet to meters.
        /// </summary>
        public static decimal USSurveyFeetToMeters(decimal usFeet) => usFeet * Constants.UsSurveyFootDefinition;

        // Double overloads
        public static double MilesToKilometers(double miles) => (double)MilesToKilometers((decimal)miles);
        public static double KilometersToMiles(double kilometers) => (double)KilometersToMiles((decimal)kilometers);
        public static double CelsiusToFahrenheit(double celsius) => (double)CelsiusToFahrenheit((decimal)celsius);
        public static double FahrenheitToCelsius(double fahrenheit) => (double)FahrenheitToCelsius((decimal)fahrenheit);
        public static double CelsiusToKelvin(double celsius) => (double)CelsiusToKelvin((decimal)celsius);
        public static double KelvinToCelsius(double kelvin) => (double)KelvinToCelsius((decimal)kelvin);
        public static double MilesToMeters(double miles) => (double)MilesToMeters((decimal)miles);
        public static double DegreesToRadians(double degrees) => (double)DegreesToRadians((decimal)degrees);
        public static double RadiansToDegrees(double radians) => (double)RadiansToDegrees((decimal)radians);
        public static double PoundsToKilograms(double pounds) => (double)PoundsToKilograms((decimal)pounds);
        public static double PoundsToStones(double pounds) => (double)PoundsToStones((decimal)pounds);
        public static double StonesToPounds(double stones) => (double)StonesToPounds((decimal)stones);
        public static double KilogramsToPounds(double kilograms) => (double)KilogramsToPounds((decimal)kilograms);
        public static double DegreesPerSecondToRadiansPerSecond(double degrees) => (double)DegreesPerSecondToRadiansPerSecond((decimal)degrees);
        public static double RadiansPerSecondToDegreesPerSecond(double radians) => (double)RadiansPerSecondToDegreesPerSecond((decimal)radians);
        public static double DegreesPerSecondToHertz(double degrees) => (double)DegreesPerSecondToHertz((decimal)degrees);
        public static double RadiansPerSecondToHertz(double radians) => (double)RadiansPerSecondToHertz((decimal)radians);
        public static double HertzToDegreesPerSecond(double hertz) => (double)HertzToDegreesPerSecond((decimal)hertz);
        public static double HertzToRadiansPerSecond(double hertz) => (double)HertzToRadiansPerSecond((decimal)hertz);
        public static double KilopascalsToHectopascals(double kpa) => (double)KilopascalsToHectopascals((decimal)kpa);
        public static double HectopascalsToKilopascals(double hpa) => (double)HectopascalsToKilopascals((decimal)hpa);
        public static double KilopascalsToPascals(double kpa) => (double)KilopascalsToPascals((decimal)kpa);
        public static double HectopascalsToPascals(double hpa) => (double)HectopascalsToPascals((decimal)hpa);
        public static double AtmospheresToPascals(double atm) => (double)AtmospheresToPascals((decimal)atm);
        public static double PascalsToAtmospheres(double pascals) => (double)PascalsToAtmospheres((decimal)pascals);
        public static double CoordinatesToMiles(double lat1, double lon1, double lat2, double lon2) => (double)CoordinatesToMiles((decimal)lat1, (decimal)lon1, (decimal)lat2, (decimal)lon2);
        public static double CoordinatesToKilometers(double lat1, double lon1, double lat2, double lon2) => (double)CoordinatesToKilometers((decimal)lat1, (decimal)lon1, (decimal)lat2, (decimal)lon2);
        public static double MetersToInternationalFeet(double meters) => (double)MetersToInternationalFeet((decimal)meters);
        public static double InternationalFeetToMeters(double internationalFeet) => (double)InternationalFeetToMeters((decimal)internationalFeet);
        public static double MetersToUSSurveyFeet(double meters) => (double)MetersToUSSurveyFeet((decimal)meters);
        public static double USSurveyFeetToMeters(double usFeet) => (double)USSurveyFeetToMeters((decimal)usFeet);

        // Int overloads
        public static decimal MilesToKilometers(int miles) => MilesToKilometers((decimal)miles);
        public static decimal KilometersToMiles(int kilometers) => KilometersToMiles((decimal)kilometers);
        public static decimal CelsiusToFahrenheit(int celsius) => CelsiusToFahrenheit((decimal)celsius);
        public static decimal FahrenheitToCelsius(int fahrenheit) => FahrenheitToCelsius((decimal)fahrenheit);
        public static decimal CelsiusToKelvin(int celsius) => CelsiusToKelvin((decimal)celsius);
        public static decimal KelvinToCelsius(int kelvin) => KelvinToCelsius((decimal)kelvin);
        public static decimal MilesToMeters(int miles) => MilesToMeters((decimal)miles);
        public static decimal DegreesToRadians(int degrees) => DegreesToRadians((decimal)degrees);
        public static decimal RadiansToDegrees(int radians) => RadiansToDegrees((decimal)radians);
        public static decimal PoundsToKilograms(int pounds) => PoundsToKilograms((decimal)pounds);
        public static decimal PoundsToStones(int pounds) => PoundsToStones((decimal)pounds);
        public static decimal StonesToPounds(int stones) => StonesToPounds((decimal)stones);
        public static decimal KilogramsToPounds(int kilograms) => KilogramsToPounds((decimal)kilograms);
        public static decimal DegreesPerSecondToRadiansPerSecond(int degrees) => DegreesPerSecondToRadiansPerSecond((decimal)degrees);
        public static decimal RadiansPerSecondToDegreesPerSecond(int radians) => RadiansPerSecondToDegreesPerSecond((decimal)radians);
        public static decimal DegreesPerSecondToHertz(int degrees) => DegreesPerSecondToHertz((decimal)degrees);
        public static decimal RadiansPerSecondToHertz(int radians) => RadiansPerSecondToHertz((decimal)radians);
        public static decimal HertzToDegreesPerSecond(int hertz) => HertzToDegreesPerSecond((decimal)hertz);
        public static decimal HertzToRadiansPerSecond(int hertz) => HertzToRadiansPerSecond((decimal)hertz);
        public static decimal KilopascalsToHectopascals(int kpa) => KilopascalsToHectopascals((decimal)kpa);
        public static decimal HectopascalsToKilopascals(int hpa) => HectopascalsToKilopascals((decimal)hpa);
        public static decimal KilopascalsToPascals(int kpa) => KilopascalsToPascals((decimal)kpa);
        public static decimal HectopascalsToPascals(int hpa) => HectopascalsToPascals((decimal)hpa);
        public static decimal AtmospheresToPascals(int atm) => AtmospheresToPascals((decimal)atm);
        public static decimal PascalsToAtmospheres(int pascals) => PascalsToAtmospheres((decimal)pascals);
        public static decimal CoordinatesToMiles(int lat1, int lon1, int lat2, int lon2) => CoordinatesToMiles((decimal)lat1, (decimal)lon1, (decimal)lat2, (decimal)lon2);
        public static decimal CoordinatesToKilometers(int lat1, int lon1, int lat2, int lon2) => CoordinatesToKilometers((decimal)lat1, (decimal)lon1, (decimal)lat2, (decimal)lon2);
        public static decimal MetersToInternationalFeet(int meters) => MetersToInternationalFeet((decimal)meters);
        public static decimal InternationalFeetToMeters(int internationalFeet) => InternationalFeetToMeters((decimal)internationalFeet);
        public static decimal MetersToUSSurveyFeet(int meters) => MetersToUSSurveyFeet((decimal)meters);
        public static decimal USSurveyFeetToMeters(int usFeet) => USSurveyFeetToMeters((decimal)usFeet);
    }
}
