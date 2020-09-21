using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{

        abstract class StrategyNavigation
        {
            public string Title { get; set; }
            public abstract void Navigate(string navigationType, string dist);
        }
    
}
