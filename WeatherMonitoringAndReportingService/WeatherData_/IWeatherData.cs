﻿

namespace WeatherMonitoringAndReportingService.WeatherData_
{
    public interface IWeatherData
    {
        string Location { get; set; }
        decimal Temperature { get; set; }
        decimal Humidity { get; set; }


    }
}
