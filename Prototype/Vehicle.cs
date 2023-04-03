using PatternPrototype;

namespace Prototype
{
    /// <summary>
    /// Базовый класс - транспортное средство - для классов Car и ElectroCar
    /// </summary>
    
    public class Vehicle : IMyCloneable<Vehicle>, ICloneable
    {
        public string Name;
        public Vehicle(string name)
        {
            Name = name;
        }

        public virtual Vehicle MyClone()
        {
            Vehicle vehicle= new Vehicle(Name);
            return vehicle;
        }

        public virtual object Clone()
        {
            return MyClone();
        }
    }
}