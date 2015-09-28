using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    class Program
    {
        public static decimal getInputDecimal(string message, bool acceptZero = true, bool positiveNumber = false)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);

                    string input = Console.ReadLine();

                    decimal response = decimal.Parse(input);

                    if (positiveNumber == true && response <= 0)
                    {
                        Console.WriteLine("Please enter a positive number");

                        continue;
                    }
                    if (acceptZero == false && response < 0)
                    {
                        Console.WriteLine("Please enter a number other than 0");

                        continue;
                    }
                    return response;

                }
                catch (ArgumentNullException a)
                {
                    Console.WriteLine("There was an error, please try again");
                }
                catch (FormatException b)
                {
                    Console.WriteLine("Please enter a numerical value");
                }
                catch (OverflowException c)
                {
                    Console.WriteLine("The number is too large");
                }
                catch (Exception d)
                {
                    Console.WriteLine("There was an error, please try again");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    decimal homePrice = getInputDecimal("Enter the price of the home ($)");

                    decimal loanTerm = getInputDecimal("Enter the loan term (years)");

                    decimal interest = getInputDecimal("Enter the interest (%)");

                    decimal downPayment = getInputDecimal("Enter the down payment ($)");

                    decimal monthlyTerm = loanTerm * 12;

                    decimal principalPrice = homePrice - downPayment;

                    decimal principalMonthlyPayment = principalPrice / monthlyTerm;

                    decimal monthlyInterest = interest / 12;

                    decimal principalMonthlyInterest = principalMonthlyPayment * monthlyInterest;

                    decimal monthlyPayment = principalMonthlyPayment + principalMonthlyInterest;

                    decimal totalCost = monthlyPayment * monthlyTerm;

                    decimal interestEarned = principalMonthlyInterest * monthlyTerm;

                    Console.WriteLine("-----------------------------------------");

                    Console.WriteLine("Number of Monthly payments: " + monthlyTerm);

                    Console.WriteLine("Monthly payment amount: " + monthlyPayment.ToString("C"));

                    Console.WriteLine("Total cost of Mortgage: " + totalCost.ToString("C"));

                    Console.WriteLine("Interest Earned: " + interestEarned.ToString("C"));

                    Console.WriteLine("-----------------------------------------");

                    Console.WriteLine("Press any key and enter to continue");

                    Console.ReadLine();

                    Console.Clear();

                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error, please try again");


                }
            }
        }
    }
}

    
