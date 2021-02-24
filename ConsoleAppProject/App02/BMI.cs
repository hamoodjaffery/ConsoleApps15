using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Hamood Jaffery
    /// </author>
    public class BMI
    {
        public enum UnitTypes
        {
            Metric,
            Imperial
        }

        // Weight Constants
        public const double HIGHEST_UNDERWEIGHT = 18.50;
        
        // Height Constants
        public const int INCHES_IN_FEET = 12;

        // Variables
        private double kilograms;

        private double meters;
        private double pounds;
        private double stones;
        private double feet;
        private double inches;

        private double index;

        private UnitTypes unitType = UnitTypes.Metric;

        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            
            // Offer the user a choice of metric or imperial

            if(unitType == UnitTypes.Metric)
            {
                InputMetricMeasurements();
            }
            else
            {
                InputImperialMeasurements();
            }

            CaluclateBMI_Index();
            OutputHealthStatus();
            OutputBAME_Message();
        }
        /// <summary>
        /// This method will prompt the user to enter their
        /// height and weight in metres and kilograms
        /// </summary>
        public void InputMetricMeasurements()
        {

        }

        public void InputImperialMeasurements()
        {

        }

        public void CaluclateBMI_Index()
        {

        }

        public void OutputHealthStatus()
        {

        }

        public void OutputBAME_Message()
        {

        }
    }
}
