using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiFactory : CarFactory
    {
        private AudiFactory() { }

        static Lazy<AudiFactory> myAudiFactory = new Lazy<AudiFactory>(() => new AudiFactory());
        public static AudiFactory MyAudiFactory
        {
            get
            {
                return myAudiFactory.Value;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
        public override AbstractCarBody CreateCarBody()
        {
            return new AudiCarBody();
        }
    }

    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;

        }
        public override string BodyType(AbstractCarBody carBody)
        {
            string bodyName = carBody.bodyType;
            return "Тип кузова " + bodyName;

        }
    }

    class AudiEngine : AbstractEngine
    {
        public AudiEngine()
        {
            max_speed = 300;
        }
    }
    class AudiCarBody : AbstractCarBody
    {
        public AudiCarBody()
        {
            bodyType = "Hatchback";
        }
    }
}
