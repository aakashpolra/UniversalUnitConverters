# UniversalUnitConverters

UniversalUnitConverters is a widely compatible .NET library for unit conversions, inspired by .NET MAUI's UnitConverters class.
This library includes conversions for distance, temperature, weight, speed, and more.

## Features

- Convert between miles and kilometers, meters, and feet
- Convert temperatures between Celsius, Fahrenheit, and Kelvin
- Convert weights between pounds, kilograms, and stones
- Convert angles between degrees and radians
- Convert speed units and more
- Higher precision conversion using decimal numeric type
- Extension methods for numeric types such as int, decimal, and double

## Installation

To install UniversalUnitConverters, run the following command in the Package Manager Console:

```powershell
Install-Package UniversalUnitConverters
```
Or add the following line to your .csproj file:
```xml
<PackageReference Include="UniversalUnitConverters" Version="1.0.0" />
```

## Usage
Here's how to use the library:
```csharp
using UniversalUnitConverters;

// ...
double miles = UnitConverters.KilometersToMiles(322.55);
decimal radians = UnitConverters.DegreesToRadians(38.3m);
// etc...
```

And you can use friendly numeric extensions too:
```csharp
using UniversalUnitConverters.Extensions;

// ...
double kilometers = 5.3.MilesToKilometers();
decimal fahrenheit = 37.7m.CelsiusToFahrenheit();
decimal feet = 100.MetersToInternationalFeet();
// etc...
```

## Contributing
Contributions are welcome! Please open an issue or submit a pull request on GitHub.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
