using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ListPerson.Data;

namespace OOP_ListPerson.Infrastructure
{
    internal class ListPerson : IListPerson
    {
        public List<Person> InitListPerson(Person[] persons)
        {
            List<Person> listPerson = new List<Person>();
            listPerson.AddRange(persons);
            return listPerson;
        }

        public decimal TotalBasicSalary(List<Person> listPerson)
        {
            //, EnumRoles roles
            decimal result = 0M;
   
            result = listPerson.Sum(e => e.BasicSalary);
            return result;

        }

        public decimal TotalSalary(List<Person> listPerson)
        {
            decimal result = 0M;

            result = listPerson.Sum(e => e.TotalSalary);
            return result;
        }

        public decimal TotalSalaryByRole(List<Person> listPerson, EnumRoles roles)
        {
            decimal result = 0M;
            foreach(var i in listPerson)
            {
                if(i.Role.Equals(roles.ToString()))
                {
                    result+=i.TotalSalary;
                }
            }

            //result = listPerson.Where(x=>x.Role.Equals(roles.ToString())).Sum(e => e.TotalSalary++);
            return result;
        }


    }
}
