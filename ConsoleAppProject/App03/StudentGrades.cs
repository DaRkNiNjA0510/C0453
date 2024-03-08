using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        //Constrants (Grade Boundaries)

        public const int Lowestmark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //Properties

        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        //Attributes

        public StudentGrades()
        {
            Students = new string[]
                {
                "Daniel","Dylan","Eric",
                "Georgia", "Hasan", "Hamza",
                "Jack", "Liam", "Shan",
                "Shamial"
                };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }
        //<summary>
        // convert a mark into a grade using grade bouundaries
        //</summary>

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        public void CalculateStats()
        {
            throw new NotImplementedException();

        }

        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }
    }
}
