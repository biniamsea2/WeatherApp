using System;

namespace WeatherApplication.Models
{
    public class DayForecastModel
    {
        public DateTime applicable_date { get; set; }
        public string weather_state_name { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
        public float the_temp { get; set; }
        //getting the temp as celsius from json file, now converting it to fahrenheit
        public int max_tempF => 32 + (int)(max_temp / 0.5556);
        public int min_tempF => 32 + (int)(min_temp / 0.5556);
        public int the_tempF => 32 + (int)(the_temp / 0.5556);

    }

}
