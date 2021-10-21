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
            Console.WriteLine("City: " + Name + ", Weather Type: " + WeatherType + ", Weather Description: " + WeatherDescription + ", Temperature in C: " + TempC + ", Temperature in F: " + TempF + ", Pressure: " + Pressure + "hPa, Humidity: " + Humidity + "%, Wind Speed: " + WindSpeed + "meters/sec, Cloudiness: " + Cloudiness + "%");
        }
    }
}
