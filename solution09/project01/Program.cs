namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            string[] StudentName = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your name");
                StudentName[i] = Console.ReadLine();
            }
            Console.WriteLine(" your names are :");

            foreach (string name in StudentName)
            {
                Console.WriteLine(name);
            }
            #endregion
            #region Part2
            int[,] grades = new int[5, 3];

            string[] subjects = { "Math", "Science", "English" };

            Console.WriteLine("Enter grades for each student:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter grade {StudentName[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{subjects[j]}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            #endregion
            #region Part 3

            Console.WriteLine("The name of student and grade");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{StudentName[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($" {subjects[j]}: {grades[i, j]} ");
                }
            }
            #endregion
            #region Part 4
            Console.WriteLine("Student Averages:");
            double[] avg = new double[5];
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }
                avg[i] = sum / 3.0;
                Console.WriteLine($"{StudentName[i]}: {avg[i]}");
            }



            #endregion
            #region Part5
            Console.WriteLine("Jagged Array Example:");

            int[][] jaggedGrades = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number of subjects for {StudentName[i]}: ");
                int numSubjects = int.Parse(Console.ReadLine());

                jaggedGrades[i] = new int[numSubjects];

                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"Grade {j + 1}: ");
                    jaggedGrades[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged Array Data:");
            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"{StudentName[i]} ({jaggedGrades[i].Length} subjects): ");

                foreach (int g in jaggedGrades[i])
                {
                    Console.Write(g + " ");
                }
                Console.WriteLine();
            }
            #endregion
            #region Part 6
            Console.Write("Enter student name to search: ");
            string searchName = Console.ReadLine();

            int index = -1;

            for (int i = 0; i < StudentName.Length; i++)
            {
                if (StudentName[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine($"Student found at index: {index}");
            else
                Console.WriteLine("Student not found.");
            #endregion
            #region Part7 

            //  Highest Grade

            int highest = grades[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] > highest)
                    {
                        highest = grades[i, j];
                    }
                }
            }
            Console.WriteLine($"Highest Grade: {highest}");
            // BONUS TASKS
            // 1. Sort students alphabetically
            Array.Sort(StudentName);
            Console.WriteLine("Students sorted alphabetically:");
            foreach (var s in StudentName)
                Console.WriteLine(s);

            // 2. Student with highest average
            double maxAvg = avg[0];
            int maxIndex = 0;

            for (int i = 1; i < avg.Length; i++)
            {
                if (avg[i] > maxAvg)
                {
                    maxAvg = avg[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Top Student: {StudentName[maxIndex]} with average {maxAvg:F2}");

            // 3. Count passed students
            int passCount = 0;

            for (int i = 0; i < avg.Length; i++)
            {
                if (avg[i] >= 50)
                    passCount++;
            }

            Console.WriteLine($"Passed Students: {passCount}");

            #endregion



        }
    
    }
}
