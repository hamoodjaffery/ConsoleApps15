using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This aap will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609;

        public const double FEET_IN_METERS = 3.281;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        /// <summary>
        /// This method defines the variables for the distance converter
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// This is the main method that will be called as soon as
        /// Distance converter runs
        /// </summary>
        public void Run()

        {
            ConsoleHelper.OutputHeading("Distance Converter App");
                        
            ConvertDistance();
        }

        /// <summary>
        /// This method will Input the distance in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>   
        public void ConvertDistance()
        {
            string[] choices = new string[]
                {
                    FEET, METERS, MILES
                };

            int choice;

            Console.WriteLine("Select the distance unit to convert from >");
            choice = ConsoleHelper.SelectChoice(choices);
            FromUnit = ExecuteChoice(choice);
            
            if (choice == 1)
            {
                Console.WriteLine("You have selected Feet");
            }

            else if (choice == 2)
            {
                Console.WriteLine("You have selected Meters");
            }

            else if (choice == 3)
            {
                Console.WriteLine("You have selected Miles");
            }
            


            Console.WriteLine("Select the distance unit to convert to >");
            choice = ConsoleHelper.SelectChoice(choices);
            ToUnit = ExecuteChoice(choice);

            if (choice == 1)
            {
                Console.WriteLine("You have selected Feet");
            }

            else if (choice == 2)
            {
                Console.WriteLine("You have selected Meters");
            }

            else if (choice == 3)
            {
                Console.WriteLine("You have selected Miles");
            }

            ConsoleHelper.OutputHeading($"Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($"Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// This method will display the choices of conversion for 
        /// Distance converter app.
        /// </summary>
        private DistanceUnits ExecuteChoice(int choice)
        {
            if (choice == 1)
            {
                return DistanceUnits.Feet;
            }
            else if (choice == 2)
            {
                return DistanceUnits.Metres;
            }
            else if (choice == (3))
            {
                return DistanceUnits.Miles;
            }
            return DistanceUnits.NoUnit;
        }

        /// <summary>
        /// This method performs all the required calculations
        /// for conversion
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METERS;
            }           

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METERS;
            }

            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
        }

        /// <summary>
        /// This method displays the final result after conversion
        /// </summary> 
        private void OutputDistance()
        {
            Console.WriteLine($" {FromDistance} {FromUnit}" +
               $" is {ToDistance:0.00} {ToUnit}!");
        }

    }
}








