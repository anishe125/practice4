using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class PublicTransNavigation : StrategyNavigation
    {
        public PublicTransNavigation()
        {
            Title = "Маршруты общественнного транспорта";
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
