namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Resultsum = num1 + num2;
            int Resultcross = num1 * num2;
            int Resultsub = num1 - num2;
            int Resuldiv = num1 / num2;


            Console.WriteLine($"Result of sum = {Resultsum}");
            Console.WriteLine($"Result of cross = {Resultcross}");
            Console.WriteLine($"Result of sub = {Resultsub}");
            Console.WriteLine($"Result of div = {Resuldiv}");
        }
    }
}
