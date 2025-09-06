using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DataStructuresAndLINQ.Employees.EmployeeHelper
{
    public class clsEmployeeHelper
    {
        public static void stringFormat()
        {
            string S1 = string.Format("{0,-20} | {1,-15} | {2,11:C} | {3,11}",
                  "Name", "Department", "Salary", "Rating:");
            WriteLine(S1 + "\n");
        }
    }
}
