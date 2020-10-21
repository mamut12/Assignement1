using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Assignment_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter numbers following '+' in order to calculate the total (Ex.2+3+5): ");

            string input = Console.ReadLine();
            string[] splitInput = input.Split('+');

            long sum = 0;
            foreach (string number_str in splitInput)
            {
                try
                {
                    long number = Int64.Parse(number_str);
                    sum += number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not an integer.", number_str);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number {0} is too large", number_str);
                }
            }
            Console.WriteLine("output: {0} ", sum);
        }
    }
}
