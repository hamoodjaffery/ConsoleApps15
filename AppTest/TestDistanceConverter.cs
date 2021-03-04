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
            Assert.AreEqual(converter.ToDistance, 1609.34);
        }
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 0.000189394);
        }
        public void TestFeetToMeters()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 0.3048);
        }
        public void TestMetersToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 0.000621371);
        }
        public void TestMetersToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromDistance = 1.0;

            converter.ConvertDistance();
            Assert.AreEqual(converter.ToDistance, 3.28);
        }
    }
}
