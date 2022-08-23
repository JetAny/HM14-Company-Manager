using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal abstract class Employee
    {
        public string _firstName { get; }
        public string _lastName { get; }
        public int _experience { get; }
        public string _prof { get; set; }
        public double _salary { get; set; }
        public double _baseSalary { get;  } = 1000;
        
        public Employee(string firstName, string lastName, int experience, string prof)
        {
            _firstName = firstName;
            _lastName = lastName;
            _experience = experience;
            _prof = prof;
           
        }
        public abstract void Salary(int experience,double _baseSalary);

        public override string ToString()
        {
            return 
                $"{_firstName} {_lastName}-{_prof}\n" +
                $"Опыт работы {_experience} лет\tЗарплата: {_salary}";
        }

        public static explicit operator Employee(List<Manager> v)
        {
            throw new NotImplementedException();
        }
    }
}
