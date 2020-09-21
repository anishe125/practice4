using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatControl
{
    class Control
    {

        public Control() { }

        public double SeansControl(ISensor snsr)
        {
            return snsr.GetTemp();
        }
    }
}
