using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndLINQ.Employees
{

    public class Employees
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int PerformanceRating { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-20} | {1,-15} | {2,11:C} | Rating: {3,3}",
                Name, Department, Salary, PerformanceRating);
        }

    }

}
