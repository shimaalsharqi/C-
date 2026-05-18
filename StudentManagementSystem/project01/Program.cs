using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            SeedData(context);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Update Student");
                Console.WriteLine("3- Delete Student");
                Console.WriteLine("4- Get All Students");
                Console.WriteLine("5- Search Student");
                Console.WriteLine("6- LINQ Operations");
                Console.WriteLine("7- Report");
                Console.WriteLine("8- Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent(context); break;
                    case 2: UpdateStudent(context); break;
                    case 3: DeleteStudent(context); break;
                    case 4: GetAllStudents(context); break;
                    case 5: SearchStudent(context); break;
                    case 6: LinqOperations(context); break;
                    case 7: Report(context); break;
                    case 8: exit = true; break;
                }
            }
        }

        // ================= SEED DATA =================
        static void SeedData(AppDbContext context)
        {
            if (!context.Department01.Any())
            {
                Department d1 = new Department() { NameDepartment = "IT" };
                Department d2 = new Department() { NameDepartment = "Engineering" };
                Department d3 = new Department() { NameDepartment = "Business" };

                context.Department01.AddRange(d1, d2, d3);

                Course c1 = new Course() { Title = "C#", Hours = 3 };
                Course c2 = new Course() { Title = "Database", Hours = 4 };
                Course c3 = new Course() { Title = "Networking", Hours = 2 };
                Course c4 = new Course() { Title = "AI", Hours = 5 };
                Course c5 = new Course() { Title = "Math", Hours = 3 };

                context.Course01.AddRange(c1, c2, c3, c4, c5);

                List<Student> students = new List<Student>()
                {
                    new Student(){ Name="Ali", Age=20, Email="ali@gmail.com", Department=d1, Courses=new(){c1,c2}},
                    new Student(){ Name="Ahmed", Age=22, Email="ahmed@gmail.com", Department=d2, Courses=new(){c2,c3}},
                    new Student(){ Name="Sara", Age=19, Email="sara@gmail.com", Department=d3, Courses=new(){c1,c5}},
                    new Student(){ Name="Fatma", Age=21, Email="fatma@gmail.com", Department=d1, Courses=new(){c3,c4}},
                    new Student(){ Name="Mona", Age=24, Email="mona@gmail.com", Department=d2, Courses=new(){c2,c5}},
                    new Student(){ Name="Khalid", Age=23, Email="khalid@gmail.com", Department=d3, Courses=new(){c1,c4}},
                    new Student(){ Name="Noor", Age=20, Email="noor@gmail.com", Department=d1, Courses=new(){c3,c5}},
                    new Student(){ Name="Salim", Age=25, Email="salim@gmail.com", Department=d2, Courses=new(){c1,c2}},
                    new Student(){ Name="Huda", Age=22, Email="huda@gmail.com", Department=d3, Courses=new(){c4,c5}},
                    new Student(){ Name="Yousef", Age=21, Email="yousef@gmail.com", Department=d1, Courses=new(){c2,c3}},
                };

                context.Student01.AddRange(students);
                context.SaveChanges();

                Console.WriteLine("Seed Data Added Successfully");
            }
        }

        // ================= GET ALL =================
        static void GetAllStudents(AppDbContext context)
        {
            var students = context.Student01
                .Include(s => s.Department)
                .Include(s => s.Courses)
                .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"\nName: {s.Name}");
                Console.WriteLine($"Age: {s.Age}");
                Console.WriteLine($"Department: {s.Department?.NameDepartment}");

                Console.WriteLine("Courses:");
                foreach (var c in s.Courses)
                    Console.WriteLine($"- {c.Title}");
            }
        }

        // ================= SEARCH =================
        static void SearchStudent(AppDbContext context)
        {
            Console.Write("Enter Name (or part): ");
            string name = Console.ReadLine();

            Console.Write("Enter Age (0 to skip): ");
            int age = int.Parse(Console.ReadLine());

            var query = context.Student01
                .Include(s => s.Department)
                .AsQueryable();

            if (!string.IsNullOrEmpty(name))
                query = query.Where(s => s.Name.Contains(name));

            if (age > 0)
                query = query.Where(s => s.Age == age);

            var result = query.ToList();

            foreach (var s in result)
            {
                Console.WriteLine($"\n{s.Name} - {s.Age} - {s.Department?.NameDepartment}");
            }

            if (!result.Any())
                Console.WriteLine("No students found");
        }

        // ================= ADD =================
        static void AddStudent(AppDbContext context)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

          
            if (context.Student01.Any(s => s.Email == email))
            {
                Console.WriteLine("Email already exists!");
                return;
            }

            Console.Write("Department Id: ");
            int deptId = int.Parse(Console.ReadLine());

            Student s = new Student()
            {
                Name = name,
                Age = age,
                Email = email,
                DepartmentId = deptId
            };

            context.Student01.Add(s);
            context.SaveChanges();

            Console.WriteLine("Added Successfully");
        }

        // ================= UPDATE =================
        static void UpdateStudent(AppDbContext context)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            var s = context.Student01.FirstOrDefault(x => x.Id == id);

            if (s != null)
            {
                Console.Write("New Name: ");
                s.Name = Console.ReadLine();

                Console.Write("New Age: ");
                s.Age = int.Parse(Console.ReadLine());

                Console.Write("New Email: ");
                s.Email = Console.ReadLine();

                context.SaveChanges();

                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // ================= DELETE =================
        static void DeleteStudent(AppDbContext context)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            var s = context.Student01.FirstOrDefault(x => x.Id == id);

            if (s != null)
            {
                context.Student01.Remove(s);
                context.SaveChanges();
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // ================= LINQ =================
        static void LinqOperations(AppDbContext context)
        {
            Console.WriteLine("\n--- Students Older Than 20 ---");
            var older = context.Student01.Where(s => s.Age > 20).ToList();
            older.ForEach(s => Console.WriteLine(s.Name));

            Console.WriteLine("\n--- Student Names ---");
            context.Student01.Select(s => s.Name).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\n--- Order By Age ---");
            context.Student01.OrderBy(s => s.Age)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} - {s.Age}"));

            Console.WriteLine($"\nTotal Students: {context.Student01.Count()}");

            Console.WriteLine($"Any Age > 25: {context.Student01.Any(s => s.Age > 25)}");

            Console.WriteLine($"Average Age: {context.Student01.Average(s => s.Age)}");

            Console.WriteLine("\n--- Group By Department ---");

            var groups = context.Student01
                .Include(s => s.Department)
                .GroupBy(s => s.Department.NameDepartment);

            foreach (var g in groups)
            {
                Console.WriteLine($"\nDepartment: {g.Key}");
                foreach (var s in g)
                    Console.WriteLine($"- {s.Name}");
            }
        }

        // ================= REPORT (PART 9) =================
        static void Report(AppDbContext context)
        {
            var report = context.Student01
                .Include(s => s.Department)
                .GroupBy(s => s.Department.NameDepartment)
                .Select(g => new
                {
                    DepartmentName = g.Key,
                    StudentsCount = g.Count(),
                    AverageAge = g.Average(s => s.Age)
                })
                .ToList();

            Console.WriteLine("\n--- Department Report ---");

            foreach (var item in report)
            {
                Console.WriteLine($"\nDepartment: {item.DepartmentName}");
                Console.WriteLine($"Number Of Students: {item.StudentsCount}");
                Console.WriteLine($"Average Age: {item.AverageAge}");
            }
        }
    }
}