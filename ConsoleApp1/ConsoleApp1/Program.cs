namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello before method");
           String myfun = await GetNumber();
            Console.WriteLine(myfun);
            Console.WriteLine("Hello after method");
        }
        static async Task<string> GetNumber()
        {
            await Task.Delay(3000);
            return "Hello from async method";
        }
    }
}
