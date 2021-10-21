using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
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
                Console.WriteLine();
                CityWeather city = GetCityWeatherInfo(cityName);
                if(city == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong city name!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    city.ShowCityWeatherInfo();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Continue - Y/y: ");
                    char key = Convert.ToChar(Console.ReadLine());
                    if (key == 'y' || key == 'Y')
                    {
                        Console.Clear();
                        continue;
                    }
                    else { break; }
                }
            }
        }
        static CityWeather GetCityWeatherInfo(string cityName)
        {
            string weatherInfo = GetCityWeatherInfoFromAPI(cityName);
            if (weatherInfo == null)
            {
                return null;
            }
            else
            {
                return CreateCityWeatherObject(weatherInfo);
            }
        }
        static string GetCityWeatherInfoFromAPI(string cityName)
        {
            string responseFromServer;
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&appid=873d66abe6afeba78f0f084fe606162d");
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        responseFromServer = reader.ReadToEnd();
                    }
                }
                return responseFromServer;
            }
            catch (WebException)
            {
                return null;
            }
        }
        static CityWeather CreateCityWeatherObject(string weatherInfo)
        {
            WeatherAPI.CityWeatherFromAPI cityWeatherData = JsonConvert.DeserializeObject<WeatherAPI.CityWeatherFromAPI>(weatherInfo);
            double tempC = Math.Round(cityWeatherData.main.Temp - 273.15, 2);
            double tempF = Math.Round(((tempC * 1.8) + 32), 2);
            CityWeather city = new CityWeather(cityWeatherData.Name, cityWeatherData.weather[0].Main, cityWeatherData.weather[0].Description, tempC, tempF, cityWeatherData.main.Pressure, cityWeatherData.main.Humidity, cityWeatherData.wind.Speed, cityWeatherData.clouds.All);
            return city;
        }
    }
}
