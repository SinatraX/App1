// Jay Bai
// Cs2Apps
// TINFO-200

////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date             Developer       Description of change
// 2022-02-11       Jay             Initial file creation
// 2022-02-12       Jay             Add main string methods
// 2022-02-12       Jay             Add description of each part of the program
// 2022-02-12       Jay             Re-check the codes and run the program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    class Employee
    {
        // Here is to enter the employee's first Name 
        public string FirstName { get; set; }
        // Here is to enter the employee's last Name
        public string LastName { get; set; }
        private decimal salary;
        // instance variables

        // Constructor
        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }
    }
}
