using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"),
            "Безопасность");
            Print(newmyReno);

            Мercedes mers = new Мercedes("Мерседес", "Mercedes E 200 d Premium", 30000.0);
            Print(mers);
            AutoBase mersPlus = new AirBalance(mers, "Аромо");
            Print(mersPlus);
            AutoBase mersPlusPlus = new Acoustics(mersPlus,    "Звукоизоляция");
            Print(mersPlusPlus);

            Console.Read();
        
        
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
