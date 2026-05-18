using System;
using System.Collections.Generic;

namespace project01
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        // Navigation Property
        public Department Department { get; set; }

        // Many-to-Many
        public List<Course> Courses { get; set; } = new();
    }
}