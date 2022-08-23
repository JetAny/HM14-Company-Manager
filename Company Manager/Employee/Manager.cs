using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class Manager:Employee
    {

        public List<Employee> managersEmployee = new List<Employee>();
        public int CountEmployees { get; set; }
        
        public Manager(string firstName, string lastName, int experience, string prof) :
            base(firstName, lastName, experience, prof)
        {

        }
        
        public  void AddManagerEmployees(Employee employee, Manager manager)
        {
            managersEmployee.Add(employee);
            manager.Salary(manager._experience,manager._baseSalary);

        }
        public override void Salary(int experience, double _baseSalary)
        {
           _salary = ((experience/5) * _baseSalary) + (_baseSalary* 0.3)+ (managersEmployee.Count*120) ;
            
        }
        public override string ToString()
        {
            return
                $"{_firstName} {_lastName} - {_prof}\n" +
                $"Опыт работы {_experience} лет\tЗарплата: {_salary}\n" +
                $"У менеджера в подчинении находится: {managersEmployee.Count} рабочих";
        }

    }
}
