using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static void FahrenheitToCelsius(double fahrenheit)
        {
            Console.WriteLine($"Temperature converted to Celcius: {(fahrenheit - 32) / 1.8}");
        }

        public static void CelsiusToFahrenheit(double celsius)
        {
            Console.WriteLine($"Temperature converted to Fahrenheit: {(celsius * 9) / 5 + 32}");
        }

    }
}
