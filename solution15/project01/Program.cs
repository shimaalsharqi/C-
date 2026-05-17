using System.Diagnostics.Metrics;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext db = new AppDbContext();
            students s1 = new students();
            students s2 = new students();
            Courses c1 = new Courses();
            Console.WriteLine("Enter first name");
            s1.name = Console.ReadLine();
                s1.age = 23;
            db.Add(s1);
            db.SaveChanges();
            Console.WriteLine("Enter second name");
            s2.name = Console.ReadLine();
            s2.age = 22;
            db.Add(s2);
            db.SaveChanges();
        }
    }
}
