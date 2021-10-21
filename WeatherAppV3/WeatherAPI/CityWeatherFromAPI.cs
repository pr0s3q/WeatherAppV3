using System.Collections.Generic;

namespace WeatherAppV3.WeatherAPI
{
    class CityWeatherFromAPI
    {
        public Coord coord { get; set; }
        public IList<Weather> weather { get; set; }
        public string Base { get; set; }
        public Main main { get; set; }
        public int Visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int Dt { get; set; }
        public Sys sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
