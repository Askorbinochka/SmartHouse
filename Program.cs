using System.Text;
using SmartHome;

namespace SmartHome;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Створюємо контролер і пристрої
        ClimateController controller = new ClimateController();
        SmartRgbLight rgbLight = new SmartRgbLight();
        SmartBlinds blinds = new SmartBlinds();
        SmartAirPurifier airPurifier = new SmartAirPurifier();  

        Console.WriteLine("Підключаємо всі пристрої ");
        controller.Connect(rgbLight);
        controller.Connect(blinds);  
        controller.Connect(airPurifier);

        controller.UpdateClimate(temp: 28.0, humidity: 45.0, aqi: 75);

        Console.WriteLine("Відключаємо жалюзі ");
        controller.Disconnect(blinds);

        controller.UpdateClimate(temp: 16.5, humidity: 50.0, aqi: 20);

        Console.WriteLine("Підключаємо жалюзі назад");
        controller.Connect(blinds);
        controller.UpdateClimate(temp: 22.0, humidity: 40.0, aqi: 15);

    }
}