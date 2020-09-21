using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class Context
    {
        StrategyNavigation strategy;
        string navigationType;
        string dist;
        public Context(StrategyNavigation strategy,string actionType, string dist)
        {
            this.strategy = strategy;
            this.navigationType = actionType;
            this.dist = dist;
        }
        public void Navigate()
        {
            strategy.Navigate(navigationType, dist);
        }
        public void Show()
        {
            Console.WriteLine(strategy.ToString());
        }
    }
}

