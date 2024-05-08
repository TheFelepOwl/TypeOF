using System;
using System.Collections.Generic;

public class Coordinates
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public enum SensorSignal
{
    Moisture,
    Temperature,
    Light
}

public class SensorData
{
    public SensorSignal Signal_type { get; set; }
    public double Value { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // Приклад використання Coordinates
        Coordinates place = new Coordinates { Latitude = 40.7128, Longitude = -74.0060 };
        Console.WriteLine($"Координати: {place.Latitude}, {place.Longitude}");

        

        // Приклад використання SensorData
        SensorData date_temperature = new SensorData { Signal_type = SensorSignal.Temperature, Value = 25.5 };
        Console.WriteLine($"Данi датчика: Тип сигналу - {date_temperature.Signal_type}, Значення - {date_temperature.Value}`C");

        // Приклад використання SensorData
        SensorData date_moisture = new SensorData { Signal_type = SensorSignal.Moisture, Value = 80 };
        Console.WriteLine($"Данi датчика: Тип сигналу - {date_moisture.Signal_type}, Значення - {date_moisture.Value}%");
    }
}
