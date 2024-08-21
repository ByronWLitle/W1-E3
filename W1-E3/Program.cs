using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PA = 0;
            double rate = 0.0;
            int time = 0;
            int interest = 0;

            //Title of program
            Console.WriteLine("Interest Calculator Program");

            //Prompts user to input PA of loan
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            //Converts user input to int
            PA = Convert.ToInt32(Console.ReadLine());

            //Prompts user to input interest
            Console.WriteLine("What is interest rate (input 0.05 for 5%)?");
            //Converts user input to double
            rate = Convert.ToDouble(Console.ReadLine());

            //Prompts user to input time of loan
            Console.WriteLine("What is the period of loan in years?");
            //Converts user input to int
            time = Convert.ToInt32(Console.ReadLine());

            //Calculation of interest overall
            interest = Convert.ToInt32(PA * rate * time);

            //Displays to user total interest 
            Console.WriteLine($"Total interest of Loan: {interest} dollars.");
            Console.ReadKey();
        }
    }
}
