using System.Collections.Generic;

namespace Company_Manager
{
    internal class Company
    {       
        private string _nameCompany;
        public List<Executive> companyExecutives = new List<Executive>();
        public List<Manager> companyManagers = new List<Manager>();
        public List<Employee> companyEmployee = new List<Employee>();

        public Company(string nameCompany)
        {
            _nameCompany = nameCompany;
        }
        public void AddManager(Manager manager)
        {
            companyManagers.Add(manager);
            manager.Salary(manager._experience, manager._baseSalary);            
        }
        public void AddExecutive(Executive executive)
        {
            companyExecutives.Add(executive);
            executive.Salary(executive._experience, executive._baseSalary);
        }
        public void AddEmployee(Employee employee)
        {            
            companyEmployee.Add(employee);
            employee.Salary(employee._experience, employee._baseSalary);
        }
        public void AddEmployee(Employee employee, Manager manager)
        {
            manager.AddManagerEmployees(employee, manager);
            companyEmployee.Add(employee);
            employee.Salary(employee._experience, employee._baseSalary);
        }
        public void Promotion(Employee employee, string prof)
        {
            if (employee is Manager)
            {
                var executive = new Executive(employee._firstName, employee._lastName, employee._experience, prof);
                companyManagers.Remove((Manager)employee);
                executive.Salary(employee._experience, employee._baseSalary);
                companyExecutives.Add(executive);
            }
            if (employee is Employee)
            {               
                var mamager = new Manager(employee._firstName, employee._lastName, employee._experience, prof);
                companyEmployee.Remove(employee);
                mamager.Salary(employee._experience, employee._baseSalary);
                companyManagers.Add(mamager);
            }           
        }
        public void RemoveEmployee(Employee employee)
        {
            if (employee is Manager)
            {
                companyManagers.Remove((Manager)employee);
            }
            if (employee is Executive)
            {
                companyExecutives.Remove((Executive)employee);
            }
            if (employee is Employee)
            {
                companyEmployee.Remove((Employee)employee);
            }
        }
        public void Print(Company company)
        {          
            Service.PrintList(company);
        }
        public override string ToString()
        {
            return
                $"В компании {_nameCompany} работает:\n" +
                $"Дирректор - {companyExecutives.Count}\n" +
                $" {companyManagers.Count} менеджер и {companyEmployee.Count} рабочих";
        }
    }
}

