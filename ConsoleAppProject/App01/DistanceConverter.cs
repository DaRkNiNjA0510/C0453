using System;
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
    public class DistanceConverter
    {
        private double miles;

        private double feet;


        /// <summary>
        ///    
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles >")
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
        }

        private void OutputFeet()
        {
        }

    }
}