using System;

namespace ConsoleApp4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CIAD, the Car Insurance Automatic Denial program");

            Console.Write("What is your age? ");
            int age = Convert.ToInt16(Console.ReadLine());

            DUIQuestion:
            Console.Write("Have you ever had a DUI? ");
            bool hasDui = false;
            string hasDuiString = Console.ReadLine();
            try
            {
                hasDui = Convert.ToBoolean(hasDuiString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert that into true or false");
                goto DUIQuestion;
            }
            
            Console.Write("How many speeding tickets do you have? ");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Ok, now let's see if you qualify for car insurance...");
            Console.WriteLine("Result = " + (age > 15 && hasDui == false && numberOfTickets < 3));

            Console.WriteLine();
            Console.WriteLine("Goodbye, human.");
            Console.Read();
        }
    }
}
