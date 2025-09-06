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
   // public delegate void PrintAggregatesDelegate(List<Employees> employeesList);

    private static void _PrintTotalSalary(List<Employees> employeesList)
    {
        WriteLine("\nTotal Salary {0}\n", clsAggregate.TotalSalary(employeesList));

    }

    private static void _PrintAverageSalary(List<Employees> employeesList)
    {
        WriteLine($"\nAvg Salary: {clsAggregate.AvgSalary(employeesList)}\n");
    }

    private static void _PrintMaxSalary(List<Employees> employeesList)
    {
        WriteLine("\nMaximum Salary: {0:C}\n", clsAggregate.MaximumSalary(employeesList));
    }

    private static void _PrintMinSalary(List<Employees> employeesList)
    {
        WriteLine("\nMinimum Salary: " + clsAggregate.MinimumSalary(employeesList) + "\n\n");    
    }

    private static void _PrintSalaryBetweenMinMax(List<Employees> employeesList)
    {
        clsAggregate.SalaryBetweenMinMax(employeesList);
    }

    private static void _PrintAllSalaries(List<Employees> employeesList)
    {
        WriteLine("\nSalaries List:\n{0}", string.Join("\n", employeesList));
    }
    public static async Task Run()
    {
        List<Employees> employees = new List<Employees>();

        employees = await Employees_DataAccess.GetEmps();

        Action<List<Employees>> printAggregateAction = _PrintTotalSalary;
        printAggregateAction += _PrintAverageSalary;
        printAggregateAction += _PrintMaxSalary;
        printAggregateAction += _PrintMinSalary;
        printAggregateAction += _PrintSalaryBetweenMinMax;

        printAggregateAction(employees);















        //_PrintTotalSalary (employees);

        //_PrintAverageSalary(employees);

        //_PrintMaxSalary(employees);

        //_PrintMinSalary(employees);

        //WriteLine("\n\n");
        //_PrintAllSalaries(employees);

        //WriteLine("\nSalary Between Min And Max:\n");
        //_PrintSalaryBetweenMinMax(employees);
    }
}

