using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaircutTamplate
{
    class ManHaitcut : Haircut
    {
        public ManHaitcut() { }
        public override void Progress()
        {
            Name = "Модная";
            Cost = 100;
            Console.WriteLine("{0} стрижка всего за {1} рублей!",Name,  Cost);
        }
    }
}
