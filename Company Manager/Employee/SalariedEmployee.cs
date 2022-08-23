using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class SalariedEmployee:Employee
    { 
        public SalariedEmployee(string firstName, string lastName, int experience, string prof) :
            base(firstName, lastName, experience, prof)
        {

        }
        public override void Salary(int experience, double _baseSalary)
        {
            _salary = (experience/20 * _baseSalary) + (_baseSalary * 1.5);
        }
        public override string ToString()
        {
            return
                $"{_firstName} {_lastName}-{_prof}\n" +
                $"Опыт работы {_experience} лет\tЗарплата: {_salary}";
        }
    }
}
