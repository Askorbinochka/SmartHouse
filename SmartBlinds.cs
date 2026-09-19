using System;
namespace SmartHome;

// Жалюзі, які закриваються від сонця при спеці
public class SmartBlinds : ISmartDevice
{
    public string Name => "Розумні Жалюзі";
    public void OnClimateChanged(ClimateData climate)
    {
        if (climate.Temperature >= 26)
        {
            Console.WriteLine($"  [{Name}]: На вулиці спека, закриваю жалюзі!");
        }
        else
        {
            Console.WriteLine($"  [{Name}]: Погода приємна, відкриваю жалюзі.");
        }
    }
}