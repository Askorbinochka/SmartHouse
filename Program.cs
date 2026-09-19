using System.Text;
using SmartHome;

namespace SmartHome;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Створюємо контролер 
        ClimateController controller = new ClimateController();
    }
}