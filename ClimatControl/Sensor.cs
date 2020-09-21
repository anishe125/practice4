using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatControl
{
    class Sensor : ISensor
    {
        Random r;
        int min = -148;
        int max = 212;

        public Sensor()
        {
            r = new Random();
        }

        public double GetTemp()
        {
            return (double)r.Next(min , max );
        }

    }
}
