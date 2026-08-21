using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class TemperatureConvertor
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
