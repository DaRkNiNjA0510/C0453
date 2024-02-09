﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2023-2024! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            // Uncomment the method calls below to run the respective applications
            //DistanceConverter();
            BMIApp();
        }

        private static void DistanceConverter()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ConvertDistance();
        }

        private static void BMIApp()
        {
            BMI bmi = new BMI();
            bmi.CalculateBMI(); 
        }
    }
}
