namespace project01
{
    internal class Program
    {
        class Car
        {
            public string color;
            private int temp;
            public int speed
            {
                get { return temp; }
                set
                {
                    if (value > 0)
                        temp = value;
                }
            }
        }
            
        static void Main(string[] args)
        {
            Car myCar=new Car();
            Console.WriteLine("Enter a number of speed");
            myCar.speed=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myCar.speed);
        }
    }
}
