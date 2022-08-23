using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class Executive : Employee
    {
        public List<Employee> employeeExecutives = new List<Employee>();
        public Executive(string firstName, string lastName, int experience, string prof) :
            base(firstName, lastName, experience, prof)
        {

        }
        public void AddEmployee(Employee employee, Manager manager)
        {
            employeeExecutives.Add(employee);
            employee.Salary(_experience, _baseSalary);


        }
        public override void Salary(int experience, double _baseSalary)
        {
            _salary = ((experience / 20) * _baseSalary) + (_baseSalary * 4);
        }

        public override string ToString()
        {
            return
                $"{_firstName} {_lastName} - {_prof}\n" +
                $"Опыт работы {_experience} лет\tЗарплата: {_salary}\n";
        }
    }
    
}
