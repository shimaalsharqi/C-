namespace project01
{
    internal class Program
    {

        #region association
        //public class student
        //{
        //    public string name;
        //}
        //public class course
        //{
        //    public string name;

        //    public void study(student stu01)
        //    {
        //        Console.WriteLine($"{stu01.name} will study {name} ");
        //    }
        //}
        #endregion

        #region Aggregation
        //public class employee
        //{
        //    public string name;
        //}
        //public class department
        //{
        //    public string name;
        //    public List<employee> employees;
        //    public department(string name1)
        //    {
        //        name = name1;
        //        employees = new List<employee>();
        //    }
        //}
        
        #endregion
        static void Main(string[] args)
        {



            #region main association
            //student st = new student { name = "shima" };
            //course cu = new course { name = "math" };
            //cu.study(st);
            #endregion
            #region main aggregation
            //employee emp01 = new employee { name = "manar" };
            //employee emp02 = new employee { name = "shima" };
            //department d = new department("IT");
            //d.employees.Add(emp01);
            //d.employees.Add(emp02);
            //Console.WriteLine(d.name);
            //foreach (employee e in d.employees)
            //{
            //    Console.WriteLine(e.name);
            //}
            #endregion

        }
    }
}
