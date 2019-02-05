using System;

namespace ConsoleApp4
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, human.");
            Console.WriteLine("What is your input?");
            decimal input1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input1 + " * 50 = " + input1 * 50);

            Console.WriteLine("What is your input?");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input2 + " + 25 = " + (input2 + 25));

            Console.WriteLine("What is your input?");
            decimal input3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input3 + " / 12.5 = " + input3 / 12.5m);

            Console.WriteLine("What is your input?");
            decimal input4 = Convert.ToDecimal(Console.ReadLine());
            if (input4 > 50) 
                Console.WriteLine(input4 + " > 50? = true");
            else
                Console.WriteLine(input4 + " > 50? = false");

            Console.WriteLine("What is your input?");
            decimal input5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input5 + " % 7 = " + input5 % 7);

            Console.WriteLine("Goodbye, human.");
            Console.Read();
        }
    }
}
