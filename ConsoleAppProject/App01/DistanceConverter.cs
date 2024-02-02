using System;
using ConsoleAppProject;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a 
    /// given distance measureed in miles to the equivalent
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Jake Dickinson version 0.3
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
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet >");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");

            miles = InputDistance("Please enter the number of miles >");
            CalculateMeters();
            OutputDistance(miles, nameof(miles), feet, nameof(meters));
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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

        private void OutputDistance(double fromDistance, string fromUnit,
                                    double toDistance, string toUnit)
        { 
        Console.WriteLine($"{fromDistance}  {fromUnit} " +
            $"is {toDistance} {toUnit}!");
        }

        private void OutputHeading(string prompt)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("            Distance Converter         ");
            Console.WriteLine("            By Jake Dickinson          ");
            Console.WriteLine("--------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
