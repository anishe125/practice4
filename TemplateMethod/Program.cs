using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Начало: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Шаг: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Progression val = new ArithmeticProgression(f, l, h);
            val.TemplateMethod();
            val = new GeometricProgression(f, l, h);
            val.TemplateMethod();
        }
    }
}
