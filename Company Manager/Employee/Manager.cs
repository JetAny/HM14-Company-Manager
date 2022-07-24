using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class Manager:Employee
    {
        List<Employee> employeeManadgers = new List<Employee>();
        public Manager(string firstName, string lastName, int experience, string prof) :
            base(firstName, lastName, experience, prof)
        {

        }
        public void AddEmployee(Employee employee)
        {
            employeeManadgers.Add(employee);
            
        }
        public override void Salary(int experience, double _baseSalary)
        {
            _salary = ((experience/20) * _baseSalary) + (_baseSalary* 0.3)+(employeeManadger.Count*0.1);
        }
        
    }
}
