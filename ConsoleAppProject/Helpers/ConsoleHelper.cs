using System;

namespace ConsoleAppProject.Helpers
{
    public static class ConsoleHelper
    {
        public static void OutputHeading(string heading)
        {
            Console.WriteLine($"\n{heading}\n");
        }

        public static void OutputTitle(string title)
        {
            Console.WriteLine($"\n{title}\n");
        }

        public static int SelectChoice(string[] choices)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {choices[i]}");
            }

            Console.Write("\nEnter your choice > ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= choices.Length)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                return SelectChoice(choices);
            }
        }

        public static double InputNumber(string prompt, double min, double max)
        {
            double number;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number) && number >= min && number <= max)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                }
            } while (true);
        }
    }
}
