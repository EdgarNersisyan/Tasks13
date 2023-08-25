using System;

namespace CustomTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a Temperature class that stores temperature in Celsius.
            Implement an explicit conversion operator to convert Celsius to Fahrenheit. 
            Create a Length struct that stores length in meters. Implement an implicit 
            conversion operator to convert meters to feet.*/

            Temperature celsiusTemp = new Temperature(10);
            FahrenheitTemp fahrenheitTemp = (FahrenheitTemp)celsiusTemp;

            Console.WriteLine($"Temperature in Celsius is {celsiusTemp.Celsius} deg");
            Console.WriteLine($"Temperature in Farenheit is {fahrenheitTemp.Fahrenheit} deg");

            Distance dist = new Distance(10);
            DistanceInFeet distanceInFeet = (DistanceInFeet)dist;

            Console.WriteLine($"Distance in meters is {dist.length} meters");
            Console.WriteLine($"Distance in feet is {distanceInFeet.length} feet");


            Console.ReadLine();
        }
    }
}
