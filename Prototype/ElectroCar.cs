using PatternPrototype;

namespace Prototype
{
    /// <summary>
    /// Класс ElectroCar - наследник Car
    /// </summary>
    public class ElectroCar : Car, IMyCloneable<ElectroCar>, ICloneable
    {
        public string Type;
        public ElectroCar(string name, string model, string type) : base(name, model)
        {
            Type = type;
        }

        public override ElectroCar MyClone()
        {
            ElectroCar electroCar = new ElectroCar(Name, Model,Type);
            return electroCar;
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}