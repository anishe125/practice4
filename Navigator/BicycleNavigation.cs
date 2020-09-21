using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class BicycleNavigation : StrategyNavigation
    {
        public BicycleNavigation()
        {
            Title = "Веломаршруты";
        }
        public override string ToString()
        {
            return Title;
        }
        public override void Navigate(string type, string dist)
        {

        }
    }
}
