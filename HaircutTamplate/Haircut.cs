using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaircutTamplate
{
    abstract class Haircut
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        
        public Haircut()
        {
            Cost = 0;
            Name = "";
        }

        public void TemplateMethod()
        {
            GetInfo();
            Progress();
            Pay(Cost);
        }

        private void Pay(int Cost)
        {
            Console.WriteLine("Стоимость: {0}", Cost);

        }
        private void GetInfo()
        {
            Console.WriteLine("Изучить информацию");
        }

        public abstract void Progress();

    }
}
