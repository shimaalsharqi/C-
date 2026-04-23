using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double Fnum = GetNumber("Enter first number: ");
                double Snum = GetNumber("Enter second number: ");

                char op = GetOperation();

                double result;
                bool valid = Calculate(Fnum, Snum, op, out result);

                if (valid)
                {
                    Console.WriteLine("Result = " + result);
                }

                if (!AskToContinue())
                {
                    Console.WriteLine("Calculator stopped.");
                    break;
                }

                Console.Clear();
            }
        }

     
        static double GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

    
        static char GetOperation()
        {
            Console.WriteLine("Choose operation: +, -, *, /");
            return Convert.ToChar(Console.ReadLine());
        }

       
        static bool Calculate(double Fnum, double Snum, char op, out double result)
        {
            result = 0;

            switch (op)
            {
                case '+':
                    result = Fnum + Snum;
                    return true;

                case '-':
                    result = Fnum - Snum;
                    return true;

                case '*':
                    result = Fnum * Snum;
                    return true;

                case '/':
                    if (Snum != 0)
                    {
                        result = Fnum / Snum;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                        return false;
                    }

                default:
                    Console.WriteLine("Invalid operation!");
                    return false;
            }
        }

       
        static bool AskToContinue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            char choice = Convert.ToChar(Console.ReadLine());

            return (choice == 'y' || choice == 'Y');
        }
    }
}