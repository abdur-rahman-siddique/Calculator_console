using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the calculator program.");
            do
            {
                double num1;
                double num2;
                double result;

                string answer;

                
                Console.WriteLine("Enter a number: ");

                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter another number: ");

                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What kind of operation would you like to do?");
                Console.WriteLine("Please enter \ta for addition \ts for subtraction \tm for multiplication \tany other key for division");


                answer = Console.ReadLine();

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }
                result = Convert.ToDouble(result);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("Would you like to contnue? (y = yes, n = no): ");
            }
            while (Console.ReadLine().ToLower() == "y");
            

            
            Console.WriteLine("Thank You for using the calculator program!");

            Console.ReadKey();
            
        }
    }
}
