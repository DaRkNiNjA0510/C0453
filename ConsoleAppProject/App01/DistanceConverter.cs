using System;
using ConsoleAppProject.Helpers;

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

        public const double MILES_IN_METERS = 1609.344;

        public const double FEET_IN_METERS = 0.3048;

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "Miles";

        public double FromDistance { get; set; }   

        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public  string ToUnit { get; set;  }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;

        }
        /// <summary>
        ///   This method will input the distance measured in miles
        ///   calculate the same distance in feet, and output the 
        ///   distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit("select the from distance unit > ");
            ToUnit = SelectUnit("select the to distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Enter the number of {FromUnit} >");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
                ToDistance = FromDistance * METERS_IN_MILES;

            else if (FromUnit == METRES && ToUnit == MILES)

                ToDistance = FromDistance / MILES_IN_METERS;
        
                else if (FromUnit== FEET && ToUnit == METRES)
                ToDistance = FromDistance* FEET_IN_METERS;
    }    
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExcuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
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
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
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
            Console.WriteLine($"\n {FromDistance}  {FromUnit} " +
                $" is {ToDistance} {ToUnit}!\n");
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
