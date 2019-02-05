using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Which course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumberString = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”?");
            string needsHelpString = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(needsHelpString);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedString = Console.ReadLine();
            double hoursStudied = Convert.ToDouble(hoursStudiedString);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();

        }
    }
}
