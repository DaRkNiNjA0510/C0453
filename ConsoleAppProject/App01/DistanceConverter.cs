using System;
using ConsoleAppProject;
using System.Runtime.CompilerServices;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a 
    /// given distance measureed in miles to the equivalent
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Jake Dickinson version 0.1
    /// </author>
    /// 
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double meters;


        /// <summary>
        ///   This method will input the distance measured in miles
        ///   calculate the same distance in feet, and output the 
        ///   distance in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMeters()
        {
            OutputHeading();
            InputMiles();
            CalculateMeters();
            OutputMeters();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMeters()
        {
            Console.Write("Please enter the number of meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is" + feet + "feet!");
        }

        private void OutputMeters()
        {
            Console.WriteLine(miles + "miles is" + meters + "meters!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is" + miles + "miles!");
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("            Distance Converter         ");
            Console.WriteLine("            By Jake Dickinson          ");
            Console.WriteLine("--------------------------------------\n");
        }
    }
}
