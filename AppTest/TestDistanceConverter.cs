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
            converter.FromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.FEET;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.toDistance, 5280);
        }
    }
}
