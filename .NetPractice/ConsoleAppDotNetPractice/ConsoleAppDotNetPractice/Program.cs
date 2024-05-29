using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotNetPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            PrintToConsole("Hello World from method :)");
            // string var=Console.ReadLine();
            VariablesAndDatatypes();
            MathOperatorMethods();
            ConditionalStatements();
            Console.ReadLine();
        }
        static void PrintToConsole(string output)
        {
            Console.WriteLine(output);
        }
        static void VariablesAndDatatypes()
        {
            int age = 23;
            Console.WriteLine($"This age belong to someone in the world {age} years.");
            float temperature = 23.0001f;
            Console.WriteLine(temperature);
            double interest =23.43;
            Console.WriteLine(interest.GetType());
            Console.WriteLine(interest);
            decimal stockPrice = 23.32M;
            Console.WriteLine(stockPrice);
            char grade = 'A';
            Console.WriteLine(grade);
            string ClassName = "Graduated";
            Console.WriteLine(ClassName, ClassName.GetType());
            bool Student = false;
            Console.WriteLine(Student);
            const decimal PI = 3.14M;
            Console.WriteLine(PI.ToString(), PI.GetType());
        }
        static void MathOperatorMethods() {
            int num1 = 21;
            int num2 = 12;
            Console.WriteLine(num2 + num1);

            try
            {
                float DivideByZero = (num1 / 0);
                Console.WriteLine(DivideByZero);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            };
        }
        static void ConditionalStatements()
        {
            int Day = 4;
            string DayName;
            switch (Day)
            {
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Thursday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thuesday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                case 6:
                    DayName = "Saturday";
                    break;
                case 7:
                    DayName = "Sunday";
                    break;
                default:
                    DayName = "Invalid day number";
                    break;
            }
            Console.WriteLine("Today is " +  DayName);
        }
    }
}
