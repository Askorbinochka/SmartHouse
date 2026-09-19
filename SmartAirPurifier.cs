using System;
namespace SmartHome;

// Очищувач повітря, реагує на рівень пилу
public class SmartAirPurifier : ISmartDevice
{
    public string Name => "Очищувач Повітря «PureAir»";

    public void OnClimateChanged(ClimateData climate)
    {
        if (climate.AirQuality > 50)
        {
            Console.WriteLine($"[{Name}]: Багато пилу ( {climate.AirQuality}), вмикаю очищення! ");
        }
        else
        {
            Console.WriteLine($"[{Name}]: Повітря чисте, просто ароматизую лавандою ");
        }
    }
}
