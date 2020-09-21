using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FordFactory : CarFactory
    {
        private FordFactory() { }

        static Lazy<FordFactory> myFordFactory = new Lazy<FordFactory>(() => new FordFactory());
        public static FordFactory MyFordFactory
        {
            get
            {
                return myFordFactory.Value;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstractCarBody CreateCarBody()
        {
            return new FordCarBody();
        }
    }

    class FordCar : AbstractCar
    {
        public FordCar(string name)
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
        public override string BodyType( AbstractCarBody carBody)
        {
            string bodyName = carBody.bodyType;
            return "Тип кузова " + bodyName;

        }
    }

    class FordEngine : AbstractEngine
    {
        public FordEngine()
        {
            max_speed = 220;
        }
    }

    class FordCarBody : AbstractCarBody
    {
        public FordCarBody()
        {
            bodyType = "Sedan";
        }
    }
}
