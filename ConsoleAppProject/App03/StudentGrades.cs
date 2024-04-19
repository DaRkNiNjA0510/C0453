using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading;
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
        public double MinMark { get; set; }

        //Attributes
        public Grades Grades
        {get => default; set {}}

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

        public void OutputMenu()
        {
            throw new NotImplementedException();
        }

        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        public void OutputStats()
        {
            throw new NotImplementedException();
        }
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}  {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }
        //<summary>
        // convert a mark into a grade using grade bouundaries
        //</summary>

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= Lowestmark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

            public void CalculateStats()
            {
            double total = 0;

            Minimum = HighestMark;
            Maximum = Lowestmark;


            foreach(int mark in Marks)
            {
                total += mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Maximum) Minimum = mark;
                
            }
            Mean = total / Marks.Length;
        }

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
            OutputGradeProfile();
            }

        }
    }


