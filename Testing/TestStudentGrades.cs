using ConsoleAppProject.App03;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;
        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMean = 55.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMean, converter.Mean);
        }
        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMin = 10.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMin, converter.MinMark);
        }
        [TestMethod]
        public void TestCalculateMax()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMin = 100.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMin, converter.MinMark);
        }

        [TestMethod]
        public void TestLowestGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighestGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestLowestGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(40);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestHighestGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(49);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestLowestGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestHighestGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(59);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestLowestGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestHighestGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(69);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestLowestGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestHighestGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(100);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        public void TestGradeProfile()
        {
            converter.Marks = testMarks;

            converter.CalculateGradeProfile();
            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));
            Assert.IsTrue(expectedProfile);
        }
    }
}
