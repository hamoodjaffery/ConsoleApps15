using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// 
    /// </summary>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

    /// <summary>
    /// This method will Input the distance in miles
    /// calculate the same distance in feet, and output the
    /// distance in feet.
    /// </summary>   
        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();        
        }

        /// <summary>
        /// This method will Input the distance in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>   
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();        
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine(" Distance Converter Aap (Miles to Feet)");
            Console.WriteLine("     by Hamood Jaffery                 ");
            Console.WriteLine(" --------------------------------------\n");
        }

        /// <summary>
        ///Prompt the user to enter the distance in miles
        ///Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        
        }       
    }
}
