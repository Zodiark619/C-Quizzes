using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ListPerson.Data
{
    internal class Person
    {
        private int empId;
        private string firstName;
        private string lastName;
        private string joinDate;
        private string role;
        private decimal basicSalary;
        private decimal totalSalary;

        public Person(int empId, string firstName, string lastName, string joinDate)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
           
        }

        public override string? ToString()
        {
            return $"EmployeeId:{this.empId} | Name:{this.firstName+" "+this.lastName} | Join Date:{this.JoinDate} | Role:{this.role}";
        }

        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JoinDate { get => joinDate; set => joinDate = value; }
        public string Role { get => role; set => role = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
