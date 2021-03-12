using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        public string [] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// This is the main class that will be called when an object is created.
        /// Also stores an array of students
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                {
                "Diyan", "Hashir", "John",
                "Usama", "Osaid", "Mark",
                "Faris", "Yasir", "Charlie",
                "Edward"
                };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Allows the tutor to mark each student between 0-100,
        /// and will store it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all students and display's their name and awarded marks
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert student's mark in grade
        /// from A (First Class) to F (Fail)
        /// </summary>
        public Grade ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate and shows the min, max
        /// and mean mark for each of the students 
        /// </summary>
        public CalculateStats()
        {
            throw new NotImplementedException();
        }
    }
}
