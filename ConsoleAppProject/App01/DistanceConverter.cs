using System;

namespace ConsoleAppProject.App01
{
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const double MILES_IN_METERS = 1609.344;
        public const double FEET_IN_METERS = 0.3048;

        private double fromDistance;
        private double toDistance;

        private DistanceUnit fromUnit;
        private DistanceUnit toUnit;


        public DistanceConverter()
        {
            fromUnit = DistanceUnit.Miles;
            toUnit = DistanceUnit.Feet;
        }

        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit("Select the from distance unit > ");
            toUnit = SelectUnit("Select the to distance unit > ");

            Console.WriteLine($"\nConverting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Enter the number of {fromUnit} >");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnit.Miles && toUnit == DistanceUnit.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnit.Feet && toUnit == DistanceUnit.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnit.Miles && toUnit == DistanceUnit.Metres)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == DistanceUnit.Metres && toUnit == DistanceUnit.Miles)
            {
                toDistance = fromDistance / MILES_IN_METERS;
            }
            else if (fromUnit == DistanceUnit.Feet && toUnit == DistanceUnit.Metres)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
        }

        private DistanceUnit SelectUnit(string prompt)
        {
            DistanceUnit unit = DistanceUnit.NoUnit;

            while (unit == DistanceUnit.NoUnit)
            {
                Console.WriteLine();
                Console.WriteLine($"1. {DistanceUnit.Feet}");
                Console.WriteLine($"2. {DistanceUnit.Metres}");
                Console.WriteLine($"3. {DistanceUnit.Miles}");
                Console.WriteLine();

                Console.Write(prompt);
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        unit = DistanceUnit.Feet;
                        break;
                    case "2":
                        unit = DistanceUnit.Metres;
                        break;
                    case "3":
                        unit = DistanceUnit.Miles;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        Console.WriteLine("Must be a digit 1 to 3");
                        break;
                }
            }
            return unit;
        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n{fromDistance} {fromUnit} is {toDistance} {toUnit}!\n");
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("          Distance Converter          ");
            Console.WriteLine("          By Jake Dickinson          ");
            Console.WriteLine("--------------------------------------\n");
        }
    }
}
