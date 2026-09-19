using System;
namespace SmartHome;

// Головний контролер, який стежить за всіма пристроями
public class ClimateController : IClimateController
{
    // Список пристроїв, які зараз підключені
    private readonly List<ISmartDevice> _devices = new();

    public ClimateData CurrentClimate { get; private set; } = new(20, 50, 10);

    // Додаємо пристрій 
    public void Connect(ISmartDevice device)
    {
        _devices.Add(device);
        Console.WriteLine($"[Контролер] Підключено: {device.Name}");
    }

    // Викреслюємо пристрій зі списку
    public void Disconnect(ISmartDevice device)
    {
        if (_devices.Remove(device))
        {
            Console.WriteLine($" [Контролер] Відключено: {device.Name}");
        }
    }

    // Проходимося по кожному пристрою і передаємо нові дані
    public void NotifyDevices()
    {
        foreach (var device in _devices.ToList())
        {
            device.OnClimateChanged(CurrentClimate);
        }
    }

    // Змінюємо погоду в кімнаті й одразу сповіщаємо всі пристрої
    public void UpdateClimate(double temp, double humidity, int aqi)
    {
        CurrentClimate = new ClimateData(temp, humidity, aqi);
        Console.WriteLine($"\n [Контролер] Нові дані: {temp}°C | {humidity}% | {aqi}");

        // Розсилаємо оновлення всім підключеним
        NotifyDevices();
    }
}