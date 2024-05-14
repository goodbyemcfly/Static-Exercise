using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;
            return result;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            var result = (celcius * 1.8) + 32;
            return result;
        }
    }
}
