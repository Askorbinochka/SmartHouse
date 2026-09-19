using System;
namespace SmartHome;

// Розумна підсвітка, яка змінює колір залежно від температури
public class SmartRgbLight : ISmartDevice
{
    public string Name => "RGB-Підсвітка «Atmosphere»";

    public void OnClimateChanged(ClimateData climate)
    {
        if (climate.Temperature > 25)
        {
            Console.WriteLine($"[{Name}]: Спекотно, вмикаю синє світло ");
        }
        else if (climate.Temperature < 18)
        {
            Console.WriteLine($"[{Name}]: Прохолодно, вмикаю тепле помаранчеве ");
        }
        else
        {
            Console.WriteLine($"[{Name}]: Температура хороша, свічу білим ");
        }
    }
}