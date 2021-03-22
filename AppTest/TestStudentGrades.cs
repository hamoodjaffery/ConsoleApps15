using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] TestMarks;

        public TestStudentGrades()
        {

            int[] TestMarks = new int[]
            {
               10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }


        [TestMethod]
        public void TestConvertToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);

        }


        [TestMethod]
        public void TestConver39tToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }


        [TestMethod]
        public void TestCalculateStats()
        {
            int[] TestMarks = new int[]
            {
                   10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

            converter.Marks = TestMarks;
            double expectedMean = 55.0;
            int expectedMin = 10;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
            Assert.AreEqual(expectedMin, converter.Minimum);
            Assert.AreEqual(expectedMax, converter.Maximum);
        }

        [TestMethod]
        public void TestConver40tToGradeD()
        {
            //Arrange

            Grades expectedGrade = Grades.D;

            //Act

            Grades actualGrade = converter.ConvertToGrade(40);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver49tToGradeD()
        {
            //Arrange

            Grades expectedGrade = Grades.D;

            //Act

            Grades actualGrade = converter.ConvertToGrade(49);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver50tToGradeC()
        {
            //Arrange

            Grades expectedGrade = Grades.C;

            //Act

            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver59tToGradeC()
        {
            //Arrange

            Grades expectedGrade = Grades.C;

            //Act

            Grades actualGrade = converter.ConvertToGrade(59);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver60tToGradeB()
        {
            //Arrange

            Grades expectedGrade = Grades.B;

            //Act

            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }


        [TestMethod]
        public void TestConver69tToGradeB()
        {
            //Arrange

            Grades expectedGrade = Grades.B;

            //Act

            Grades actualGrade = converter.ConvertToGrade(69);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver70tToGradeA()
        {
            //Arrange

            Grades expectedGrade = Grades.A;

            //Act

            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConver79tToGradeA()
        {
            //Arrange

            Grades expectedGrade = Grades.A;

            //Act

            Grades actualGrade = converter.ConvertToGrade(79);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestGradeprofile()
        {
            //Arrange

            int[] TestMarks = new int[]
            {
                   10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

            converter.Marks = TestMarks;

            //Act
            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 0) &&
                               (converter.GradeProfile[1] == 3) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 1) &&
                               (converter.GradeProfile[5] == 4));

            //Assert
            Assert.IsTrue(expectedProfile);
        }

    }
}

