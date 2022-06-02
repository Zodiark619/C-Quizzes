using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ListPerson.Data;

namespace OOP_ListPerson.Infrastructure
{
    internal interface IListPerson
    {
        public List<Person> InitListPerson(Person[] persons);
      
        public decimal TotalBasicSalary(List<Person> listPerson);

        public decimal TotalSalary(List<Person> listPerson);

        public decimal TotalSalaryByRole(List<Person> listPerson,EnumRoles roles);


    }
}
