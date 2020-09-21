using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaircutTamplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Haircut val = new WomanHaircut();
            val.TemplateMethod();
            val = new ManHaitcut();
            val.TemplateMethod();
            Console.Read();
        }
    }
}
