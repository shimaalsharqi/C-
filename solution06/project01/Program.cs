namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //       for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("please enter number");
            //      int num = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine($"the number is {num}");

            //  }
            //   for (int i = 1; i < 6; i++){
            //          for (int x = 1; x < 5; x++){
            //              Console.WriteLine($"({i},{x})");
            //          }
            //          }  
            //Console.WriteLine("please enter number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //bool stop = true;
            //for (int n = 2; n < num1 - 1; n++)
            //{
            //    if (num1 % n == 0)
            //    {
            //        stop = false;

            //    }
            //}

            //if (stop)
            //{
            //    Console.WriteLine("The number is primary");

            //}
            //else
            //{
            //    Console.WriteLine("The number is not primary");



            //}
            #region While
            //int count = 1;

            //Console.WriteLine($"please enter number this is try number {count}");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Random random = new Random();
            //int myNumber = random.Next(1, 11);

            //while (num2 != myNumber)
            //{
            //   count++;
            //    if (count <= 3)
            //    {
            //        Console.WriteLine($"Incorrect  number this is try number {count} ");
            //        Console.WriteLine("So please enter again number");
            //        num2 = Convert.ToInt32(Console.ReadLine());

            //    }
            //    else {
            //        break;
            //    }

            //}
            #endregion
            #region Task String
            Console.WriteLine("please enter any word");
            string word = Console.ReadLine();
            string y = "";
            for (int w = word.Length; w <= 0; w--)
            {
                y += word[w];

            }
            if(y == word)
            {
                Console.WriteLine("the word is perfact");
            }
            else
            {
                Console.WriteLine("the word is not perfact");
            }
            #endregion





        }
    }
}
