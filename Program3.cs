using System;

namespace ConsoleApp4
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.Write("Input hourly rate: ");
            float hourlyRate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input hours worked per week: ");
            float hoursWorked = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Person 2:");
            Console.Write("Input hourly rate: ");
            float hourlyRate2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input hours worked per week: ");
            float hoursWorked2 = Convert.ToSingle(Console.ReadLine());

            double salary1 = hoursWorked * hourlyRate;
            double salary2 = hoursWorked2 * hourlyRate2;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salary1 > salary2 ? true: false);
            Console.WriteLine();
            Console.WriteLine("Goodbye, human.");
            Console.Read();
        }
    }
}
