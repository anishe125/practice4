using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class SoberTransCom: TransportCompany
    {
        public SoberTransCom(string name)
        : base(name)
        { }
        public override TransportService Create(string n, int c)
        {
            return new TaxiServices(Name, c);
        }
    }
}
