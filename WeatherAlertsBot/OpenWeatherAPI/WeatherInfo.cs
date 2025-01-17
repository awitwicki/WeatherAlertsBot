﻿using System.Text.Json.Serialization;

namespace WeatherAlertsBot.OpenWeatherAPI;

/// <summary>
///     Class which represents current weather from OpenWeatherAPI Current Weather
/// </summary>
public sealed class WeatherInfo
{
    /// <summary>
    ///     Type of weather by coordinates
    /// </summary>
    [JsonPropertyName("main")]
    public string TypeOfWeather { get; set; }
}
