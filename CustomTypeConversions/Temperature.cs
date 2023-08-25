using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypeConversions
{
    class Temperature
    {
        public double celsius;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }

        public Temperature(double celsius)
        {
            this.celsius = celsius;
        }

        public static explicit operator FahrenheitTemp(Temperature celsiusTemp)
        {
            double fahrenheit = (celsiusTemp.Celsius * 9 / 5) + 32;
            return new FahrenheitTemp(fahrenheit);
        }
    }

    class FahrenheitTemp
    {
        public double fahrenheit;

        public double Fahrenheit
        {
            get { return fahrenheit; }
            set { fahrenheit = value; }
        }

        public FahrenheitTemp(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }
    }
}
