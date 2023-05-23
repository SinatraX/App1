// Jay Bai
// Cs2Apps
// TINFO-200

////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date             Developer       Description of change
// 2022-02-11       Jay             Initial file creation
// 2022-02-11       Jay             Add main string methods
// 2022-02-11       Jay             Add description of each part of the program
// 2022-02-11       Jay             Re-check the codes and run the program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    internal class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Employee names and decimal methods
            Employee empl1 = new Employee("Jay", "Inslee", (decimal)171898.00);
            Employee empl2 = new Employee("Eric", "Adams", (decimal)210000.00);
            Employee empl3 = new Employee("Eric", "Garcetti", (decimal)248141.00);

            // Employee A name and salary
            Console.WriteLine("Employee A First Name: {0}", empl1.FirstName);
            Console.WriteLine("Employee A Last Name: {0}", empl1.LastName);
            Console.WriteLine("Employee A Salary: {0:C}", empl1.Salary);

            // Employee B name and salary
            Console.WriteLine("Employee B First Name: {0}", empl2.FirstName);
            Console.WriteLine("Employee B Last Name: {0}", empl2.LastName);
            Console.WriteLine("Employee B Salary: {0:C}", empl2.Salary);

            // Employee C name and salary
            Console.WriteLine("Employee C First Name: {0}", empl3.FirstName);
            Console.WriteLine("Employee C Last Name: {0}", empl3.LastName);
            Console.WriteLine("Employee C Salary: {0:C}", empl3.Salary);

            // 10% raise methods for employee A B C
            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            empl1.Salary = empl1.Salary * (decimal)1.1;
            empl2.Salary = empl2.Salary * (decimal)1.1;
            empl3.Salary = empl3.Salary * (decimal)1.1;
            Console.WriteLine("Employee A new salary: {0:C}", empl1.Salary);
            Console.WriteLine("Employee B new salary: {0:C}", empl2.Salary);
            Console.WriteLine("Employee C new salary: {0:C}", empl3.Salary);

            // End
            Console.ReadLine();
        }
    }
}
