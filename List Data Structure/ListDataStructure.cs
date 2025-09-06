using DataStructuresAndLINQ.Employees;
using DataStructuresAndLINQ.Employees.EmployeeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Console;
internal class ListDataStructure
{

    //
   

    private static void _PrintTotalSalary(List<Employees> employeesList)
    {
        WriteLine("Total Salary {0}\n", clsAggregate.TotalSalary(employeesList));

    }

    private static void _PrintAverageSsalary(List<Employees> employeesList)
    {
        WriteLine($"Avg Salary: {clsAggregate.AvgSalary(employeesList)}\n");
    }

    private static void _PrintMaxSalary(List<Employees> employeesList)
    {
        WriteLine("Maximum Salary: {0:C}\n", clsAggregate.MaximumSalary(employeesList));
    }

    private static void _PrintMinSalary(List<Employees> employeesList)
    {
        WriteLine("Minimum Salary: " + clsAggregate.MinimumSalary(employeesList).ToString("C") + "\n");    
    }

    private static void _PrintSalaryBetweenMinMax(List<Employees> employeesList)
    {
        clsAggregate.SalaryBetweenMinMax(employeesList);
    }
    public static async Task Run()
    {
        List<Employees> employees = new List<Employees>();
        employees = await Employees_DataAccess.GetEmps();

        _PrintTotalSalary (employees);

        _PrintAverageSsalary(employees);

        _PrintMaxSalary(employees);

        _PrintMinSalary(employees);

        WriteLine("\nSalary Between Min And Max:\n");
        _PrintSalaryBetweenMinMax(employees);
    }
}

