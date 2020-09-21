using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatControl
{
    class Adapter: ISensor
    {
        private Sensor sensorF;


        public Adapter(Sensor sensor)
        {
            sensorF = sensor;
        }


        public double GetTemp()
        {
            return celsiusToFahr(sensorF.GetTemp());
        }

        private double celsiusToFahr(double fahr)
        {
            Console.WriteLine("Температура F = {0}", fahr);
            return Math.Round((fahr - 32)  / 1.8);
        }
    }
}
