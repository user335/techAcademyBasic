using System;

namespace ConsoleApp4
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("What is the package weight? ");
            float weight = Convert.ToSingle(Console.ReadLine());

            if (weight > 50) goto Error1;

            Console.Write("What is the package width? ");
            float width = Convert.ToSingle(Console.ReadLine());

            Console.Write("What is the package height? ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.Write("What is the package length? ");
            float length = Convert.ToSingle(Console.ReadLine());

            float sum = width + height + length;
            if (sum > 50) goto Error2;

            decimal quote = Convert.ToDecimal(sum * weight * .01f);

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("N2"));
            Console.WriteLine("Thank you.");
            Console.Read();
            return;

        Error1:
            {
                Console.Write("Error, Package too heavy to be shipped by Package Express. Have a good day.");
                Console.Read();
                return;
            }
        Error2:
            {
                Console.Write("Error, Package too big to be shipped via Package Express. Have an okay day.");
                Console.Read();
                return;
            }
        }
    }
}