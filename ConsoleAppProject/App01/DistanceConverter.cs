using System;
using ConsoleAppProject;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance
    /// mesured in one unit (fromunit) and it will calculate and 
    /// ouput the equivalent distance in another unit (tounit)
    /// </summary>
    /// <author>
    /// Jake Dickinson version 0.6
    /// </author>
    /// 
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

    public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;

        }
        /// <summary>
        ///   This method will input the distance measured in miles
        ///   calculate the same distance in feet, and output the 
        ///   distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit >");
            OutputHeading($"Converting {fromUnit} to {toUnit}");


            fromDistance = InputDistance($"please enter the number of {fromUnit} >");

            CalculateDistance();

          OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExcuteChoice(choice);
        }

        private static string ExcuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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

        private void OutputDistance()
        { 
        Console.WriteLine($"{fromDistance}  {fromUnit} " +
            $" is {toDistance} {toUnit}!");
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
