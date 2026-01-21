using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

     [TestCase(37.2,98.7)]
    [TestCase(0, 32)]
    [TestCase(100, 212)]
    [TestCase(-40, -40)]
    public void CelsiusToFahrenheit_ShouldReturnCorrectValue(
        double celsius, double expectedFahrenheit)
    {
        double result = converter.CelsiusToFahrenheit(celsius);

        Assert.AreEqual(expectedFahrenheit, result);
    }

    [TestCase(32, 0)]
    [TestCase(212, 100)]
    [TestCase(-40, -40)]
    public void FahrenheitToCelsius_ShouldReturnCorrectValue(
        double fahrenheit, double expectedCelsius)
    {
        double result = converter.FahrenheitToCelsius(fahrenheit);

        Assert.AreEqual(expectedCelsius, result);
    }
}
