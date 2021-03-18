using DevOcean.Services;
using System;

namespace DevOcean.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double gross;
            var taxSrvc = new TaxCalculator();

            Console.WriteLine($"Hello, {Environment.UserName}{Environment.NewLine}Please enter your gross salary:");

            while (!double.TryParse(Console.ReadLine(), out gross) && gross > 0)
            {
                Console.WriteLine("Enter valid number.");
            }

            var payCheck = taxSrvc.GetPayCheck(gross);

            Console.Clear();
            Console.WriteLine(payCheck);
        }
    }
}
