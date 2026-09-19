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
        SmartBlinds blind = new SmartBlinds();

        Console.WriteLine(" Підключаємо всі пристрої ");
        controller.Connect(rgbLight);
        controller.Connect(blind);  


    }
}