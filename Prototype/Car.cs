using PatternPrototype;

namespace Prototype
{
    /// <summary>
    /// Класс Car - наследник Vehicle(транспортное средство)
    /// </summary>
    public class Car : Vehicle, IMyCloneable<Car>, ICloneable
    {
        public string Model;

        public Car(string name, string model) : base(name)
        {
            Model = model;
        }

        public override Car MyClone()
        {
            Car car = new Car(Name, Model);
            return car;
        }

        public override object Clone()
        {
            return MyClone();
        }

    }
}