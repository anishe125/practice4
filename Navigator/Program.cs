using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyNavigation sort = new RoadNavigation();
            Context context = new Context(sort, "1", "Дом");
            context.Navigate();
            context.Show();
            Console.Read();
        }
    }
}
