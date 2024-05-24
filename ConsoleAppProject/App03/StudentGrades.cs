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
        // Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        // Enumeration for Grades
        public enum Grades { F, D, C, B, A }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "Dylan", "Eric",
                "Georgia", "Hasan", "Hamza",
                "Jack", "Liam", "Shan",
                "Shamial"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void OutputMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Student Grades Menu");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Input Marks");
                Console.WriteLine("2. Display Grades");
                Console.WriteLine("3. Display Statistics");
                Console.WriteLine("4. Display Grade Profile");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InputMarks();
                        break;
                    case "2":
                        DisplayGrades();
                        break;
                    case "3":
                        DisplayStatistics();
                        break;
                    case "4":
                        DisplayGradeProfile();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public void InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write($"Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int mark) && mark >= LowestMark && mark <= HighestMark)
                    {
                        Marks[i] = mark;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid mark. Please enter a mark between 0 and 100.");
                    }
                }
            }
        }

        public void DisplayGrades()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Grades grade = ConvertToGrade(Marks[i]);
                Console.WriteLine($"{Students[i]}: {Marks[i]} - {grade}");
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        public void DisplayStatistics()
        {
            CalculateStats();

            Console.WriteLine("Statistics:");
            Console.WriteLine($"Mean: {Mean}");
            Console.WriteLine($"Minimum: {Minimum}");
            Console.WriteLine($"Maximum: {Maximum}");

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        public void DisplayGradeProfile()
        {
            CalculateGradeProfile();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
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
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

        public void CalculateStats()
        {
            double total = 0;
            Minimum = HighestMark;
            Maximum = LowestMark;

            foreach (int mark in Marks)
            {
                total += mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
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


    }
}