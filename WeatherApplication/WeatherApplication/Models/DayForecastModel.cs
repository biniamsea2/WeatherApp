namespace WeatherApplication.Models
{
    public class DayForecastModel
    {
        public string applicable_date { get; set; }
        public string weather_state_name { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
        public float the_temp { get; set; }
    }

}
