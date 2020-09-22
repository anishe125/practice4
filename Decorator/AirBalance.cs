using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AirBalance : DecoratorOptions
    {
        public AirBalance(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Ароматический";
            Description = p.Description + ". " + this.Title + ". Индивидуальная ароматизация салона";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 19.99;
        }
    }
}
