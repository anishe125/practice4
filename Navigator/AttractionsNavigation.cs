using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class AttractionsNavigation : StrategyNavigation
    {
        public AttractionsNavigation()
        {
            Title = "Маршруты посещения достопремечательностей";
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
