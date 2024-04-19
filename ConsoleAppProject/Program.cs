using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started. It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jake Dickinson 26/01/2024
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentGrades grader = new StudentGrades();
        

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2023-2024! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine("3. Student Grades Calculator");
            Console.WriteLine();

            Console.Write("Please enter your choice of App > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                calculator.CalculateBMI();
            }
            else if (choice == "3")
            {
                grader.OutputMenu();
            }
            else if (choice == "4")
            {
               
            }

            else Console.WriteLine("Invalid Choice !");
        }
    }
}