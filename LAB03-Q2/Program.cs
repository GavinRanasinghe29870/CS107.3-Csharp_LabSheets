using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_Q2
{
    public class Employee
    {
        private int employeeId;
        private string fullName;
        private double salary;

        public Employee(int employeeId, string fullName, double salary)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.salary = salary;
        }

        public int EmployeeId => this.employeeId; //read only property

        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Employee Name: {fullName}");
            Console.WriteLine($"Employee Salary(Rs.): {salary}");
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "Joshua Rajapaksha", 500000);
            employee.DisplayEmployeeInfo();

            Console.WriteLine($"Employee ID: {employee.EmployeeId}");

            employee.FullName = "Dulith Rupasinghe";
            Console.WriteLine($"Updated Full Name: {employee.FullName}");

            employee.Salary = 600000;
            Console.WriteLine($"Updated Salary: {employee.Salary}");

            Console.ReadLine();
        }
    }
}
