using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class TestDistanceConverter
    {

        
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 5280);
        }

        public void TestMilesToMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 1609.1);
        }
    }
}
