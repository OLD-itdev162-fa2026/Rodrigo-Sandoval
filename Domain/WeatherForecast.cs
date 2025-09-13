namespace Domain;

public class WeatherForecast
{
    public int Id { get; set; } // Primary key
    public DateOnly Date { get; set; } // Use DateOnly with getter and setter
    public int TemperatureC { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    public string? Summary { get; set; }
}