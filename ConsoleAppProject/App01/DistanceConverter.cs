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

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public void Run()
        {
            ConsoleHelper.OutputHeading("Distance Converter App");

            Console.WriteLine("Select the distance unit to convert from >");

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

            Console.WriteLine("Please select the from distance unit >");
            choice = ConsoleHelper.SelectChoice(choices);
            fromUnit = ExecuteChoice(choice);


            Console.WriteLine("Please select the to distance unit >");
            choice = ConsoleHelper.SelectChoice(choices);
            toUnit = ExecuteChoice(choice);

            ConsoleHelper.OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = ConsoleHelper.InputNumber($"Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }


        private static string ExecuteChoice(int choice)
        {
            if (choice == 1)
            {
                return FEET;
            }
            else if (choice == 2)
            {
                return METERS;
            }
            else if (choice == (3))
            {
                return MILES;
            }
            return null;
        }

        private void CalculateDistance()
        {
            if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }           

            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }

            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }

            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
        }

        // todo 5 other cacluations

        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
               $" is {toDistance} {toUnit}!");
        }

    }
}








