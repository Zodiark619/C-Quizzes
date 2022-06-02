using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ListPerson.Infrastructure;

namespace OOP_ListPerson.Data
{
    internal class Sales:Person
    {
        private decimal bonus;
        private decimal commision;

        public Sales(int empId, string firstName, string lastName, string joinDate,decimal bonus,decimal commision) : base(empId, firstName, lastName, joinDate)
        {
            this.bonus = bonus;
            this.commision = commision;
            Role = EnumRoles.Sales.ToString();

            BasicSalary = 3_000_000;
            TotalSalary = BasicSalary + this.bonus + this.commision;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Basic Salary:{this.BasicSalary} | Total Salary:{this.TotalSalary} | Bonus:{this.Bonus} | Commision:{this.Commision}";
        }
        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }
    }
}
