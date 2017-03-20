using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight_csharp6_from_scratch
{
    class StaticDemoProgram
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit: ");
                selection = Console.ReadLine();
                double fah = 0, cel = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temp: ");
                        fah = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {fah:f2}");
                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit temp: ");
                        cel = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {cel:f2}");
                        break;

                    case "q":
                    case "Q":
                        break;

                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }
    }


    class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fah = Double.Parse(tempFahrenheit);
            double cel = (fah - 32) * 5 / 9;
            return cel;
        }
    }
}
