using System;

namespace WeatherAppV3
{
    class CityWeather
    {
        public string Name { get; set; }
        public string WeatherType { get; set; }
        public string WeatherDescription { get; set; }
        public double TempC { get; set; }
        public double TempF { get; set; }
        public double Pressure { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int Cloudiness { get; set; }
        public CityWeather(string name, string weatherType, string weatherDescription, double tempC, double tempF, double pressure, int humidity, double windSpeed, int cloudiness)
        {
            this.Name = name;
            this.WeatherType = weatherType;
            this.WeatherDescription = weatherDescription;
            this.TempC = tempC;
            this.TempF = tempF;
            this.Pressure = pressure;
            this.Humidity = humidity;
            this.WindSpeed = windSpeed;
            this.Cloudiness = cloudiness;
        }
        public void ShowCityWeatherInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("City: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Weather type: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(WeatherType);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Weather Description: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(WeatherDescription);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Temperature in C: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(TempC);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Temperature in F: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(TempF);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Pressure: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Pressure + "hPa");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Humidity: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Humidity + "%");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Wind Speed: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(WindSpeed + " meters/sec");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Cloudiness: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Cloudiness + "%");
        }
    }
}
