using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DataStructuresAndLINQ.Employees.EmployeeHelper
{
    public class clsAggregate
    {
        public static decimal TotalSalary(List<Employees> employeesList)
        {
            if (employeesList.Count <= 0)
                return 0.00M;

            return employeesList.Sum(emp => emp.Salary);
        }

        public static decimal AvgSalary(List<Employees> employeesList)
        {
            if (employeesList.Count <= 0)
                return 0.00M;

            return employeesList.Average(emp => emp.Salary);
        }

        public static decimal MaximumSalary(List<Employees> employeesList)
        {
            if (employeesList.Count <= 0)
                return 0.00M;

            return employeesList.Max(emp => emp.Salary);
        }

        public static decimal MinimumSalary(List<Employees> employeesList)
        {
            if (employeesList.Count <= 0)
                return 0.00M;

            return employeesList.Min(emp => emp.Salary);
        }

        public static List<decimal> AllSalaries(List<Employees> employeesList)
        {
            return employeesList.Select(emp => emp.Salary).ToList();
        }

       public  static void SalaryBetweenMinMax(List<Employees> employees)
        {

            clsEmployeeHelper.stringFormat();
            if (employees == null || employees.Count == 0)
            {
                WriteLine("No employees to display.");
                return;
            }


            decimal minSalary = employees.Min(e => e.Salary);
            decimal maxSalary = employees.Max(e => e.Salary);
            decimal totalSalary = employees.Sum(e => e.Salary);
            decimal avgSalary = employees.Average(e => e.Salary);

            var betweenSalaries = employees
                .Where(e => e.Salary > minSalary && e.Salary < maxSalary)
                .OrderByDescending(e => e.Salary);

            //WriteLine("Salaries Between Min and Max:{0} \n", string.Join("\n", employees.
            //    Where(emp => emp.Salary > minSalary && emp.Salary < maxSalary).
            //    Select(emp => emp.Salary.ToString("C")).
            //    OrderByDescending(s => s)))

            WriteLine("\nEmployees With Salary Between Min And Max:\n");

            foreach (var emp in betweenSalaries)
            {
                WriteLine(emp);
            }
           
        }

    }
}
