using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullTimeEmployee = new FullTimeEmployeeModel()
            {
                EmployeeId = 1,
                EmployeeName = "Benjamin",
                Department = "IT",
                HourlyRate = 230.69M
            };

            Console.WriteLine($"{fullTimeEmployee.EmployeeName} in {fullTimeEmployee.Department} earned R{fullTimeEmployee.CalculateMonthlyPay()}");

            var partTimeEmployee = new PartTimeEmployeeModel
            {
                EmployeeId = 2,
                EmployeeName = "Yashna",
                Department = "Biology",
                HourlyRate = 125.56M
            };

            Console.WriteLine($"{partTimeEmployee.EmployeeName} in {partTimeEmployee.Department} earned R{partTimeEmployee.CalculateMonthlyPay()}");

            var contractor = new ContractorModel
            {
                EmployeeId = 2,
                EmployeeName = "Tim",
                Department = "Construction",
                HourlyRate = 86.89M,
                HoursWorked = 35
            };
            Console.WriteLine($"{contractor.EmployeeName} in {contractor.Department} has worked {contractor.HoursWorked} hours and earned R{contractor.CalculateMonthlyPay()}");

        }
    }
}
