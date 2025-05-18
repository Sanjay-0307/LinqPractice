using LinqPractice.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace LinqPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {

            // ----------Basic Level Linq query

            // 1.Find all even numbers from the list.

            List<int> numbers = new List<int> { 10, 15, 21, 30, 45, 50, 60, 75, 80, 90 };

            // var result = numbers.Where(n => n % 2 == 0).ToList();
            //  Console.WriteLine("Even Numbers:");
            //result.ForEach(Console.WriteLine(n));

            //2. Get all numbers greater than 50

            //var result = numbers.Where(n => n > 50).ToList();
            //3. Get the square of each number.
            //var result = numbers.Select(n => Math.Sqrt(n)).ToList(); square root

            //var result = numbers.Select(n => n*n).ToList(); square


            //4. Find the sum of all numbers.

            //var result = numbers.Sum();
            //Console.WriteLine(result);

            // 5.Find maximum and minimum from the list.
            //var result = numbers.Max();
            //var result1 = numbers.Min();

            // 6.Sort numbers in descending order.

            //var result = numbers.OrderByDescending(n => n).ToList();


            // 7.Check if all numbers are divisible by 5.

            //bool result = numbers.All(n=>n%5==0);


            // 8.Count how many numbers are less than 50.

            // int result = numbers.Count(n => n < 50);
            //foreach (var number in result)
            //{
            //    System.Diagnostics.Debug.WriteLine(number);
            //}

            //9.Get numbers between 30 and 75.

            // var result = numbers.Select(n => n > 30 && n < 75).ToList();
            //var result = numbers.Where(n => n > 30 && n < 75).ToList();

            //10.Find first number greater than 40.
            var result = numbers.FirstOrDefault(n => n > 40);

            //11.Get all fruit names starting with 'A'.

            List<string> fruits = new List<string> { "Apple", "Banana", "Apricot", "Orange", "Avocado", "Grapes" };

            //var res = fruits.Where(f => f.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();


            //12.Get fruit names with more than 6 characters.
            // var res = fruits.Where(f => f.Length > 6).ToList();

            //13.Sort fruit names alphabetically.
            //var res = fruits.OrderBy(f => f);

            //14.Convert all fruit names to uppercase.
            //var res = fruits.Select(f=>f.ToUpper());

            //15.Count how many fruit names contain the letter 'a'.

            // var res=fruits.Where(f=>f.StartsWith("A")).ToList().Count;











            //---------Intermediate Level 

            List<students> student = new List<students> {
            new students { Id = 1, Name = "John", Age = 18, Marks = 85 },
            new students { Id = 2, Name = "Jane", Age = 19, Marks = 92 },
            new students { Id = 3, Name = "Jake", Age = 17, Marks = 78 },
            new students { Id = 4, Name = "Emily", Age = 20, Marks = 88 },
            new students { Id = 5, Name = "Anna", Age = 18, Marks = 69 }

            };

            //1.Get all students with marks > 80.
            //var result = student.Where(m=>m.Marks>80).ToList();

            //2.Get students sorted by marks descending.
            //var resultDesc = student.OrderByDescending(m => m.Marks).ToList();

            //3.Get names of students older than 18.
            //var StduentsName =student.Where(m => m.Age>18).ToList();
            //var res= StduentsName.Select(m => m.Name).ToList();
            //Combine 2 in 1 line
            // var res=student.Where(m=>m.Age>18).Select(m=>m.Name).ToList(); 

            //4. Find average marks of all students.
            // var studentAvg= student.Average(x => x.Marks);

            //5.Get names of top 3 students.
            //var topStudents = student.Select(m=>m.Name).Take(3).ToList();

            //6.Group students by Age.
            // var groupByAge=student.GroupBy(x => x.Age).ToList();

            //7.Check if any student scored 100 marks.
            // var studentWIthScore = student.Any(x => x.Marks > 100);

            //8.Find student with lowest marks.
            //var lowestMarks= student.OrderBy(x => x.Marks).FirstOrDefault();

            // 9.Create list of student names only.

            // var listOfStudents = student.Select(x=>x.Name).ToList();

            // 10.Count how many students are aged 18.
            // var countStudents = student.Where(x => x.Age > 18).Count();

            //11.Find students whose names start with 'J'.
            //var stuCharJ = student.Where(x => x.Name.StartsWith("J", StringComparison.OrdinalIgnoreCase)).Select(x => x.Name).ToList();
            //var res= stuCharJ.StartsWith("J").ToString();

            //12.Find the total sum of marks.
            //var totalMarks = student.Sum(x => x.Marks);

            //13.Select Name and Marks into a new anonymous object.
            //var Marks = student.Select(x => new { x.Name, x.Marks }).ToList();

            //14.Skip the first 2 students and take the next 2.
            //var takeSkip = student.Skip(2).Take(2).ToList();

            //15.Check if all students have marks above 60.
            //var checkMarks = student.All(x => x.Marks > 60);



            //16.Convert student names to lowercase.
            // var nameLower= student.Select(x=>x.Name.ToLower());

            //17.Find the student with the longest name.
            //var nameDescending = student.OrderByDescending(x => x.Name.Length).FirstOrDefault();


            //18.Get a list of distinct ages.
            // var dist =student.Select(x=>x.Age).Distinct().ToList();

            //19.Create dictionary of Id and Name.
            // var studentDic = student.ToDictionary(x => x.Id, x => x.Name);

            //20.Get student(s) with maximum marks.

            //int maxMarks = student.Max(x => x.Marks);
            //var topStudents = student.Where(x => x.Marks == maxMarks).ToList();





            // ------------------Advance level


            List<Employee> employees = new List<Employee> {
            new Employee { Id = 1, Name = "Alice", Dept = "HR", Salary = 60000 },
            new Employee { Id = 2, Name = "Bob", Dept = "IT", Salary = 80000 },
            new Employee { Id = 3, Name = "Charlie", Dept = "HR", Salary = 55000 },
            new Employee { Id = 4, Name = "David", Dept = "Finance", Salary = 75000 },
            new Employee { Id = 5, Name = "Eva", Dept = "IT", Salary = 90000 }
};
            //1. Get all employees in IT department.

            //var deptEmp= employees.Where(d=>d.Dept=="IT").Select(e => e.Name).ToList();

            //2.Get employees with salary > 70000.
            // var getEmp = employees.Where(x=>x.Salary>70000).ToList();

            //3.Group employees by department.
            //var groupDept = employees.GroupBy(x => x.Dept).ToList();

            //4.Get highest paid employee in each department.
            // decimal maxSalary = employees.Max(x => x.Salary);
            //var byDept= employees.Where(x => x.Salary == (maxSalary)).Select(x => x.Dept).ToList();

            //var byDept = employees.GroupBy(e => e.Dept).Select(g => g.Where(e=>e.Salary == g.Max(y => y.Salary))).SelectMany(e=>e).ToList();

            //5.Find total salary of all employees.
            //var totalSalary = employees.Sum(x => x.Salary);




            //6.Sort employees by salary descending.

            // var empSalaryDesc = employees.OrderByDescending(x => x.Salary);

            //7.Create new list of Name and Salary.
            // var Marks = student.Select(x => new { x.Name, x.Marks }).ToList();
            //var listEmployees = employees.Select(x => new { x.Name, x.Salary });

            //8.Count employees in each department.
            // var countEmp = employees.GroupBy(x => x.Dept).Select(g => new { department = g.Key, count = g.Count() }).ToList();


            //9.Get average salary in the company.

            //var avgSalary=employees.Average(x => x.Salary);


            //10.Check if any employee has salary less than 50000.

            //  var chkSalary = employees.Any(x => x.Salary < 50000);


            //11.Find the department with highest average salary.
            //var deptMaxSalary = employees.GroupBy(x => x.Dept).Select(x => new { key = x.Key, AvgSalary = x.Average(y => y.Salary) });



            //12.Create a dictionary of Employee Id and Name.
            //var empDictionary = employees.ToDictionary(e => e.Id, e => e.Name);



            //13.Find employee(s) with highest salary.

           // var maxSalary= employees.Max(e => e.Salary);
            //var topEmployees=employees.Where(x=>x.Salary == maxSalary).ToList();



            //14.Get all departments as a distinct list.
            //var distDept = employees.Select(x => x.Dept).Distinct().ToList();

            //15.List employee names sorted by department, then salary.

            //var empSortbyNameSalary = employees.OrderBy(x => x.Dept).ThenBy(x => x.Salary).Select(x => x.Name).ToList();



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}