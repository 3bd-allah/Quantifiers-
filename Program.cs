using LINQTut06.Shared;

namespace LINQ.Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();


            #region Any() method syntax 
            //var result1 = emps.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(result1);

            //var result2 = emps.Any(x => x.Skills.Count > 0);
            //Console.WriteLine(result2);

            #endregion


            #region  All()   method syntax 

            //var result = emps.All(x => !string.IsNullOrWhiteSpace(x.Email));
            //Console.WriteLine(result);

            //var result1 = emps.All(x => x.Skills.Any(skill => skill == "C#"));
            //Console.WriteLine(result1);
            #endregion


            #region All() , Any() Query syntax
                
            //var query = from emp in emps
            //                where emp.Skills.Any(s => s == "C++")
            //                select emp;

            //query.Print("employees with C++ skill"); 

            //var query2 = from emp in emps
            //             where emp.Skills.All(s => s.Length >3 )
            //             select emp;

            //query2.Print("Employees with skill more than 3 char");

            #endregion

            #region Contains() 

            var result = emps.Any(x => x.Name.Contains("ee"));
            Console.WriteLine(result);

            var e = new Employee { Email = "Cole.Cochran@example.com" };

            var result2 = emps.Contains(e);
            Console.WriteLine(result2);

            #endregion

        }
    }
}