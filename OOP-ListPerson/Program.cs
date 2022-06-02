using System;
using System.Collections.Generic;
using OOP_ListPerson.Data;
using OOP_ListPerson.Infrastructure;

namespace OOP_ListPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //seed Person entities
            Customer customer1 = new Customer(120, "Andika", "Pratama", "3/3/2015");
            Customer customer2 = new Customer(121, "Budi Juna", "Chef", "8/15/2016");
            Customer customer3 = new Customer(122, "Charlie", "Van Dijk", "9/5/2017");

            Sales sales1 = new Sales(123, "Deni","Cagur","10/12/2017",500_000,200_000);
            Sales sales2 = new Sales(125, "Fatur", "Rohman", "1/15/2019", 350_000, 250_000);

            Employee employee1 = new Employee(124, "Ellise","Cantik", "1/15/2019",20_000,10_000);
            Employee employee2 = new Employee(126, "Gani", "Guna", "3/1/2019", 20_000, 10_000);

            //inject repository for business logic
            IListPerson repository = new ListPerson(); 
                //list containing seeded entities
              var list=repository.  InitListPerson(new Person[] { customer1, customer2, customer3, sales1, sales2, employee1, employee2 });

            //Implementation 1: Total Basic Salary of all Person
            var basicSalary = repository.TotalBasicSalary(list);
            Console.WriteLine($"Total basic salary of all person: {basicSalary}");

            //Implementation 2: Total Salary of all Person
            var salary = repository.TotalSalary(list);
            Console.WriteLine($"Total salary of all person: {salary}");

            //Implementation 3: Total Salary of all Employee
            var employeeSalary = repository.TotalSalaryByRole(list,EnumRoles.Employee);
            Console.WriteLine($"Total salary of all employee: {employeeSalary}");

            //Implementation 4: Total Salary of all Sales
            var salesSalary = repository.TotalSalaryByRole(list, EnumRoles.Sales);
            Console.WriteLine($"Total salary of all sales: {salesSalary}");

        }
    }
}
