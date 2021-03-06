﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Hamood Jaffery 01/01/21
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI_Calculator caclualtor = new BMI_Calculator();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp app04 = new NetworkApp();

        public static void Main(string[] args)
        {
                
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();
     
            DistanceConverter converter = new DistanceConverter();
            BMI_Calculator calculator = new BMI_Calculator();
            StudentGrades grades = new StudentGrades();
            NetworkApp app = new NetworkApp();

            // Ask the user which app they want to use

            string[] choices = new string[]
            {
                "App01 Distance Converter",
                "App02 BMI Calculator",
                "App03 Student Grades",
                "App04 Social Network"
            };

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {

                converter.Run();
            }

            else if (choiceNo == 2)
            {
                calculator.OutputBmi();
            }

            else if (choiceNo == 3)
            {
                grades.UserSelect();
            }

            else if (choiceNo == 4)
            {
                app.DisplayMenu();
            }

            else Console.WriteLine("Invalid choice");

        }
    }
}
