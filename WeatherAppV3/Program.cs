using System;
using System.Threading;

namespace WeatherAppV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to WeatherApp!");
            while (true)
            {
                Console.WriteLine("Type the city name: ");
                cityName = Console.ReadLine();
            }
        }
    }
}
