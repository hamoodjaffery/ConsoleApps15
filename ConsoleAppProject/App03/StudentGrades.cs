using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        // Constants

        public const int NoStudents = 10;

        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        private bool index;

        /// <summary>
        /// Variables, with get and set method, all set to public
        /// so other classes can use them
        /// </summary>
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// Constructor to store student names
        /// </summary>
        public StudentGrades()
        {
            Students = new string[10]
                {
                "Diyan", "Hashir", "John",
                "Usama", "Osaid", "Mark",
                "Faris", "Yasir", "Charlie",
                "Edward"
                };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        //Methods

        public void UserSelect()
        {
            bool carryOn = true;
            do
            {
                Console.WriteLine("Welcome to Student Grades");
                Console.WriteLine("by Hamood Jaffery");
                Console.WriteLine("Please select from the following >");
                string choice = DisplayChoices();

                ExecuteChoices(choice);
            } while (carryOn);

            Quit();

        }

        /// <summary>
        /// Pormpts the user to choose out of the four methods to do
        /// </summary>
        public string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine("1, Input Marks");
            Console.WriteLine("2. Output Marks");
            Console.WriteLine("3. Output Stats");
            Console.WriteLine("4. Output Grade Profile");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.WriteLine();
            string choice = Console.ReadLine();

            return choice;
        }

        /// <summary>
        /// Executes the user's choice
        /// </summary>
        public void ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                InputMarks();
            }
            else if (choice.Equals("2"))
            {
                OutputMarks();
            }
            else if (choice.Equals("3"))
            {
                OutputStats();
            }
            else if (choice.Equals("4"))
            {
                OutputGradeProfile();
            }
            else if (choice.Equals("5"))
            {
                Quit();
            }

            else
                Console.WriteLine();
            Console.WriteLine("Invalid choice, please select again");
            Console.WriteLine();
        }

        /// <summary>
        /// Quits the program
        /// </summary>
        public void Quit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Allows the tutor to mark each student between 0-100,
        /// and will store it in the Marks array
        /// </summary>
        public string InputMarks()
        {
            int mark;
            int index = 0;

            ConsoleHelper.OutputTitle(" Input Student Marks >");

            foreach (string student in Students)
            {
                mark = (int)ConsoleHelper.InputNumber("Please enter a mark for" + (student) + ">", 0, HighestMark);
                Marks[index] = mark;
                index++;
            }

            UserSelect();
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Lists all students and display's their name and awarded marks
        /// </summary>
        /// 
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle(" Listing of Student Marks >");
            for (int index = 0; index < NoStudents; index++)
            {
                Console.WriteLine($" {Students[index]} {Marks[index]}");

            }
        }

        /// <summary>
        /// Convert student's mark in grade
        /// from A (First Class) to F (Fail)
        /// </summary>
        /// 
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestMark && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestMark && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestMark && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }
        }

        /// <summary>
        /// Calculates the mean total for each student
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the grade profile containing the
        /// percentage of students attaining each grade.
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

        }

        /// <summary>
        /// Displays the grade profile after
        /// it has been calculated.
        /// </summary>
        private void OutputGradeProfile()
        {
            CalculateGradeProfile();

            Grades grade = Grades.N;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;

                Console.WriteLine($"\tGrade {grade} \t[percentage]$" +
                    $"\t(Count {count}");
                grade++;
            }

            Console.WriteLine();
            UserSelect();
        }
    }
}
