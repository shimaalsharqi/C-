namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.WriteLine("Please Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("The Number is a Zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("The Number is a positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The Number is a Negative");
            }
            else
            {
                Console.WriteLine("Please Enter Just a Number");
            }
            //Second Task
            Console.WriteLine("Please Enter a Integar Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 %2== 0) {
                Console.WriteLine("The Number is a Even");
            }
            else if (num1 % 2 != 0)
            {
                Console.WriteLine("The Number is a Odd");
            }
            else  
            {
                Console.WriteLine("Please Enter Just a Number");
            }

            //Third Task
            Console.WriteLine("Please Enter a student score from 0 to 100");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2>=90 && num2==100) {
                Console.WriteLine("The student is Excellent");
            }
            else if (num2 >= 75 && num2 <= 89)
            {
                Console.WriteLine("The student is Very Good");
            }
            else if (num2 >= 60 && num2 <= 74)
            {
                Console.WriteLine("The student is Good");
            }
            else if (num2 >= 50 && num2 <= 59)
            {
                Console.WriteLine("The student is Pass");
            }
            else if ( num2 <50)
            {
                Console.WriteLine("The student is Fail");
            }
            else if (num2 >100 && num2 < 0)
            {
                Console.WriteLine("Please Enter a student score from 0 to 100");
            }
            else  
            {
                Console.WriteLine("Please Enter a student score from 0 to 100");
            }
            //Fourth Task
            Console.WriteLine("Please Enter The username and the password");
            string username = Console.ReadLine();   
            int pass = Convert.ToInt32(Console.ReadLine());
            if (username =="admin" && pass == 1234) {
                Console.WriteLine("Login Successful");
            }
            else 
            {
                Console.WriteLine("Invalid Username or Password");
            }
            //Task 5
            int balance = 1000;
            Console.WriteLine("Enter a withdrawal amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int final = balance - amount;
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else if (amount < balance || amount == balance)
            {
                Console.WriteLine("withdrawal Successful ");
                Console.WriteLine("The remainging balance "+ final);
            }

            //C# Practice Tasks
            //Task1
            Console.WriteLine("Please Enter number from 1 to 7");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number) {
                case 1:  
                 Console.WriteLine("the day is Monday ");
                    break;
                case 2:
                    Console.WriteLine("the day is Tuseday ");
                    break;
                case 3:
                    Console.WriteLine("the day is Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("the day is Thursday ");
                    break;
                case 5:
                    Console.WriteLine("the day is Friday ");
                    break;
                case 6:
                    Console.WriteLine("the day is Suterday ");
                    break;
                case 7:
                    Console.WriteLine("the day is Sunday ");
                    break;
                default:
                    Console.WriteLine("Invalid day number ");
                    break;
            }
            //task 2
            Console.WriteLine("Please Enter number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}*{number1}= {i * number1}");
            }
            //task 3
            //Console.WriteLine("Please Enter number from 1 to 7");
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //int x = 0;
            //while (x < number3)
            //{
            //    Console.WriteLine(number3);
            //    number3--;
            //}
        }
    }
}


