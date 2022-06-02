using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ListPerson.Infrastructure;

namespace OOP_ListPerson.Data
{
    internal class Customer : Person
    {
        public Customer(int empId, string firstName, string lastName, string joinDate) : base(empId, firstName, lastName, joinDate)
        {
            BasicSalary = 0;
            TotalSalary = 0;
            Role = EnumRoles.Customer.ToString();

        }
        public override string ToString()
        {
            return $"{base.ToString()} | Basic Salary:{this.BasicSalary} | Total Salary:{this.TotalSalary}";
        }
    }
}
