namespace project01
{
    internal class Program
    {
        static int Calc(int x, int y)
        {
            return x + y;
        }

        static double Calc(double x, double y)
        {
            return x + y;
        }


        //static int Calc(int x, int y, int z, int w)
        //{
        //    return x + y + z + w;
        //}
        static void Main(string[] args)
        {


            Console.WriteLine(Calc(2, 6));        
            Console.WriteLine(Calc(2, 9));     
            //Console.WriteLine(Calc(1, 6, 3, 5)); 
        }

    
      

    
    }
}
