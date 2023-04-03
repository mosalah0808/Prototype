using Prototype;


namespace Test_prototype
{
    public class UnitTest1
    {
        [Fact]
        public void Clone_ElectroCar_With_IMyCloneable()
        {
            string name  = "Auto";
            string model = "Truck";
            string type = "Tesla";
            ElectroCar elcar = new ElectroCar(name, model, type);

            ElectroCar elcar2 = elcar.MyClone();

            Assert.NotSame(elcar, elcar2);
            Assert.Equal(elcar.Type, elcar2.Type);
            Assert.Equal(elcar.Name, elcar2.Name);
            Assert.Equal(elcar.Model, elcar2.Model);
        }

        [Fact]
        public void Clone_ElectroCar_With_ICloneable()
        {
            string name = "Auto";
            string model = "Truck";
            string type = "Tesla";
            ElectroCar elcar = new ElectroCar(name, model, type);

            ElectroCar elcar2 = (ElectroCar)elcar.Clone();

            Assert.NotSame(elcar, elcar2);
            Assert.Equal(elcar.Type, elcar2.Type);
            Assert.Equal(elcar.Name, elcar2.Name);
            Assert.Equal(elcar.Model, elcar2.Model);
        }
    }
}