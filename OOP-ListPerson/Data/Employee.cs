using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ListPerson.Infrastructure;

namespace OOP_ListPerson.Data
{
    internal class Employee:Person
    {
        private decimal transportation;
        private decimal lunchFee;

        public Employee(int empId, string firstName, string lastName, string joinDate, decimal transportation,decimal lunchFee) : base(empId, firstName, lastName, joinDate)
        {
            this.transportation = transportation;
            this.lunchFee = lunchFee;
            Role = EnumRoles.Employee.ToString() ;
            BasicSalary = 5_000_000;
            TotalSalary=BasicSalary+this.lunchFee+this.transportation;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Basic Salary:{this.BasicSalary} | Total Salary:{this.TotalSalary}";
        }

        public decimal Transportation { get => transportation; set => transportation = value; }
        public decimal LunchFee { get => lunchFee; set => lunchFee = value; }
    }
}
