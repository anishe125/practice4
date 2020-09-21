using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaircutTamplate
{
    class WomanHaircut :Haircut
    {
        public WomanHaircut() { }
        public override void Progress()
        {
            Name = "Стильная";
            Cost = 1000;
            Console.WriteLine("{0} стрижка всего за {1} рублей!", Name, Cost);
        }
    }
}
