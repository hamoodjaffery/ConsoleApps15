using ConsoleAppProject.Helpers;
using System;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The units types for the BMI calculator.
    /// </summary>
    public enum UnitSystems
    {
        [Display(Name = "Imperial")]
        Imperial,
        [Display(Name = "Metric")]
        Metric

    }
    /// <summary>
    /// This app calculates the user's BMI by taking their weight and height
    /// in either imperial or metric units.
    /// After the values are entered, the user's BMI will be calculated and displayed,
    /// indicating their weight status according to the W.H.O guidelines.
    /// </summary>
    /// <author>
    /// Hamood Jaffery (modified on 01.03.21)
    /// </author>
    public class BMI_Calculator
    {
        //Bmi index result
        public double BmiIndex { get; set; }

        // WHO Weight Status
        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double OBESE_CLASS1 = 34.9;
        public const double OBESE_CLASS2 = 39.9;
        public const double OBESE_CLASS3 = 40.0;

        //for conversion
        public const int POUNDS_IN_STONES = 14;
        public const int INCH_IN_FEET = 12;

        public WeightCategories category = WeightCategories.NoCategory;

        // Height Constants
        public const int INCHES_IN_FEET = 12;

        // Weight and Height Units    
        public double Kilograms { get; set; }
        private double meters;

        public int Pounds { get; set; }
        public int Stones { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        public  double Centimeters { get; set; }
        public string METRIC { get; private set; }
        public string IMPERIAL { get; private set; }


        //Property for user's BMI.
        public double User_BMI { get; set; }

        /// <summary>
        /// This method will display BMI Weight status and risk message.
        /// </summary>
        public void OutputBmi()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            SelectUnits();

            Console.WriteLine(DisplayWeightStatus());
            Console.WriteLine(DisplayRiskMessage());

            ExitDecision();
        }

        /// <summary>
        /// This method will handle exception, if in case the user entered a wrong choice
        /// </summary>
        private void ExitDecision()
        {
            Console.WriteLine("Dou you want to do another calculation ?");
            
            string[] choices = new string[]
            {
               "Yes",
                "No"
            };

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {
                OutputBmi();
            }
        }

        /// <summary>
        /// Prompts the user to select which unit type they would like to use.
        /// (1. Imperial; 2. Metric)
        /// </summary>
        public void SelectUnits()
        {
            Console.WriteLine("\t Choose the measuring unit to use >");


            string[] choices = { EnumHelper<UnitSystems>.GetName(UnitSystems.Imperial),
                EnumHelper<UnitSystems>.GetName(UnitSystems.Metric) };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                GetImperialInput();
                CalculateImperial();
            }
            else if (choice == 2)
            {
                GetMetricInput();
                CalculateMetric();
            }
            else
            {
                Console.WriteLine("\tInvalid choice. Please try again");

            }
        }

        /// <summary>
        /// This method will display the BMI risk message.
        /// </summary>
        public string DisplayRiskMessage()
        {
            StringBuilder message = new StringBuilder("\n\t");

            message.Append("If you are Black, Asian or in another minority " +
                "ethnic group, you have a higher health risk. ");
            message.Append("\n\tAdults with a BMI of 23.0 or over " +
                "are at increased risk. ");
            message.Append("\n\tAdults with a BMI of 27.5 or over " +
                "are at higher risk. ");

            return message.ToString();
        }

        /// <summary>
        /// Calculate's the user's BMI based on the metric units they've 
        /// entered.
        /// </summary>
        public void CalculateMetric()
        {
            BmiIndex = Kilograms / Math.Pow((Centimeters / 100), 2);
        }

        /// <summary>
        /// This method will display the BMI weight status
        /// </summary>
        public string DisplayWeightStatus()
        {
            StringBuilder message = new StringBuilder("\n\t");
            if (BmiIndex < Underweight)
            {
                category = WeightCategories.Underweight;

            }
            else if ((BmiIndex > Underweight) && (User_BMI <= Normal))
            {
                category = WeightCategories.Normal;
            }
            else if ((BmiIndex > Normal) && (User_BMI <= Overweight))
            {
                category = WeightCategories.Overweight;
            }
            else if ((BmiIndex > Overweight) && (User_BMI <= OBESE_CLASS1))
            {
                category = WeightCategories.ObeseI;
            }
            else if ((BmiIndex > OBESE_CLASS1) && (User_BMI <= OBESE_CLASS2))
            {
                category = WeightCategories.ObeseII;
            }
            else if ((BmiIndex > OBESE_CLASS2) && (User_BMI <= OBESE_CLASS3))
            {
                category = WeightCategories.ObeseIII;
            }

            message.Append($"Your BMI is {BmiIndex:0.0}. " +
               $"You are {category}. ");
            return message.ToString();
        }       

       /// <summary>
       /// This method will prompt the user to enter their
       /// height and weight in imperial units through the console.
       /// </summary>
        public void GetImperialInput()
        {
            Stones = (int)ConsoleHelper.InputNumber("\n\t Please enter your weight " +
                "in stones > ", 0, 30); ;
            Pounds = (int)ConsoleHelper.InputNumber("\n\tPlease enter your weight" +
                "in pounds > ", 0, 300);

            Feet = (int)ConsoleHelper.InputNumber("\n\tPlease enter your height" +
                "in feet > ", 0, 10);
            Inches = (int)ConsoleHelper.InputNumber("\n\tPlease enter your height" +
                "in inches > ", 0, 50);
        }

        /// <summary>
        /// This method calcualtes measurement in the imperial unit
        /// </summary>
        public void CalculateImperial()
        {
            double weightInPounds = (Stones * 14) + Pounds;
            double heightInInches = (Feet * 12) + Inches;
            BmiIndex = ((weightInPounds / heightInInches) / heightInInches) * 703;
        }

        /// <summary>
        /// Prompts the user to input the weight and height in metric units
        /// through the console
        /// </summary>
        public void GetMetricInput()
        {
            Kilograms = ConsoleHelper.InputNumber("\n\t Please enter your weight " +
                "in kilograms > ", 0, 150);
            Centimeters = ConsoleHelper.InputNumber("\n\t Please enter your height " +
                "in centimeters > ", 0, 300);
        }
    }
}
