using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
           test_car = new Car("Toyota", "Prius", 10, 50);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
