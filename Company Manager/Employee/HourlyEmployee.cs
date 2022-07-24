using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class HourlyEmployee:Employee
    {
        private int _hours;
        public HourlyEmployee(string firstName, string lastName, int experience, string prof, int hours) :
            base(firstName, lastName, experience, prof)
        {
            _hours = hours;
        }
        public override void Salary(int experience, double _baseSalary)
        {
            _salary = (_baseSalary/20)* _hours + (_baseSalary * 0.1);
        }
        public override string ToString()
        {
            return
                $"{_salary }";
        }
    }
}
