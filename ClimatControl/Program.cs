using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor sensorF = new Sensor();
            Control control = new Control();
            Adapter adapter = new Adapter(sensorF);
            Console.WriteLine("Температура: {0}°C", control.SeansControl(adapter));
            Console.ReadLine();

        }
    }
}
