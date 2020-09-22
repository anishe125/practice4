using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Acoustics : DecoratorOptions
    {
        public Acoustics(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Акустический";
            Description = p.Description + ". " + this.Title + ". Повышенная звукоизоляция";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 8.99;
        }
    }
}
