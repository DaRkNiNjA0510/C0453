using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This class represents a BMI calculator.
    /// </summary>
    public class BMI
    {
        public void CalculateBMI()
        {
            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            string category = GetBMICategory(bmi);
            Console.WriteLine($"Category: {category}");
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < UnderWeight)
            {
                return "Underweight";
            }
            else if (bmi < Normal)
            {
                return "Normal weight";
            }
            else if (bmi < Overweight)
            {
                return "Overweight";
            }
            else if (bmi < ObeseClass1)
            {
                return "Obese Class 1";
            }
            else if (bmi < ObeseClass2)
            {
                return "Obese Class 2";
            }
            else
            {
                return "Morbidly Obese";
            }
        }

        private const double UnderWeight = 18.5;
        private const double Normal = 24.9;
        private const double Overweight = 29.9;
        private const double ObeseClass1 = 34.9;
        private const double ObeseClass2 = 39.9;
    }
}
