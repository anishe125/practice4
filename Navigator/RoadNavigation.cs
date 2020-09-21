using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class RoadNavigation : StrategyNavigation
    {
        public RoadNavigation()
        {
            Title = "Маршруты по автодорогам";
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
