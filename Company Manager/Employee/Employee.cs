using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal abstract class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _experience;
        private string _prof;
        public double _salary { get; set; }
        private double _baseSalary { get;  } = 1000;

        public Employee(string firstName, string lastName, int experience, string prof)
        {
            _firstName = firstName;
            _lastName = lastName;
            _experience = experience;
            _prof = prof;
           
        }
        public abstract void Salary(int experience,double _baseSalary);
       

    }
}
