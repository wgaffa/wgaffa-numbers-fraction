![GitHub](https://img.shields.io/github/license/wgaffa/wgaffa-numbers-fraction)
![Nuget](https://img.shields.io/nuget/v/Wgaffa.Numbers.Fraction)

# Fractions
Fractions is a basic library to be able to calculate and represent fractions. All fractions are in its simples form.

## Installation
```
Install-Package Wgaffa.Numbers.Fraction
```

## Using fractions
Everything resides in the namespace `Wgaffa.Numbers`, so use this when you wish to use this library.
```csharp
using Wgaffa.Numbers;
```

Create some simple fractions.
```csharp
var aFourth = new Fraction(1, 4); // 1/4
var oneAndEights = new Fraction(9, 8); // 1 1/8
var negativeFraction = new Fraction(-2, 3); // -2/3
var simplestForm = new Fraction(5, 10); // 1/2
```

To create mixed fractions with addition operator.
```csharp
var mixedFraction = new Fraction(1, 4) + 5; // 5 1/4
```

`ToString()` will return a mixed fraction, e.g.
```csharp
var mixedFraction = new Fraction(5, 2);
Console.WriteLine(mixedFraction); // Output: 2 1/2
```

If you want to print out the improper fraction you have to use the properties `Numerator` and `Denominator`.
```csharp
var mixedFraction = new Fraction(8, 3);
Console.WriteLine($"{mixedFraction.Numerator}/{mixedFraction.Denominator}"); // Output: 8/3
```

Using the previous examples you can use the operators `+ - * /` on fractions and integers.
```csharp
var addition = aFourth + simplestForm; // 3/4
var subtraction = oneAndEights - aFourth; // 7/8
var multiplication = negativeFraction * aFourth; // -1/6
var division = simplestForm / aFourth; // 2
```